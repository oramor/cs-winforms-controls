using System.ComponentModel;

namespace TextBoxAsync
{
    public partial class CustomTextBox : TextBox
    {
        ViewModel? _ctx;

        public CustomTextBox()
        {
            InitializeComponent();
        }

        protected override void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);

            if (DataContext is ViewModel ctx)
            {
                _ctx = ctx;

                ctx.DataLoadStatusChanged += DataContext_DataLoadStatusChanged;

                if (ctx.IsDataLoaded)
                {
                    BindValue();
                }
                else
                {
                    SetLoading();
                }
            }
        }

        [Browsable(true), Category("Object properties"), DefaultValue("")]
        public string BindingName { get; set; } = "";

        void BindValue()
        {
            if (_ctx == null)
                return;

            void action()
            {
                //TextChanged -= StringControl_TextChanged;
                Text = _ctx[BindingName];
                //TextChanged += StringControl_TextChanged;
            }

            if (InvokeRequired)
            {
                Invoke(() => action());
            }
            else
            {
                action();
            }
        }

        void SetLoading()
        {
            void action()
            {
                Enabled = false;
            }

            if (InvokeRequired)
            {
                Invoke(() => action());
            }
            else
            {
                action();
            }
        }

        void SetLoaded()
        {
            void action()
            {
                Enabled = true;
            }

            if (InvokeRequired)
            {
                Invoke(() => action());
            }
            else
            {
                action();
            }
        }

        void DataContext_DataLoadStatusChanged(object? sender, DataLoadStatusChangedEventArgs e)
        {
            //MessageBox.Show("!!!");

            if (DataContext is ViewModel)
            {
                switch (e.Status)
                {
                    case DataLoadStatusEnum.OnLoading:
                        {
                            SetLoading();
                            break;
                        }
                    case DataLoadStatusEnum.Loaded:
                        {
                            BindValue();
                            SetLoaded();
                            break;
                        }
                }
            }
        }
    }
}
