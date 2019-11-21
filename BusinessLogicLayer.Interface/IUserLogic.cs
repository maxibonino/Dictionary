﻿namespace BusinessLogicLayer
{
    public interface IUserLogic
    {
        string CutOffFileName(string word);
        bool IsConfirmLogin(string enteredLogin, string enteredPassword);
        void SaveGameResult(int scoreRight, int scoreWrong);
    }
}