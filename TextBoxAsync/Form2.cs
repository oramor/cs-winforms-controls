﻿namespace TextBoxAsync
{
    internal partial class Form2 : Form
    {
        internal Form2()
        {
            InitializeComponent();
        }

        internal Form2(ViewModelAsync ctx)
            : this()
        {
            reloadButton.Command = ctx.ReloadCommand;
            DataContext = ctx;
        }
    }
}
