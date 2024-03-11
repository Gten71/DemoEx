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
        }
        private Tuple<string, string, string, string, string, Image> formData;

        public void SetData ( string data1, string data2, string data3, string data4, string data5, Image image )
        {
            textBox1.Text = data1;
            textBox2.Text = data2;
            textBox3.Text = data3;
            textBox4.Text = data4;
            textBox5.Text = data5;
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
    }
}
