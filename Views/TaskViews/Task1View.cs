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
    public partial class Task1View : Form
    {
        public Task1View()
        {
            InitializeComponent();
            Search.Enabled = false;
            textBox1.MaxLength = 50;
        }

        TaskRepository taskRepository = new TaskRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = taskRepository.FirstTask(textBox1.Text).ToString();
                MessageBox.Show("Успіх", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (label3.Text == "0")
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
                Search.Enabled = true;
            }
            else
            {
                Search.Enabled = false;
            }
        }

        private void Task1View_Load(object sender, EventArgs e)
        {

        }
    }
}
