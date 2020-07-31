using System;
using System.Windows.Forms;

namespace Visualization
{
	public partial class StaffFrom : Form
	{
		public StaffFrom()
		{
			InitializeComponent();
            toolStripStatusLabel1.Text = "员工：" + GlobalClass.user.strUsrName;
            
		}

		private void 退出ToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

		private void 结账BToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CloseAllChildrenWinForm();
			
			
			if (!CheckFormIsOpen("CheckCenter"))
			{
				CheckCenter checkCenter = new CheckCenter
				{
					TopLevel = false,
					Parent = panel1,
				};
				panel1.Controls.Add(checkCenter);
				checkCenter.Location = new System.Drawing.Point(0, 0);
				checkCenter.Show();
				if (!CheckFormIsOpen("KeyBoard"))
				{
					KeyBoard keyBoard = new KeyBoard(checkCenter);
					keyBoard.Show();
				}
				else
				{
					Application.OpenForms["KeyBoard"].Show();
				}
			}
			else
			{
				Application.OpenForms["CheckCenter"].Show();
			}

			Top = 155;
			Left = 559;
		}
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
		private void 计算价格PToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CloseAllChildrenWinForm();
			if (!CheckFormIsOpen("StoricRequire")){

				StoricRequire storicRequire = new StoricRequire
				{
					TopLevel = false,
					Parent = panel1,
				};
				panel1.Controls.Add(storicRequire);
				storicRequire.Location = new System.Drawing.Point(0, 0);
				storicRequire.Show();
			}
			else
			{
				Application.OpenForms["StoricRequire"].Show();
			}
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
			if (!CheckFormIsOpen("RecordingRequire")){

				RecordingRequire recordingRequire = new RecordingRequire
				{
					TopLevel = false,
					Parent = panel1,
				};
				panel1.Controls.Add(recordingRequire);
				recordingRequire.Location = new System.Drawing.Point(0, 0);
				recordingRequire.Show();
			}
			else
			{
				Application.OpenForms["RecordingRequire"].Show();
			}
		}

		private void 锁定LToolStripMenuItem_Click(object sender, EventArgs e)=> Application.Restart();

		private void StaffFrom_Load(object sender, EventArgs e)
		{
			skinEngine1.SkinFile = Application.StartupPath + @"\PageColor1.ssk";
		}
	}
}
