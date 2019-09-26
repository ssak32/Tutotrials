using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOListApplication.Common
{
    public class TaskClass:INotifyPropertyChanged
    {
        #region Fields
        private string _taskName;      
        private string _taskDate;
        private string _taskTime;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Properties
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value;
            OnPropertyChanged("TaskName");
            }
        }

        public string TaskDate
        {
            get { return _taskDate; }
            set
            {
                _taskDate = value;
            OnPropertyChanged("TaskDate");
            }
        }

        public string TaskTime
        {
            get { return _taskTime; }
            set
            {
                _taskTime = value;
                OnPropertyChanged("TaskTime");
            }
        }
        #endregion

        #region Public Implementation
        public void OnPropertyChanged(string param)
        {
            if (PropertyChanged != null)
                PropertyChanged(param, new PropertyChangedEventArgs(param));

        }
        #endregion
    }
}
