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
            CustomizeButton(button1);
        }
        private void CustomizeButton ( Button button )
        {
            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button.BackColor = System.Drawing.Color.LightGray;

            int cornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            button.Region = new System.Drawing.Region(path);
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

        private void button1_Click ( object sender, EventArgs e )
        {
            Form3 addForm = new Form3();
            addForm.SetData(Label1, Label2, Label3, Label4, Label5, pictureBox1.Image);
            addForm.ShowDialog();
        }
    }
}
