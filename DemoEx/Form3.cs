using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class Form3 : Form
    {
        public Form3 ()
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


        private Tuple<string, string, string, string, string, Image> formData;

        public void SetData ( string data1, string data2, string data3, string data4, string data5, Image image )
        {
            textBox1.Text = data1;
            textBox3.Text = data2;
            textBox4.Text = data3;
            textBox8.Text = data4;
            textBox7.Text = data5;
            pictureBox1.Image = image;
        }

        public Tuple<string, string, string, string, string, Image> GetData ()
        {
            return new Tuple<string, string, string, string, string, Image>(
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, pictureBox1.Image);
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            // Обновите данные в базе данных и закройте форму.
            // Реализуйте логику обновления данных в базе данных.
            // ...
            this.Close();
        }

        private void Form3_Load ( object sender, EventArgs e )
        {

        }

        private void textBox5_TextChanged ( object sender, EventArgs e )
        {

        }

        private void textBox8_TextChanged ( object sender, EventArgs e )
        {

        }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void textBox3_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}
