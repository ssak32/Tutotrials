using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TODOListApplication.Common;
using TODOListApplication.Models;

namespace TODOListApplication.ViewModels
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        #region Fields
        private MainWindowModel _model;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Properties
        public ObservableCollection<TaskClass> TaskList
        {
            get { return _model.TaskList; }
            set { _model.TaskList = value; }
        }

        /// <summary>
        /// Get/Set TaskClass
        /// </summary>
        public TaskClass TaskClassObj
        {
            get 
            { 
                return _model.TaskClass; 
            }
            set 
            { 
                _model.TaskClass = value;
                OnPropertyChanged("TaskClassObj");
            }
        }

        public static readonly ICommand AddCommand;
        #endregion

        #region Class constructor
        public MainWindowViewModel()
        {
            _model = new MainWindowModel();
            //AddCommand = new RelayCommand
        }
        #endregion

        #region Private Implementation
        #endregion

        #region Public Implementation
        public void AddTask()
        {
            TaskClass newClass = new TaskClass();
            newClass.TaskName = "NewTask";
            newClass.TaskDate = DateTime.Now.ToShortDateString();
            newClass.TaskTime = DateTime.Now.ToShortTimeString();
            TaskList.Add(newClass);
        }

        public void UpdateTask()
        {
            for (var i = 0; i < TaskList.Count;i++ )
            {
                if (TaskList[i].Equals(TaskClassObj))
                {
                    TaskList[i] = TaskClassObj;
                    _model.UpdateReminder(i, TaskClassObj.TaskDate, TaskClassObj.TaskTime);
                }
            }
        }

        public void DeleteTask()
        {
            if (TaskList != null)
            {
                if (TaskList.Count > 1)
                {
                    TaskList.Remove(TaskClassObj);
                }
            }
        }

        public void OnPropertyChanged(string param)
        {
            if (PropertyChanged != null)
                PropertyChanged(param, new PropertyChangedEventArgs(param));

        }
        #endregion
    }
}
