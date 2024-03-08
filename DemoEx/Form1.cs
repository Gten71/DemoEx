using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEx
{
    public partial class Form1 : Form
    {
        public int current = 0;

        public Form1 ()
        {
            InitializeComponent();
            LoadData();
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            CustomizeButton(button1);
            CustomizeButton(button2);
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

        public void LoadData ()
        {
            flowLayoutPanel1.Controls.Clear();
            using (ModelDb db = new ModelDb())
            {
                var users = from agent in db.Agent
                            join sale in db.ProductSale on agent.Title equals sale.AgentName
                            join product in db.Product on sale.ProductName equals product.Title
                            select new
                            {
                                Name = sale.ProductName,
                                AgentEmail = agent.Email,
                                Count = sale.ProductCount,
                                Number = agent.Phone,
                                TypeAgent = agent.AgentTypeID,
                                Agent = agent.Title,
                                AgentPriority = agent.Priority,
                                Picture = agent.Logo
                            };


                var list = users.ToList();
                for (int i = current; i < Math.Min(current + 10, list.Count); i++)
                {
                    int disc = 0;
                    if (list[i].Count < 10000) disc = 0;
                    else if (list[i].Count > 10000 && list[i].Count < 50000) disc = 5;
                    else if (list[i].Count > 50000 && list[i].Count < 150000) disc = 10;
                    else if (list[i].Count > 150000 && list[i].Count < 500000) disc = 20;
                    else disc = 25;

                    UserAgent userAgent = new UserAgent()
                    {
                        Label1 = list[i].TypeAgent + "|" + list[i].Agent,
                        Label2 = list[i].Count + " продаж за год",
                        Label3 = list[i].Number,
                        Label4 = list[i].AgentPriority.ToString(),
                        Label5 = disc.ToString() + "%"

                    };
                    userAgent.AddPicture(list[i].Picture);
                    flowLayoutPanel1.Controls.Add(userAgent);
                }
            }
        }

        public void Form1_Load ( object sender, EventArgs e )
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fopracticeDataSet.AgentType". При необходимости она может быть перемещена или удалена.
            this.agentTypeTableAdapter.Fill(this.fopracticeDataSet.AgentType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fopracticeDataSet.Agent". При необходимости она может быть перемещена или удалена.
            this.agentTableAdapter.Fill(this.fopracticeDataSet.Agent);
        }





        public void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {
            string selectedValue = comboBox1.SelectedItem.ToString();


        }

        public void comboBox2_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        public void textBox1_TextChanged ( object sender, EventArgs e )
        {

        }

        public void button2_Click ( object sender, EventArgs e )
        {
            
            current = Math.Max(0, current - 10);
            LoadData();
        }

        public void button1_Click ( object sender, EventArgs e )
        {
            current += 10;
            LoadData();
        }
    }
}
