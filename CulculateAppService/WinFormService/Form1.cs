using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormService.ServiceMath;

namespace WinFormService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Culc_Click(object sender, EventArgs e)
        {           
            Int32 param1 = Convert.ToInt32(textbox1.Text);
            Int32 param2 = Convert.ToInt32(textbox2.Text);

            CulcServiceClient client =  new CulcServiceClient();
            Texbox3.Text = client.Add(param1,param2).ToString(); 
            
        }            
    }
}
