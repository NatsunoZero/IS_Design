using System;
using System.Windows.Forms;

namespace Visualization
{
	public partial class CustomerScreen : Form
	{
		private ListView listView;
		public CustomerScreen()
		{
			InitializeComponent();
		}
		public CustomerScreen(ListView listView) : this()
		{
			this.listView = listView;
		}
		public void Reflash(double totalPrice)
		{
			string str;
			int index = listView.Items.Count-1;
			if (index >= 0)
			{
				str = listView.Items[index].SubItems[3].Text.Substring(0,15) + "\t单价：" + listView.Items[index].SubItems[5].Text
					+ "\r\n\r\n合计：" + totalPrice.ToString();
				textBox1.Text = str;
			}

		}
		public void Reflash(string text)
		{
			textBox1.Text = text;
		}

		private void CustomerScreen_Load(object sender, EventArgs e)
		{
			this.Left = 0;
			this.Top = 0;
		}
	}
}
