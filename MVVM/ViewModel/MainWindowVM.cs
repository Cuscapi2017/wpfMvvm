using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMSkin.Core.MVVM;

namespace MVVM
{
    public class MainWindowVM : ViewModelBase
    {
        #region 初始化
        public MainWindowVM()
        {
            int a = 1;
            string s = "";
            DataTable dt = new DataTable("TB_USER");
            DataColumn colUserId = new DataColumn("Id", a.GetType());
            dt.Columns.Add(colUserId);
            DataColumn colUserName = new DataColumn("Name", s.GetType());
            dt.Columns.Add(colUserName);
            DataColumn Enabled = new DataColumn("Enabled", a.GetType());
            dt.Columns.Add(Enabled);
            DataRow r = dt.NewRow();
            r["Id"] = 1;
            r["Name"] = "a";
            r["Enabled"] = 0;
            dt.Rows.Add(r);
            DataRow r1 = dt.NewRow();
            r1["Id"] = 2;
            r1["Name"] = "b";
            r1["Enabled"] = 1;
            dt.Rows.Add(r1);
            DataRow r2 = dt.NewRow();
            r2["Id"] = 3;
            r2["Name"] = "c";
            r2["Enabled"] = 0;
            dt.Rows.Add(r2);
            this.Dv = dt.DefaultView;
            dt.DefaultView[0]["Id"] = 4;
            var bb = 22;

        }
        #endregion

        #region 属性

        private DataView _dv;
        /// <summary>
        /// 编辑用户
        /// </summary>
        public DataView Dv
        {
            get { return _dv; }
            set
            {
                _dv = value;
                OnPropertyChanged(nameof(Dv));
            }
        }

        #endregion
    }
}
