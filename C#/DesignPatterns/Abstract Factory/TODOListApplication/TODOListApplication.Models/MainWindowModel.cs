using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TODOListApplication.Common;

namespace TODOListApplication.Models
{
    public class MainWindowModel
    {
        #region Fields
        private TaskClass _taskClass;
        private ObservableCollection<TaskClass> _taskList = new ObservableCollection<TaskClass>();
        private List<Timer> _reminderList = new List<Timer>();
        #endregion

        #region Properties
        /// <summary>
        /// Get/Set TaskClass
        /// </summary>
        public TaskClass TaskClass
        {
            get { return _taskClass; }
            set { _taskClass = value; }
        }

        public ObservableCollection<TaskClass> TaskList
        {
            get 
            {                    
                return _taskList; 
            }
            set { _taskList = value; }
        }

        #endregion

        #region Class constructor
        public MainWindowModel()
        {
            _taskList = new ObservableCollection<TaskClass>();
            _taskClass = new TaskClass();
            _taskClass.TaskName = "Task1";
            _taskClass.TaskDate = DateTime.Now.ToShortDateString();
            _taskClass.TaskTime = DateTime.Now.ToShortTimeString();
            _taskList.Add(_taskClass);
        }
        #endregion

        #region Public Implementation
        public void UpdateReminder(int timerPos, string date, string time)
        {
            int hour = int.Parse(time.Substring(0, 2));
            int min = int.Parse(time.Substring(2, 2));
            DateTime dateTime= DateTime.Parse(date);
            TimeSpan timerInterval = new TimeSpan(dateTime.Day, dateTime.Month, dateTime.Year, hour, min);
            if(_reminderList.Count>0 && _reminderList.Count >=timerPos)
            {
                _reminderList[timerPos].Interval = timerInterval.TotalMilliseconds;
            }
            else
            {
                _reminderList.Add(new Timer(timerInterval.TotalMilliseconds));
            }


        }
        #endregion

    }
}
