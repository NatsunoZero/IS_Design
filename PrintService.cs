using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Visualization
{
    class PrintService
	{
        ListView listView1;
        public PrintService()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
            docToPrint.PrintPage += new PrintPageEventHandler(docToPrint_PrintPage);
        }//将事件处理函数添加到PrintDocument的PrintPage中
        public PrintService(ListView listView):this()
        {
            listView1 = listView;
        }

        // Declare the PrintDocument object.
        private PrintDocument docToPrint = new PrintDocument();//创建一个PrintDocument的实例

        private string streamType;
        private string streamtxt;
        private Image streamima;

        // This method will set properties on the PrintDialog object and
        // then display the dialog.
        public void StartPrint(string txt, string streamType)
        {
            this.streamType = streamType;
            streamtxt = txt;
            // Allow the user to choose the page range he or she would
            // like to print.
            PrintDialog PrintDialog1 = new PrintDialog();//创建一个PrintDialog的实例。
            PrintDialog1.AllowSomePages = true;

            // Show the help button.
            PrintDialog1.ShowHelp = true;

            PrintDialog1.Document = docToPrint;//把PrintDialog的Document属性设为上面配置好的PrintDocument的实例

            DialogResult result = PrintDialog1.ShowDialog();//调用PrintDialog的ShowDialog函数显示打印对话框,如果不要注释即可，直接调用docToPrint.Print()
            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();//开始打印
            }
            //docToPrint.Print();//开始打印
        }
        public void StartPrint(Image ima, string streamType)
        {
            this.streamType = streamType;
            streamima = ima;
            // Allow the user to choose the page range he or she would
            // like to print.
            PrintDialog PrintDialog1 = new PrintDialog();//创建一个PrintDialog的实例。
            PrintDialog1.AllowSomePages = true;

            // Show the help button.
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = docToPrint;//把PrintDialog的Document属性设为上面配置好的PrintDocument的实例

            DialogResult result = PrintDialog1.ShowDialog();//调用PrintDialog的ShowDialog函数显示打印对话框,如果不要注释即可，直接调用docToPrint.Print()
            // If the result is OK then print the document.
            if (result == DialogResult.OK)
            {
                docToPrint.Print();//开始打印
            }

            //docToPrint.Print();//开始打印
        }
        // The PrintDialog will print the document
        // by handling the document's PrintPage event.
        private void docToPrint_PrintPage(object sender,
         PrintPageEventArgs e)//设置打印机开始打印的事件处理函数
        {

            // Insert code to render the page here.
            // This code will be called when the control is drawn.

            // The following code will render a simple
            // message on the printed document
            switch (streamType)
            {
                case "txt":
                    string text = null;
                    Font printFont = new System.Drawing.Font
                     ("Arial", 7, FontStyle.Regular);//在这里设置打印字体以及大小

                    // Draw the content.

                    text = streamtxt;
                    //e.Graphics.DrawString(text, printFont, System.Drawing.Brushes.Black, e.MarginBounds.X, e.MarginBounds.Y);
                    e.Graphics.DrawString(text, printFont, Brushes.Black, 0, 10);//设置打印初始位置
                    break;
                case "image":
                    System.Drawing.Image image = streamima;
                    int x = e.MarginBounds.X;
                    int y = e.MarginBounds.Y;
                    int width = image.Width;
                    int height = image.Height;
                    if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
                    {
                        width = e.MarginBounds.Width;
                        height = image.Height * e.MarginBounds.Width / image.Width;
                    }
                    else
                    {
                        height = e.MarginBounds.Height;
                        width = image.Width * e.MarginBounds.Height / image.Height;
                    }
                    Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
                    e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
                    break;
                default:
                    break;
            }
        }
        public void  Print()
        {
            PrintService ps = new PrintService();
            //ps.StartPrint("33333","txt");//打印文字
            ps.StartPrint(WriteTxt(), "txt");
            //ps.StartPrint(Image.FromFile(Application.StartupPath + "\\2.jpeg"), "image");//打印图片
        }


        public string WriteTxt()
        {
            StringBuilder sb = new StringBuilder();
            string tou = "XXX书店";
            string address = "天津市西青区宾水西道391号天津理工大学";
            string saleID = "2010930233330";
            decimal total = 0.00M;
            decimal fukuan = 500.00M;
            sb.Append("            " + tou + "     \r\n");
            sb.Append("----------------------------------------------------------------------------------------------------------------------------------\r\n");
            sb.Append("日期:" + DateTime.Now.ToShortDateString() + "  " + "单号:" + saleID + "\r\n");
            sb.Append("----------------------------------------------------------------------------------------------------------------------------------\r\n");
            sb.Append("书籍" + "\t\t" + "数量" + "\t" + "单价" + "\t" + "小计" + "\r\n");
            int lineCount = listView1.Items.Count;
            for (int i = 0; i < lineCount; i++)
            {
                sb.Append(listView1.Items[i].SubItems[3].Text + "\t\t" 
                    + listView1.Items[i].SubItems[4].Text + "\t" 
                    + listView1.Items[i].SubItems[5].Text + "\t" 
                    + listView1.Items[i].SubItems[6].Text);
                total += decimal.Parse(listView1.Items[i].SubItems[6].Text);
                if (i != (lineCount))
                    sb.Append("\r\n");
            }
            sb.Append("----------------------------------------------------------------------------------------------------------------------------------\r\n");
            sb.Append("数量: " + lineCount + " 合计:   " + total + "\r\n");
            sb.Append("付款: 现金" + "    " + fukuan);
            sb.Append("         现金找零:" + "   " + (fukuan - total) + "\r\n");
            sb.Append("----------------------------------------------------------------------------------------------------------------------------------\r\n");
            sb.Append("地址：" + address + "\r\n");
            sb.Append("电话：123456789   123456789\r\n");
            sb.Append("                 谢谢惠顾欢迎下次光临                    ");
            return sb.ToString();
        }

    }
}
