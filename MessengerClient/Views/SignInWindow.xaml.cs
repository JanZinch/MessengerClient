﻿using System;
using System.Security;
using System.Windows;

namespace MessengerClient
{
    public partial class SignInWindow : Window
    {
        public event Action OnHidden;
        
        public SignInWindow()
        {
            InitializeComponent();
        }
        
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            OnHidden?.Invoke();
        }
    }
}