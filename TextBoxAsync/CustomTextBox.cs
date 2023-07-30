using System.ComponentModel;

namespace TextBoxAsync
{
    public partial class CustomTextBox : TextBox
    {
        ViewModelAsync? _ctx;

        public CustomTextBox()
        {
            InitializeComponent();
        }

        protected override async void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);

            if (DataContext is ViewModelAsync ctx)
            {
                SetLoading();
                await ctx.DataLoading;
                _ctx = ctx;
                BindValue();
                SetLoaded();
                ctx.DataLoadStarted += DataContext_DataLoadStarted;
            }
        }

        [Browsable(true), Category("Object properties"), DefaultValue("")]
        public string BindingName { get; set; } = "";

        void BindValue()
        {
            if (_ctx == null)
                return;

            Text = _ctx[BindingName];
        }

        void SetLoading()
        {
            Enabled = false;
        }

        void SetLoaded()
        {
            Enabled = true;
        }

        async void DataContext_DataLoadStarted(object? sender, EventArgs e)
        {
            if (DataContext is ViewModelAsync ctx)
            {
                SetLoading();

                await ctx.DataLoading;

                switch (ctx.DataLoadStatus)
                {
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
