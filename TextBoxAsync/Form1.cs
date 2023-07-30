namespace TextBoxAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctx = new ViewModelAsync();
            var form = new Form2(ctx);
            form.Show();
        }
    }
}