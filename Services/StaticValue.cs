﻿using Expenses_tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses_tracker.Services
{
    public class StaticValue
    {
        public static string UserId;
        public static decimal TotalBalance;
        public static string CurrencyType;
        public static string CurrencySymbol;
        public static string Username;
        public static string filePath = "C:\\Users\\CHME\\Desktop\\Expenses tracker\\Database\\users.json";
    }
}
