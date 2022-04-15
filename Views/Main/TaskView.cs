using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManager.Views.TaskViews;

namespace TransportManager.Views.Main
{
    public partial class TaskView : Form
    {
        public TaskView()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            Task1View task1View = new Task1View();
            task1View.Show();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            Task2View task2View = new Task2View();
            task2View.Show();
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            Task3View task3View = new Task3View();
            task3View.Show();
        }
    }
}
