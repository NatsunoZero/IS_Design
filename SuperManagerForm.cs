using System;
using System.Windows.Forms;

namespace Visualization
{
	public partial class SuperManagerForm : Form
	{
		public SuperManagerForm()
		{
			InitializeComponent();
            toolStripStatusLabel1.Text = "超级管理员：" + GlobalClass.user.strUsrName;
            
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        /// <summary>
        /// 防止打开多个窗体
        /// </summary>
        /// <param name="p_ChildrenFormText">窗体名称</param>
        /// <returns></returns>
        private bool ShowChildrenForm(string p_ChildrenFormText)
        {
            int i;
            //依次检测当前窗体的子窗体
            for (i = 0; i < this.MdiChildren.Length; i++)
            {
                //MessageBox.Show("{0},{1}", MdiChildren[i].Name+p_ChildrenFormText);
                //判断当前子窗体的Text属性值是否与传入的字符串值相同
                if (MdiChildren[i].Name == p_ChildrenFormText)
                {
                    //如果值相同则表示此子窗体为想要调用的子窗体，激活此子窗体并返回true值
                    MdiChildren[i].Activate();
                    return true;
                }
            }
            //如果没有相同的值则表示要调用的子窗体还没有被打开，返回false值
            return false;
        }

        private void 锁定LToolStripMenuItem_Click(object sender, EventArgs e)=> Application.Restart();

        private void CloseAllChildrenWinForm()
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Close();
            }
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                //MessageBox.Show(Application.OpenForms[i].Text);
                if (Text != Application.OpenForms[i].Text) Application.OpenForms[i].Close();
            }
            panel1.Controls.Clear();
        }
        /// <summary>
		/// 检查窗口是否已经打开
		/// </summary>
		/// <param name="asFormName">窗口名称</param>
		/// <returns></returns>
		private bool CheckFormIsOpen(string asFormName)
        {
            bool bResult = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == asFormName)
                {
                    bResult = true;
                    break;
                }
            }
            return bResult;
        }
        private void 当前时间TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildrenWinForm();
            if (!CheckFormIsOpen("BookStockManage"))
            {
                BookStockManage bookStockManage = new BookStockManage
                {
                    TopLevel = false,
                    Parent = panel1,
                };
                panel1.Controls.Add(bookStockManage);
                bookStockManage.Location = new System.Drawing.Point(0, 0);
                bookStockManage.Show();
            }
            else
            {
                Application.OpenForms["BookStockManage"].Show();
            }
        }

        private void 计算价格PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildrenWinForm();
            if (!CheckFormIsOpen("BookInfoManage"))
            {
                BookInfoManage bookInfoManage = new BookInfoManage
                {
                    TopLevel = false,
                    Parent = panel1,
                };
                panel1.Controls.Add(bookInfoManage);
                bookInfoManage.Location = new System.Drawing.Point(0, 0);
                bookInfoManage.Show();
            }
            else
            {
                Application.OpenForms["BookInfoManage"].Show();
            }
        }

        private void 政治面貌GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildrenWinForm();
            if (!CheckFormIsOpen("StaffAccountManage"))
            {
                StaffAccountManage staffAccountManage = new StaffAccountManage
                {
                    TopLevel = false,
                    Parent = panel1,
                };
                panel1.Controls.Add(staffAccountManage);
                staffAccountManage.Location = new System.Drawing.Point(0, 0);
                staffAccountManage.Show();
            }
            else
            {
                Application.OpenForms["StaffAccountManage"].Show();
            }
        }

        private void SuperManagerForm_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"\GlassOrange.ssk";
        }
    }
}
