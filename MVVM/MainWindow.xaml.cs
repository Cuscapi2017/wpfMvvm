using MahApps.Metro.Controls;
using MVVM.Common;
using MVVM.View;
using System.Windows;

namespace MVVM
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowVM();
        }
    }
}
