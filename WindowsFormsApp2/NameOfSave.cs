﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public partial class NameOfSave : Form
    {

        WordsStaticCheck WSC = new WordsStaticCheck();

        public NameOfSave()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string FileName = textBox1.Text;
            if (textBox1.Text != null)
            {
                SaveData(FileName);
                this.Close();
            }
            else MessageBox.Show("Введите имя файла.", "Ошибка");
        }

        public static void SaveData(string name) // 
        {
            if(MainForm.NumberOfQuiz == 1)
            using (StreamWriter fileWrite = new StreamWriter(@"Saves\Text\" + name))
            {
                foreach (var elem in Dictionary.DictForCheck)
                {
                    fileWrite.WriteLine(elem.Key.ToString() + ":" + elem.Value.ToString());
                }
                fileWrite.Close();
            }

            else if (MainForm.NumberOfQuiz == 2)
            {
                using (StreamWriter fileWrite = new StreamWriter(@"Saves\Images\" + name))
                {
                    foreach (var elem in Dictionary.DictForCheck)
                    {
                        fileWrite.WriteLine(elem.Key.ToString() + ":" + elem.Value.ToString());
                    }
                    fileWrite.Close();
                }
            }
            if (MainForm.NumberOfQuiz == 3)
            {
                using (StreamWriter fileWrite = new StreamWriter(@"Saves\Game\" + name))
                {
                    foreach (var elem in Dictionary.DictForCheck)
                    {
                        fileWrite.WriteLine(elem.Key.ToString() + ":" + elem.Value.ToString());
                    }
                    fileWrite.Close();
                }
            }
            MessageBox.Show("Сохранение выполнено успешно.", "Сообщение");
        }

        private void NameOfSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                textBox1.Clear();
                Hide();
            }
        }

        private void NameOfSave_Load(object sender, EventArgs e)
        {

        }
    }
}