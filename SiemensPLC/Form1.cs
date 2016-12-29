using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add Namespace
using SiemensPLC;

namespace SiemensPLC
{   
  
    public partial class Form1 : Form
    { 
        public Form1()  { 
        InitializeComponent();
             
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonBalan_Click(object sender, EventArgs e)
        {
           
            timer1.Enabled = true;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SiemensPLC.connectTo();
            //label1.Text = SiemensPLC.plcValue.ToString();

           
            

        }
    }
}
