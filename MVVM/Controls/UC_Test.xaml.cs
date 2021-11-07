using System;
using System.Collections.Generic;
using System.Data;
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

namespace MVVM
{
    /// <summary>
    /// UC_Test.xaml 的交互逻辑
    /// </summary>
    public partial class UC_Test : UserControl
    {
        public event EventHandler<MessageArgs> PartEvent;
        public UC_Test()
        {
            InitializeComponent();
            this.DataContext = new UC_TestVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PartEvent.Invoke(null,new MessageArgs(new UC_OkNo(Ok)));
        }

        private void Ok(DataRowView row)
        {
            var a = 0;
        }

        private void No()
        {
            var a = 0;
        }
    }

    public class MessageArgs : EventArgs
    {
        
        public UserControl _uc { get; set; }
        public MessageArgs(UserControl uc)
        {
            this._uc = uc;
        }

    }
}
