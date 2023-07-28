namespace TextBoxAsync
{
    internal class ViewModel
    {
        internal ViewModel()
        {
            DataLoadStatus = DataLoadStatusEnum.NotLoaded;
            Task.Run(() => DataLoadAsync());
        }

        async Task DataLoadAsync()
        {
            OnDataLoadStatusChanged(DataLoadStatusEnum.OnLoading);
            await Task.Delay(5000);
            String1 = "Hello!";
            OnDataLoadStatusChanged(DataLoadStatusEnum.Loaded);
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
    }
}
