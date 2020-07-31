using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualization
{
	class Random
	{
		static string[] array = {"a", "b", "c", "d", "e", "f",
							  "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s",
							  "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5",
							  "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I",
							  "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V",
							  "W", "X", "Y", "Z" };
		public static string GetRandomID()
		{
			
			string id = Guid.NewGuid().ToString().Replace("-","");
			MessageBox.Show(id.Length.ToString());
			string buffer = null;
			int start;
			int val;
			for (int i = 0; i < 8; i++)
			{
				start = i * 4;
				//MessageBox.Show(id.Substring(start, 4));
				val = Convert.ToInt32("0x"+id.Substring(start, 4), 16);
				buffer += array[val % 62];
			}
			return buffer;
		}
	}
}
