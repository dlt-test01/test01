using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace test01
{
    partial class suanfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.btnnum = new Gizmox.WebGUI.Forms.Button();
            this.txt1 = new Gizmox.WebGUI.Forms.TextBox();
            this.txt2 = new Gizmox.WebGUI.Forms.TextBox();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.txtsuanfa = new Gizmox.WebGUI.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入第一个数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入第二个数";
            // 
            // btnnum
            // 
            this.btnnum.Location = new System.Drawing.Point(72, 167);
            this.btnnum.Name = "btnnum";
            this.btnnum.Size = new System.Drawing.Size(75, 23);
            this.btnnum.TabIndex = 4;
            this.btnnum.Text = "计算";
            this.btnnum.Click += new System.EventHandler(this.btnnum_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(177, 42);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(177, 83);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(204, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "请输入算法";
            // 
            // txtsuanfa
            // 
            this.txtsuanfa.Location = new System.Drawing.Point(177, 128);
            this.txtsuanfa.Name = "txtsuanfa";
            this.txtsuanfa.Size = new System.Drawing.Size(100, 20);
            this.txtsuanfa.TabIndex = 3;
            // 
            // suanfa
            // 
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.txtsuanfa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Size = new System.Drawing.Size(359, 338);
            this.Text = "suanfa";
            this.ResumeLayout(false);

        }


        #endregion

        private Label label1;
        private Label label2;
        private Button btnnum;
        private TextBox txt1;
        private TextBox txt2;
        private Label label3;
        private Label label4;
        private TextBox txtsuanfa;
    }
}