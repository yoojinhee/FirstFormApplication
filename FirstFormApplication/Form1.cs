using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //myButton.Enabled = false;
            myButton.Enabled = true;
            myButton.Text = "코드에서 변경";
            myButton.Width = 100;

            for(int i=0;i<5; i++)
            {
                Button button = new Button();
                button.Location = new Point(213, 13 + (23 + 3)*i);

                Controls.Add(button);
                button.Text = "동적 생성"+i+"번째";
                button.Width = 100;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
