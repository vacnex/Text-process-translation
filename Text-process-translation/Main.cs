using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Text_process_translation
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path);
                int countTrans = 0,countUnTrans = 0, num = 0;
                
                if (new FileInfo(path).Length != 0)
                {
                    String line;                    
                    do
                    {
                        line = sr.ReadLine();
                        if (line.StartsWith("msgstr"))
                        {
                            if (line.Length > 9)                            
                                countTrans += 1;                            
                            else                            
                                countUnTrans += 1;                                                  
                        }
                    } while (!sr.EndOfStream);
                    lbNum.Text = (countUnTrans + countTrans).ToString();
                    lbUnTrans.Text = countUnTrans.ToString();
                    lbTrans.Text = countTrans.ToString();
                    pbDone.Value = countTrans * 100 / Convert.ToInt32(lbNum.Text);
                }
            }
        }
    }
}
