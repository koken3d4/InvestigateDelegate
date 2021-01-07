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
        delegate string retStr(int x);  //ここで引数を決めている。
        //delegate string retStr(int x, int y);  //引数が異なるけれど、同じ名前を用いる事ができない。

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
            retStr ret = methodStr;  //retにmethodStrのメソッドを代入する。
            listBox1.Items.Add(ret(10));
            //listBox1.Items.Add(ret(1, 2));　　//このように書いたとしてもデリゲートを用いる事ができない。
        }

        private void clean()
        {
            listBox1.Items.Clear();
        }

        private string methodStr(int x)
        {
            return x.ToString();
        }

        private string methodStr(int x,int y)
        {
            return (x + y).ToString();
        }
    }
}
