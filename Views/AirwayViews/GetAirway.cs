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
using TransportManager.Repositories;

namespace TransportManager.Views.AirwayViews
{
    public partial class GetAirway : Form
    {
        public GetAirway()
        {
            InitializeComponent();
        }

        AirwayRepository airwayRepository = new AirwayRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void GetAirway_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.MaxLength = 10;
            textBox2.ReadOnly = true;
            textBox2.MaxLength = 50;
            textBox3.ReadOnly = true;
            textBox3.MaxLength = 50;
            textBox4.ReadOnly = true;
            textBox4.MaxLength = 50;
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 9999999999;
            numericUpDown2.ReadOnly = true;
            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 9999999999;
            numericUpDown3.ReadOnly = true;
            numericUpDown3.Minimum = 1;
            numericUpDown3.Maximum = 9999999999;
            numericUpDown4.ReadOnly = true;
            numericUpDown4.Minimum = 1;
            numericUpDown4.Maximum = 9999999999;
            button1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ReadOnly = false;
            } 
            else
            {
                textBox1.ReadOnly = true;
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
                numericUpDown1.ReadOnly = false;
                numericUpDown2.ReadOnly = false;
            }
            else
            {
                numericUpDown1.ReadOnly = true;
                numericUpDown2.ReadOnly = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                numericUpDown3.ReadOnly = false;
                numericUpDown4.ReadOnly = false;
            }
            else
            {
                numericUpDown3.ReadOnly = true;
                numericUpDown4.ReadOnly = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                button1.Enabled = true;
            } 
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.TextLength > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    dataGridView1.DataSource = airwayRepository.GetAirwayListById(Convert.ToInt32(textBox1.Text));
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton2.Checked)
                {
                    dataGridView1.DataSource = airwayRepository.GetAirwayByAirplaneType(textBox2.Text);
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton3.Checked)
                {
                    dataGridView1.DataSource = airwayRepository.GetAirwayByAirfieldType(textBox3.Text);
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton4.Checked)
                {
                    dataGridView1.DataSource = airwayRepository.GetAirwayByStrict(textBox4.Text);
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton5.Checked)
                { 
                    dataGridView1.DataSource = airwayRepository.GetAirwayByLength(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (radioButton6.Checked)
                {
                    dataGridView1.DataSource = airwayRepository.GetAirwayByCapacity(Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value));
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Літак успішно знайдено", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                dataGridView1.Columns[0].HeaderText = "Ключ літаку";
                dataGridView1.Columns[1].HeaderText = "Тип літаку";
                dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
                dataGridView1.Columns[3].HeaderText = "Місцевість";
                dataGridView1.Columns[4].HeaderText = "Протяжність";
                dataGridView1.Columns[5].HeaderText = "Пропускна здатність";

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
                dataGridView1.EnableHeadersVisualStyles = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown1.Value < numericUpDown2.Value)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0 && numericUpDown2.Value > numericUpDown1.Value)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 0 && numericUpDown4.Value < numericUpDown3.Value)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0 && numericUpDown4.Value < numericUpDown3.Value)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
