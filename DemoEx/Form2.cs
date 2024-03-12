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
    public partial class Form2 : Form
    {
        private string foto, path;
        public bool ForEdit { get; set; }
        public Form2 ()
        {
            InitializeComponent();
            CustomizeButton(button1);
            CustomizeButton(button2);
            CustomizeButton(button3);
        }
        private void CustomizeButton ( Button button )
        {
            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
            button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button.BackColor = System.Drawing.Color.LightGray;
            button.BackColor = ColorTranslator.FromHtml("#FFE9F9");
            int cornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            button.Region = new System.Drawing.Region(path);
        }
        public string Foto { get; set; }

        private void button1_Click ( object sender, EventArgs e )
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                pictureBox1.Image = Image.FromFile(path);
            }
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            if (ForEdit == false)
            {
                string newPath = Environment.CurrentDirectory + @"\agents\" + foto;
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.CopyTo(newPath, true);
                }
                Foto = @"\agents\" + foto;
            }
        }

        private void Form2_Load ( object sender, EventArgs e )
        {

        }

        private void label2_Click ( object sender, EventArgs e )
        {

        }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void label5_Click ( object sender, EventArgs e )
        {

        }

        private void textBox2_TextChanged ( object sender, EventArgs e )
        {

        }

        private void textBox3_TextChanged ( object sender, EventArgs e )
        {

        }

        private void label4_Click ( object sender, EventArgs e )
        {

        }

        private void label6_Click ( object sender, EventArgs e )
        {

        }

        private void textBox4_TextChanged ( object sender, EventArgs e )
        {

        }

        private void textBox8_TextChanged ( object sender, EventArgs e )
        {

        }

        private void label8_Click ( object sender, EventArgs e )
        {

        }

        private void label10_Click ( object sender, EventArgs e )
        {

        }

        private void textBox7_TextChanged ( object sender, EventArgs e )
        {

        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {

        }

        private void label9_Click ( object sender, EventArgs e )
        {

        }

        private void textBox5_TextChanged ( object sender, EventArgs e )
        {

        }

        private void label7_Click ( object sender, EventArgs e )
        {

        }

        private void pictureBox1_Click ( object sender, EventArgs e )
        {

        }

        private void textBox6_TextChanged ( object sender, EventArgs e )
        {

        }

        private void label11_Click ( object sender, EventArgs e )
        {

        }

        private void pictureBox2_Click ( object sender, EventArgs e )
        {

        }

        private void button3_Click ( object sender, EventArgs e )
        {

        }

        public void LoadFoto ( string path )
        {
            pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + path);
        }
    }
}
