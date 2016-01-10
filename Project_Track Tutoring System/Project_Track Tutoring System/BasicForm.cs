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
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
        }
        void adjust_component()
        {
            int width = this.Width / 7;
            CodePanel.Width = width * 4;
            OutputPanel.Width = width * 3;

        }

        private void BasicForm_Load(object sender, EventArgs e)
        {

        }
    }
}
