namespace TextBoxAsync
{
    internal class ViewModel
    {
        Dictionary<string, string> _dic = new();

        internal ViewModel()
        {
            DataLoadStatus = DataLoadStatusEnum.NotLoaded;
            _dic.Add("Prop1", "Value1");
            _dic.Add("Prop2", "Value2");
            _dic.Add("Prop3", "Value3");
            _dic.Add("Prop4", "Value4");
            Task.Run(() => DataLoadAsync());
        }

        async Task DataLoadAsync()
        {
            try
            {
                OnDataLoadStatusChanged(DataLoadStatusEnum.OnLoading);
                await Task.Delay(0);
                String1 = "Hello!";
                OnDataLoadStatusChanged(DataLoadStatusEnum.Loaded);
            }
            catch
            {
                throw;
            }

        }

        public DataLoadStatusEnum DataLoadStatus { get; private set; }
        public bool IsDataLoaded => DataLoadStatus == DataLoadStatusEnum.Loaded;

        public string String1 { get; set; } = "";

        public event EventHandler<DataLoadStatusChangedEventArgs>? DataLoadStatusChanged;
        void OnDataLoadStatusChanged(DataLoadStatusEnum status)
        {
            DataLoadStatus = status;
            DataLoadStatusChanged?.Invoke(this, new DataLoadStatusChangedEventArgs(status));
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
    }
}
