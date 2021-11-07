using DMSkin.Core.MVVM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM
{
    public class UC_OkNoVM : ViewModelBase
    {
        public UC_OkNoVM(Action<DataRowView> Ok)
        {
            FunOk = Ok;
        }
        public Action<DataRowView> FunOk = null;
        public Action FunNo = null;
        public ICommand Ok => new DelegateCommand(obj =>
        {
            FunOk(null);
        });
        public ICommand No => new DelegateCommand(obj =>
        {

        });
    }
}
