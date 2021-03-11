using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //to creat an object 
            // ClassName objectName = new ClassName ();

            Person p = new Person();
            label1.Text = p.ShowDetails();
            label2.Text = p.AddFiveToAge().ToString();

        }
    }
}
