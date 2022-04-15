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

namespace TransportManager.Views.TaskViews
{
    public partial class Task3View : Form
    {
        public Task3View()
        {
            InitializeComponent();
        }

        private void Task3View_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox2.ReadOnly = true;
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskRepository taskRepository = new TaskRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);
            try
            {
                dataGridView1.DataSource = taskRepository.ThirdTask(textBox1.Text, textBox2.Text);

                dataGridView1.Columns[0].HeaderText = "Ключ літаку";
                dataGridView1.Columns[1].HeaderText = "Тип літаку";
                dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
                dataGridView1.Columns[3].HeaderText = "Місцевість";
                dataGridView1.Columns[4].HeaderText = "Протяжність";
                dataGridView1.Columns[5].HeaderText = "Пропускна здатність";

                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 255, 229);
                dataGridView1.EnableHeadersVisualStyles = false;

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
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
    }
}
