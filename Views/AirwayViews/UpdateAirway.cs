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
    public partial class UpdateAirway : Form
    {
        public UpdateAirway()
        {
            InitializeComponent();
        }

        AirwayRepository airwayRepository = new AirwayRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void UpdateAirway_Load(object sender, EventArgs e)
        {
            Search.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox1.MaxLength = 10;
            textBox2.MaxLength = 50;
            textBox3.MaxLength = 50;
            textBox4.MaxLength = 50;
            textBox5.MaxLength = 10;
            textBox6.MaxLength = 10;
            Update.Enabled = false;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Airway airway = airwayRepository.GetAirwayById(Convert.ToInt32(textBox1.Text));
                textBox5.Text = airway.AirplaneType;
                textBox2.Text = airway.AirfieldType;
                textBox3.Text = airway.Strict;
                textBox4.Text = airway.Length.ToString();
                textBox6.Text = airway.Capacity.ToString();
                MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Ви впевнені у правильності введених даних?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Airway airway = new Airway();
                    airway.AirplaneType = textBox5.Text;
                    airway.AirfieldType = textBox2.Text;
                    airway.Capacity = Convert.ToInt32(textBox6.Text);
                    airway.Length = Convert.ToInt32(textBox4.Text);
                    airway.Strict = textBox3.Text;
                    airwayRepository.Update(airway, Convert.ToInt32(textBox1.Text));
                    MessageBox.Show("Літак успішно оновлено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = airwayRepository.GetAirways();

                    dataGridView1.Columns[0].HeaderText = "Ключ літаку";
                    dataGridView1.Columns[1].HeaderText = "Тип літаку";
                    dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
                    dataGridView1.Columns[3].HeaderText = "Місцевість";
                    dataGridView1.Columns[4].HeaderText = "Протяжність";
                    dataGridView1.Columns[5].HeaderText = "Пропускна здатність";

                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                Search.Enabled = true;
            }
            else
            {
                Search.Enabled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.TextLength > 0)
            {
                Update.Enabled = true;
            }
            else
            {
                Update.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && textBox2.ReadOnly == false)
            {
                Update.Enabled = true;
            }
            else
            {
                Update.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength > 0 && textBox3.ReadOnly == false)
            {
                Update.Enabled = true;
            }
            else
            {
                Update.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength > 0 && textBox4.ReadOnly == false)
            {
                Update.Enabled = true;
            }
            else
            {
                Update.Enabled = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.TextLength > 0 && textBox6.ReadOnly == false)
            {
                Update.Enabled = true;
            }
            else
            {
                Update.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox5.ReadOnly = false;
            }
            else
            {
                textBox5.ReadOnly = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox3.ReadOnly = false;
            }
            else
            {
                textBox3.ReadOnly = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox4.ReadOnly = false;
            }
            else
            {
                textBox4.ReadOnly = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox6.ReadOnly = false;
            }
            else
            {
                textBox6.ReadOnly = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            var num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }
    }
}
