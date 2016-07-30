using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace test01.classes
{
    public class ClsMsgBox
    {
        public static void Jg(string mess)
        {
            MessageBox.Show(mess,"警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}