using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			

			System.Threading.Mutex mutex = new System.Threading.Mutex(false, "This Should Only Run Once");
			bool Running = !mutex.WaitOne(0, false);
			if (!Running)
			{
				Login login = new Login();
				if (DialogResult.Cancel == login.ShowDialog())
				{
					return;
				}
				if (GlobalClass.user.isSuperAccount)
				{
					SuperManagerForm superManagerForm = new SuperManagerForm();
					superManagerForm.ShowDialog();
				}
				else
				{
					StaffFrom staffFrom = new StaffFrom();
					staffFrom.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show("程序已启动！");
			}
		}
	}
}
