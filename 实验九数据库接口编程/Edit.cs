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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empno1 = Convert.ToInt32(tbEditEmpno1.Text.Trim());
            MessageBox.Show("要修改的编号为：" + empno1);
        }

        //修改按钮
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //int empno2 =Convert.ToInt32( tbEditEmpno2.Text.Trim());
            String ename = tbEname.Text.Trim();
            String job = tbJob.Text.Trim();
            int mgr =Convert.ToInt32( tbMgr.Text.Trim());
            DateTime hiredate = Convert.ToDateTime(datetp.Text);
            int sal = Convert.ToInt32(tbSal.Text.Trim());
            int comm = Convert.ToInt32(tbComm.Text.Trim());
            int deptno = Convert.ToInt32(tbDeptno.Text.Trim());
            MessageBox.Show(
                //"员工编号"+empno2+ 
                ",员工姓名"
                + ename + ",职位" + job + ",年龄" + mgr
                + ",入职日期" + hiredate.ToShortDateString() + ",工资" + sal
                + ",工资级别" + comm + ",部门编号" + deptno);
        }

        //返回按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
