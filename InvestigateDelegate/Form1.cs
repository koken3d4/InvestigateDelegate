using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestigateDelegate
{
    public partial class Form1 : Form
    {
        //デリゲートトライ用1
        delegate string retStr(int x);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
            retStr ret = methodStr;  //retにmethodStrのメソッドを代入する。
            listBox1.Items.Add(ret(10));
        }

        private void clean()
        {
            listBox1.Items.Clear();
        }

        private string methodStr(int x)
        {
            return x.ToString();
        }
    }
}
