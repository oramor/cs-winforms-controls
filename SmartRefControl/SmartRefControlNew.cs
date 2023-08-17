using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace SmartRefControl
{
    public partial class SmartRefControlNew : Control
    {
        public SmartRefControlNew()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            /// У контрола фиксированная высота
            SetStyle(ControlStyles.FixedHeight, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            /// Полностью перерисовывам при ресайзе
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);

            InitializeComponent();

            //textBox.Text = "fdfdfdf";
            //textBox.ForeColor = Color.Azure;
        }

        // TODO заменить на CurrentValue?
        public override string Text
        {
            get {
                return textBox.Text;
            }
            set {
                textBox.Text = value;
                /// Выделяем или, наоборот, снимаем выделение?
                textBox.SelectionStart = textBox.Text.Length;
                textBox.SelectionLength = 0;
            }
        }

        private SmartRefControlNew _host;
        [Browsable(false)]
        public SmartRefControlNew Host
        {
            get => _host;
            set {
                _host = value;

                if (_host != this)
                {
                    //this.borderColor = host.borderColor;
                    //this.borderColorList = host.borderColorList;
                    //this.TextColor = host.TextColor;
                    //this.extTextColor = host.extTextColor;
                    //this.listTextColor = host.listTextColor;
                    //this.findTextBackColor = host.findTextBackColor;
                    //this.toolTipBorderColor = host.toolTipBorderColor;
                    //this.toolTipBackColor = host.toolTipBackColor;
                    //this.toolTipTextColor = host.toolTipTextColor;
                }
            }
        }

        private Color _borderColor = Color.Black;
        [Browsable(true),
        Category("Colors"),
        DisplayName("Control border"),
        DefaultValue(typeof(Color), "Black")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        //public bool IsDropDown { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);

            //if (!IsDropDown)
            //{
            //    _host = this;
            //}
            Color bord = _host.BorderColor;
            if (VisualStyleInformation.IsEnabledByUser)
                bord = VisualStyleInformation.TextControlBorder;

            e.Graphics.DrawRectangle(new Pen(bord), 0, 0, Width - 1, Height - 1);
        }

        void TextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("!!!");
            //if (!string.IsNullOrEmpty(textBox.Text))
            //    textBox.SelectAll();
            //else
            //{
            //    doFind = false;
            //    ShowDropDown(textBox.Text, true, false);
            //}
        }
    }
}
