﻿using Invox.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Invox.Views
{
    /// <summary>
    /// Interaction logic for Login_page.xaml
    /// </summary>
    public partial class Login_page : Window
    {
        GlobalValues global = new GlobalValues();
        public Login_page()
        {
            InitializeComponent();
            global.logWritter.writeLog("LoginPage", "Login page initialized.");
        }
    }
}
