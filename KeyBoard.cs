using System;
using System.Windows.Forms;

namespace Visualization
{
	public partial class KeyBoard : Form
	{
		private CheckCenter checkCenter;
		public KeyBoard()
		{
			InitializeComponent();
		}
		public KeyBoard(CheckCenter checkCenter) : this()
		{
			this.checkCenter = checkCenter;
		}

		private void isMemberButton_Click(object sender, EventArgs e)
		{
			checkCenter.InputMemberTextBox.Visible = true;
			checkCenter.InputMemberTextBox.Focus();
		}
		private void NumberInput(object sender, EventArgs e)
		{
			Control c = sender as Control;
			for (int i = 0; i < 10; i++)
			{
				if (c.Name == ("button" + i.ToString()))
				{
					checkCenter.Focus(); // 保证输入焦点落在主窗口上
					checkCenter.SendInputReceipter(i.ToString());
					return;
				}
			}
		}
		private void ArrowClick(object sender, EventArgs e)
		{
			checkCenter.Focus(); // 保证输入焦点落在主窗口上
			Control c = sender as Control;
			checkCenter.ArrowControl(("UpArrowButton" == c.Name) ? true : false);
		}
		private void DeleteClick(object sender, EventArgs e)
		{
			checkCenter.Focus(); // 保证输入焦点落在主窗口上
			checkCenter.DeleteControl();
		}
		private void EnterClick(object sender, EventArgs e)
		{
			checkCenter.Focus(); // 保证输入焦点落在主窗口上
			checkCenter.EnterControl();
		}

		private void GetPrice(object sender, EventArgs e)
		{
			checkCenter.Focus(); // 保证输入焦点落在主窗口上
			checkCenter.QueryPrice();
		}

		private void SettleButton_Click(object sender, EventArgs e)
		{
			checkCenter.GetPrice();
			
		}

		private void KeyBoard_Load(object sender, EventArgs e)
		{
			Left = 0;
			Top = 155;
		}

		private void scanButton_Click(object sender, EventArgs e)
		{
			checkCenter.ISBN.Focus();
		}
	}
}
