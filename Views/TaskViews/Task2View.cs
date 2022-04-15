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
    public partial class Task2View : Form
    {
        public Task2View()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        TaskRepository taskRepository = new TaskRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = taskRepository.SecondTask(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Успіх", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView1.Columns[0].HeaderText = "Ключ дороги";
                dataGridView1.Columns[1].HeaderText = "Тип транспорту";
                dataGridView1.Columns[2].HeaderText = "Тип покриття";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var sym = e.KeyChar;
            if (!Char.IsDigit(sym))
            {
                e.Handled = true;
            }
        }

        private void Task2View_Load(object sender, EventArgs e)
        {

        }
    }
}
