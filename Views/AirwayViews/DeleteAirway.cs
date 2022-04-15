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
    public partial class DeleteAirway : Form
    {
        public DeleteAirway()
        {
            InitializeComponent();
        }

        AirwayRepository airwayRepository = new AirwayRepository(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString);

        private void DeleteAirway_Load(object sender, EventArgs e)
        {
            Execute.Enabled = false;
            textBox1.MaxLength = 10;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Ви дійсно бажаєте видалити літак?\n\nЯкщо літак не буде знайдено, резльтат виведе початкові дані з даної таблиці.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    airwayRepository.Delete(Convert.ToInt32(textBox1.Text));
                    ResultGrid.DataSource = airwayRepository.GetAirways();

                    ResultGrid.Columns[0].HeaderText = "Ключ літаку";
                    ResultGrid.Columns[1].HeaderText = "Тип літаку";
                    ResultGrid.Columns[2].HeaderText = "Тип аеродрому";
                    ResultGrid.Columns[3].HeaderText = "Місцевість";
                    ResultGrid.Columns[4].HeaderText = "Протяжність";
                    ResultGrid.Columns[5].HeaderText = "Пропускна здатність";

                    ResultGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
                    ResultGrid.EnableHeadersVisualStyles = false;

                    if (ResultGrid.RowCount == 0)
                    {
                        MessageBox.Show("Дані для показу не знайдені. Можливо база даних не заповнена або запит повернув NULL.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                Execute.Enabled = false;
            }
            else
            {
                Execute.Enabled = true;
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
    }
}
