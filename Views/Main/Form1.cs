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
using TransportManager.Views.Main;

namespace TransportManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public TransportRepository transportRepository = new TransportRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void Operations_Click(object sender, EventArgs e)
        {
            OperationsView operationsView = new OperationsView();
            operationsView.Show();
        }

        private void Tasks_Click(object sender, EventArgs e)
        {
            TaskView taskView = new TaskView();
            taskView.Show();
        }

        private void DeleteDB_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Ви дійсно бажаєте видалити базу без її подальшого відновлення?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    transportRepository.DeleteDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = transportRepository.GetAllAirways();
                dataGridView2.DataSource = transportRepository.GetAllHighways();
                dataGridView3.DataSource = transportRepository.GetAllRailways();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.Columns[0].HeaderText = "Ключ літаку";
            dataGridView1.Columns[1].HeaderText = "Тип літаку";
            dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
            dataGridView1.Columns[3].HeaderText = "Місцевість";
            dataGridView1.Columns[4].HeaderText = "Протяжність";
            dataGridView1.Columns[5].HeaderText = "Пропускна здатність";

            dataGridView2.Columns[0].HeaderText = "Ключ залізниці";
            dataGridView2.Columns[1].HeaderText = "Тип потягу";
            dataGridView2.Columns[2].HeaderText = "Тип колії";
            dataGridView2.Columns[3].HeaderText = "Місцевість";
            dataGridView2.Columns[4].HeaderText = "Протяжність";
            dataGridView2.Columns[5].HeaderText = "Пропускна здатність";

            dataGridView3.Columns[0].HeaderText = "Ключ дороги";
            dataGridView3.Columns[1].HeaderText = "Тип транспорту";
            dataGridView3.Columns[2].HeaderText = "Тип покриття";
            dataGridView3.Columns[3].HeaderText = "Місцевість";
            dataGridView3.Columns[4].HeaderText = "Протяжність";
            dataGridView3.Columns[5].HeaderText = "Пропускна здатність";

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 255, 204);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 255, 204);
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(153, 255, 204);
            dataGridView3.EnableHeadersVisualStyles = false;

            if (dataGridView1.RowCount == 0 || dataGridView2.RowCount == 0 || dataGridView3.RowCount == 0)
            {
                MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AirwayCB.DropDownStyle = ComboBoxStyle.DropDownList;
            RailwayCB.DropDownStyle = ComboBoxStyle.DropDownList;
            HighwayCB.DropDownStyle = ComboBoxStyle.DropDownList;

            AirwayCB.Items.Add("Ключ літаку за зростанням");
            AirwayCB.Items.Add("Ключ літаку за спаданням");
            AirwayCB.Items.Add("Тип літаку за зростанням");
            AirwayCB.Items.Add("Тип літаку за спаданням");
            AirwayCB.Items.Add("Тип аеродрому за зростанням");
            AirwayCB.Items.Add("Тип аеродрому за спаданням");
            AirwayCB.Items.Add("Місцевість за зростанням");
            AirwayCB.Items.Add("Місцевість за спаданням");
            AirwayCB.Items.Add("Протяжність за зростанням");
            AirwayCB.Items.Add("Протяжність за спаданням");
            AirwayCB.Items.Add("Пропускна здатність за зростанням");
            AirwayCB.Items.Add("Пропскна здатність за спаданням");

            RailwayCB.Items.Add("Ключ потягу за зростанням");
            RailwayCB.Items.Add("Ключ потягу за спаданням");
            RailwayCB.Items.Add("Тип потягу за зростанням");
            RailwayCB.Items.Add("Тип потягу за спаданням");
            RailwayCB.Items.Add("Тип колії за зростанням");
            RailwayCB.Items.Add("Тип колії за спаданням");
            RailwayCB.Items.Add("Місцевість за зростанням");
            RailwayCB.Items.Add("Місцевість за спаданням");
            RailwayCB.Items.Add("Протяжність за зростанням");
            RailwayCB.Items.Add("Протяжність за спаданням");
            RailwayCB.Items.Add("Пропускна здатність за зростанням");
            RailwayCB.Items.Add("Пропскна здатність за спаданням");

            HighwayCB.Items.Add("Ключ дороги за зростанням");
            HighwayCB.Items.Add("Ключ дороги за спаданням");
            HighwayCB.Items.Add("Тип транспорту за зростанням");
            HighwayCB.Items.Add("Тип транспорту за спаданням");
            HighwayCB.Items.Add("Тип покриття за зростанням");
            HighwayCB.Items.Add("Тип покриття за спаданням");
            HighwayCB.Items.Add("Місцевість за зростанням");
            HighwayCB.Items.Add("Місцевість за спаданням");
            HighwayCB.Items.Add("Протяжність за зростанням");
            HighwayCB.Items.Add("Протяжність за спаданням");
            HighwayCB.Items.Add("Пропускна здатність за зростанням");
            HighwayCB.Items.Add("Пропскна здатність за спаданням");
        }

        private void GetReport_Click(object sender, EventArgs e)
        {
            ReportView reportView = new ReportView();
            reportView.Show();
        }

        private void RefreshDG1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transportRepository.GetAllAirways();
            dataGridView1.Columns[0].HeaderText = "Ключ літаку";
            dataGridView1.Columns[1].HeaderText = "Тип літаку";
            dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
            dataGridView1.Columns[3].HeaderText = "Місцевість";
            dataGridView1.Columns[4].HeaderText = "Протяжність";
            dataGridView1.Columns[5].HeaderText = "Пропускна здатність";
        }

        private void RefreshDG2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = transportRepository.GetAllRailways();
            dataGridView2.Columns[0].HeaderText = "Ключ залізниці";
            dataGridView2.Columns[1].HeaderText = "Тип потягу";
            dataGridView2.Columns[2].HeaderText = "Тип колії";
            dataGridView2.Columns[3].HeaderText = "Місцевість";
            dataGridView2.Columns[4].HeaderText = "Протяжність";
            dataGridView2.Columns[5].HeaderText = "Пропускна здатність";
        }

        private void RefreshDG3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = transportRepository.GetAllHighways();
            dataGridView3.Columns[0].HeaderText = "Ключ дороги";
            dataGridView3.Columns[1].HeaderText = "Тип транспорту";
            dataGridView3.Columns[2].HeaderText = "Тип покриття";
            dataGridView3.Columns[3].HeaderText = "Місцевість";
            dataGridView3.Columns[4].HeaderText = "Протяжність";
            dataGridView3.Columns[5].HeaderText = "Пропускна здатність";
        }

        private void AirwayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            transportRepository.SortAirways(dataGridView1, AirwayCB);
            dataGridView1.Columns[0].HeaderText = "Ключ літаку";
            dataGridView1.Columns[1].HeaderText = "Тип літаку";
            dataGridView1.Columns[2].HeaderText = "Тип аеродрому";
            dataGridView1.Columns[3].HeaderText = "Місцевість";
            dataGridView1.Columns[4].HeaderText = "Протяжність";
            dataGridView1.Columns[5].HeaderText = "Пропускна здатність";
        }

        private void RailwayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            transportRepository.SortRailways(dataGridView2, RailwayCB);
            dataGridView2.Columns[0].HeaderText = "Ключ залізниці";
            dataGridView2.Columns[1].HeaderText = "Тип потягу";
            dataGridView2.Columns[2].HeaderText = "Тип колії";
            dataGridView2.Columns[3].HeaderText = "Місцевість";
            dataGridView2.Columns[4].HeaderText = "Протяжність";
            dataGridView2.Columns[5].HeaderText = "Пропускна здатність";
        }

        private void HighwayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            transportRepository.SortHighways(dataGridView3, HighwayCB);
            dataGridView3.Columns[0].HeaderText = "Ключ дороги";
            dataGridView3.Columns[1].HeaderText = "Тип транспорту";
            dataGridView3.Columns[2].HeaderText = "Тип покриття";
            dataGridView3.Columns[3].HeaderText = "Місцевість";
            dataGridView3.Columns[4].HeaderText = "Протяжність";
            dataGridView3.Columns[5].HeaderText = "Пропускна здатність";
        }
    }
}
