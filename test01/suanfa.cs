#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;

#endregion

namespace test01
{
    public partial class suanfa : Form
    {
        public suanfa()
        {
            InitializeComponent();
        }

        private void btnnum_Click(object sender, EventArgs e)
        {
            if (!yanzheng()) return;
            switch (txtsuanfa.Text.Trim())
            {
                case "+": { label3.Text = (Convert.ToInt32(txt1.Text.Trim()) + Convert.ToInt32(txt2.Text.Trim())).ToString(); break; }
                case "-": { label3.Text = (Convert.ToInt32(txt1.Text.Trim()) - Convert.ToInt32(txt2.Text.Trim())).ToString(); break; }
                case "*": { label3.Text = (Convert.ToInt32(txt1.Text.Trim()) * Convert.ToInt32(txt2.Text.Trim())).ToString(); break; }
                case "/": { label3.Text = (Convert.ToInt32(txt1.Text.Trim()) / Convert.ToInt32(txt2.Text.Trim())).ToString(); break; }
                   
            }
        }

        //string suanfa = Convert.ToString(txtsuanfa.Text.Trim());
        //if (txt1.Text.Trim() == null)
        //{
        //    MessageBox.Show("��һ����û����");
        //    return;
        //}
        //if (txt2.Text.Trim() == null)
        //{
        //    MessageBox.Show("�ڶ�����������!");
        //    return;
        //}
        //if (txt2.Text.Trim() == null)
        //{
        //    MessageBox.Show("Ϊʲô�������������");
        //    return;
        //}

        //if (suanfa == "+")
        //{
        //    label3.Text = Convert.ToString(Convert.ToInt32(txt1.Text.Trim()) + Convert.ToInt32(txt2.Text.Trim()));
        //}
        //else if (suanfa == "-")
        //{
        //    label3.Text = Convert.ToString(Convert.ToInt32(txt1.Text.Trim()) - Convert.ToInt32(txt2.Text.Trim()));
        //}
        //else if (suanfa == "*")
        //{
        //    label3.Text = Convert.ToString(Convert.ToInt32(txt1.Text.Trim()) * Convert.ToInt32(txt2.Text.Trim()));
        //}
        //else if (suanfa == "/")
        //{
        //    label3.Text = Convert.ToString(Convert.ToInt32(txt1.Text.Trim()) / +Convert.ToInt32(txt2.Text.Trim()));
        //}
        //else
        //{
        //    MessageBox.Show("�����������д���");
        //    return;
        //}


        private bool yanzheng()
        {
            if (!IsInt(txt1.Text.Trim()))
            { MessageBox.Show("��һ����ֵ����Ƿ���");return false; }
            if (!IsInt(txt2.Text.Trim())){ MessageBox.Show("�ڶ�����ֵ����Ƿ���");return false; }
            if (txt2.Text.Trim() == "0" && txtsuanfa.Text.Trim() == "/") { MessageBox.Show("��������Ϊ0��"); return false; }
            if (!(txtsuanfa.Text.Trim() == "+" || txtsuanfa.Text.Trim() == "-" || txtsuanfa.Text.Trim() == "*" || txtsuanfa.Text.Trim() == "/")) {MessageBox.Show("���������"); return false; }
            return true;
        }

        private bool IsInt(string str)
        {
            try
            {
                Convert.ToInt32(str);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}