using System.Data;

namespace ComboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            //comboBox1.DataSourceChanged += ComboBox_DataSourceChanged;

            Init();
        }

        void Init()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Rows.Add(new object[] { 1, "Product 1" });
            dt.Rows.Add(new object[] { 2, "Product 2" });

            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Title";

            comboBox1.DataSource = dt;

            /// Вначале присваиваем значение, которое существует в списке
            /// подстановки
            comboBox1.SelectedValue = 1;
            comboBox1.DataSource = GetSourceTwo();
            //comboBox1.SelectedValue = 10;
            if (comboBox1.SelectedValue != null)
            {
                label1.Text = comboBox1.SelectedValue.ToString();
            }

            label2.Text = comboBox1.SelectedIndex.ToString();
        }

        /// <summary>
        /// Срабатывает в том числе при изменении DataSource
        /// </summary>
        void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        void ComboBox_DataSourceChanged(object? sender, EventArgs e)
        {
            label3.Text = "54545454";
        }

        DataTable GetSourceTwo()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Rows.Add(new object[] { 1, "Product 4" });
            dt.Rows.Add(new object[] { 2, "Product 5" });
            return dt;
        }
    }
}