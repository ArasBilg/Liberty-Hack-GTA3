using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;



namespace LibertyHack
{
    public partial class Form1 : Form
    {
        Mem meme = new Mem();
        private CheckBox checkBox1;
        public static string Money = "Gta3.exe+0x004E288C,4";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = meme.GetProcIdFromName("Gta3");
            if (PID >0)
            {
                meme.OpenProcess(PID);
                Thread WM = new Thread(writeMoney) { IsBackground = true };
                WM.Start();

            }
        }

        private void writeMoney()
        {
            while(true)
            {
                if (checkBox1.Checked)
                {
                    meme.WriteMemory(Money, "int", "99999999");
                    Thread.Sleep(2);
;                }
                Thread.Sleep(2);
            }

        }

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(118, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Money";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(491, 424);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Liberty Hack 1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}