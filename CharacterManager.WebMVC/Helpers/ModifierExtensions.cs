using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public static class ModifierExtensions
{
    public static string Modifier(this Int32 attribute)
    {
        int modifier = 0;

        switch (attribute)
        {
            case 1:
                modifier = -5;
                break;
            case int a when (a == 2 || a == 3):
                modifier = -4;
                break;
            case int a when (a == 4 || a == 5):
                modifier = -3;
                break;
            case int a when (a == 6 || a == 7):
                modifier = -2;
                break;
            case int a when (a == 8 || a == 9):
                modifier = -1;
                break;
            case int a when (a == 10 || a == 11):
                modifier = 0;
                break;
            case int a when (a == 12 || a == 13):
                modifier = 1;
                break;
            case int a when (a == 14 || a == 15):
                modifier = 2;
                break;
            case int a when (a == 16 || a == 17):
                modifier = 3;
                break;
            case int a when (a == 18 || a == 19):
                modifier = 4;
                break;
            case int a when (a == 20 || a == 21):
                modifier = 5;
                break;
            case int a when (a == 22 || a == 23):
                modifier = 6;
                break;
            case int a when (a == 24 || a == 25):
                modifier = 7;
                break;
            case int a when (a == 26 || a == 27):
                modifier = 8;
                break;
            case int a when (a == 28 || a == 29):
                modifier = 9;
                break;
            case 30:
                modifier = 10;
                break;
        }

        return modifier.ToString();
    }
}