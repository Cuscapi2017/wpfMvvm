using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DMSkin.Core.MVVM;

namespace MVVM
{
    public class UC_TestVM : ViewModelBase
    {
        
        /// <summary>
        /// 编辑用户
        /// </summary>    
        public ICommand OpenDrawer => new DelegateCommand(obj =>
        {
            
        });
    }
}
