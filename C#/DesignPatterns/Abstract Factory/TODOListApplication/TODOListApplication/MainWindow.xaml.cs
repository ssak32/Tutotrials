using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TODOListApplication.ViewModels;

namespace TODOListApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        private MainWindowViewModel _mainWindowViewModel;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowViewModel = new MainWindowViewModel();
            this.DataContext = _mainWindowViewModel;
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindowViewModel.UpdateTask();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindowViewModel.AddTask();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _mainWindowViewModel.DeleteTask();
        }
    }
}
