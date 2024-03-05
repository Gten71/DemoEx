using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class UserAgent : UserControl
    {
        public UserAgent ()
        {
            InitializeComponent();
        }

        public string Label1
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string Label2
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string Label3
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public string Label4
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public string Label5
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
        public void AddPicture ( string path )
        {
            if (path != "")
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + path);
                //pictureBox1.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, path));

        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void label5_Click ( object sender, EventArgs e )
        {

        }

        private void UserAgent_Load ( object sender, EventArgs e )
        {

        }
    }
}
