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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        //添加信息按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add();
            add.ShowDialog();
            
        }

        //删除信息按钮
        private void btnDel_Click(object sender, EventArgs e)
        {
            Del del=new Del();
            del.Show();
        }

        //修改信息按钮
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        //查询信息按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
