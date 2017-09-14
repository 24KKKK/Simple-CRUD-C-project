using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实验九数据库接口编程
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empno = Convert.ToInt32(tbSearchEmpno.Text.Trim());
            MessageBox.Show("要查询的编号为：" + empno);
        }

        //返回按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
