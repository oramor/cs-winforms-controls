using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBoxAsync
{
    internal class DataLoadStatusChangedEventArgs : EventArgs
    {
        public DataLoadStatusChangedEventArgs(DataLoadStatusEnum status)
        {
            Status = status;
        }

        public DataLoadStatusEnum Status { get; init; }
    }
}
