namespace TextBoxAsync
{
    internal partial class Form2 : Form
    {
        internal Form2()
        {
            InitializeComponent();
        }

        internal Form2(ViewModel ctx)
            : this()
        {
            DataContext = ctx;
        }
    }
}
