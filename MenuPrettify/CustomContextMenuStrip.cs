using System.ComponentModel;

namespace MenuPrettify
{
    public partial class CustomContextMenuStrip : ContextMenuStrip
    {
        public CustomContextMenuStrip()
        {
            InitializeComponent();
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            base.OnOpening(e);

            //foreach (var item in Items)
            //{
            //    if (item is ToolStripMenuItemAsyncControl ac)
            //    {
            //        ac.Command.OnCanExecuteChanged();
            //        if (ac.Name == "RemoveItem")
            //        {
            //            // MessageBox.Show(ac.Visible.ToString() + "1");
            //        }
            //    }

            //    if (item is ToolStripMenuItem t)
            //    {
            //        //if (t.Name == "TestItem")
            //        //{
            //        //    MessageBox.Show(t.Visible.ToString() + "1");
            //        //}
            //    }
            //}

            _ = Items.CorrectSeparators();
        }
    }
}
