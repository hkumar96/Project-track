using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Track_Tutoring_System
{
    public partial class Home_Form : Form
    {
        int center_x, center_y;
        public Home_Form()
        {
            InitializeComponent();
        }
        private void adjust_components()
        {
            int height=this.Height/20;
            panel1.Height = height*2;            
            Link_Panel.Height = height;
            Image_Panel.Height = height * 17;
            center_x = Image_Panel.Width / 2;
            center_y = Image_Panel.Height / 2;
            Go_Button.Location = new Point(center_x + 250, center_y + 60);
            //Go_Button.Location = a;
            pictureBox1.Size = new System.Drawing.Size(971, 401);
            pictureBox1.Location = new Point(center_x - 485, center_y - 200);
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            adjust_components();
        }

        private void Home_Form_Resize(object sender, EventArgs e)
        {
            adjust_components();
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {
            BasicForm myForm = new BasicForm();
            myForm.Show();
            this.Close();
        }
    }
}
