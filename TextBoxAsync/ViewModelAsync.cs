using System.Windows.Input;

namespace TextBoxAsync
{
    internal class ViewModelAsync
    {
        Dictionary<string, string> _dic = new();

        internal ViewModelAsync()
        {
            _dic.Add("Prop1", "Value1");
            _dic.Add("Prop2", "Value2");
            _dic.Add("Prop3", "Value3");
            _dic.Add("Prop4", "Value4");

            DataLoadStatus = DataLoadStatusEnum.NotLoaded;
            ReloadCommand = new ViewModelAsyncReloadCommand(this);
            DataLoading = DataLoadAsync();
        }

        public Task DataLoading { get; private set; }

        async Task DataLoadAsync()
        {
            try
            {
                await Task.Delay(1000);
                DataLoadStatus = DataLoadStatusEnum.Loaded;
            }
            catch
            {
                throw;
            }
        }

        public DataLoadStatusEnum DataLoadStatus { get; private set; }
        public bool IsDataLoaded => DataLoadStatus == DataLoadStatusEnum.NotLoaded;

        public string String1 { get; set; } = "";

        public event EventHandler? DataLoadStarted;
        void OnDataLoadStarted()
        {
            DataLoadStatus = DataLoadStatusEnum.OnLoading;
            DataLoadStarted?.Invoke(this, EventArgs.Empty);
        }

        public string this[string name]
        {
            get {
                return _dic[name];
            }
            set {
                _dic[name] = value;
            }

        }

        public ICommand ReloadCommand { get; init; }
        private sealed class ViewModelAsyncReloadCommand : ICommand
        {
            readonly ViewModelAsync _ctx;

            public ViewModelAsyncReloadCommand(ViewModelAsync ctx)
            {
                _ctx = ctx;
            }

            public event EventHandler? CanExecuteChanged;

            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public void Execute(object? parameter)
            {
                _ctx.DataLoading = _ctx.DataLoadAsync();
                _ctx.OnDataLoadStarted();
            }
        }
    }
}
