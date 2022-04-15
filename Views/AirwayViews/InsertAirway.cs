using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManager.Models;
using TransportManager.Repositories;

namespace TransportManager.Views.AirwayViews
{
    public partial class InsertAirway : Form
    {
        public InsertAirway()
        {
            InitializeComponent();
        }

        AirwayRepository airwayRepository = new AirwayRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void InsertAirway_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;

            textBox2.MaxLength = 50;
            textBox3.MaxLength = 50;
            textBox4.MaxLength = 50;
            textBox5.MaxLength = 10;
            textBox6.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені у правильності введених даних?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Airway airway = new Airway();
                    airway.AirplaneType = textBox2.Text;
                    airway.AirfieldType = textBox3.Text;
                    airway.Strict = textBox4.Text;
                    airway.Length = Convert.ToInt32(textBox5.Text);
                    airway.Capacity = Convert.ToInt32(textBox6.Text);
                    airwayRepository.Insert(airway);
                    MessageBox.Show("Літак успішно додано", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = airwayRepository.GetAirways();
                    dataGridView1.Columns[0].HeaderText = "Ключ літаку";
                    dataGridView1.Columns[1].HeaderText = "Тип літаку";
                    dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
                    dataGridView1.Columns[3].HeaderText = "Місцевість";
                    dataGridView1.Columns[4].HeaderText = "Протяжність";
                    dataGridView1.Columns[5].HeaderText = "Пропускна здатність";

                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 204, 255);
                    dataGridView1.EnableHeadersVisualStyles = false;

                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                textBox3.ReadOnly = false;
            }
            else if (textBox2.TextLength == 0)
            {
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                button1.Enabled = false;
            }
            else
            {
                textBox3.ReadOnly = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && textBox3.TextLength > 0)
            {
                textBox4.ReadOnly = false;
            }
            else if (textBox3.TextLength == 0)
            {
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                button1.Enabled = false;
            }
            else
            {
                textBox4.ReadOnly = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 &&
                textBox3.TextLength > 0 &&
                textBox4.TextLength > 0)
            {
                textBox5.ReadOnly = false;
            }
            else if (textBox4.TextLength == 0)
            {
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                button1.Enabled = false;
            }
            else
            {
                textBox5.ReadOnly = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 &&
                textBox3.TextLength > 0 &&
                textBox4.TextLength > 0 && 
                textBox5.TextLength > 0)
            {
                textBox6.ReadOnly = false;
            }
            else if (textBox5.TextLength == 0)
            {
                textBox6.ReadOnly = true;
                button1.Enabled = false;
            }
            else
            {
                textBox6.ReadOnly = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 &&
                textBox3.TextLength > 0 &&
                textBox4.TextLength > 0 &&
                textBox5.TextLength > 0 &&
                textBox6.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else if (textBox6.TextLength == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
