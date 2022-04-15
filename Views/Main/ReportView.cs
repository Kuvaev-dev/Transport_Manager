using Dapper;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TransportManager.Views.Main
{
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
			try
			{
				label2.Text = "Дата створення звіту: " + DateTime.Now.ToString();
				using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString))
				{
					db.Query("INSERT INTO Transport( " +
					"AirplaneType, AirfieldType, " +
					"TransportType, CoatingType, " +
					"TrainType, TrackType, " +
					"Airway_id, Highway_id, Railway_id, " +
					"Strict, Length, Capacity) " +
					"SELECT " +
					"AirplaneType, AirfieldType, " +
					"NULL, NULL, " +
					"NULL, NULL, " +
					"Airway.Id, NULL, NULL, " +
					"Strict, Length, Capacity " +
					"FROM Airway " +
					"INSERT INTO Transport( " +
					"AirplaneType, AirfieldType, " +
					"TransportType, CoatingType, " +
					"TrainType, TrackType, " +
					"Airway_id, Highway_id, Railway_id, " +
					"Strict, Length, Capacity) " +
					"SELECT " +
					"NULL, NULL, " +
					"TransportType, CoatingType, " +
					"NULL, NULL, " +
					"NULL, Highway.Id, NULL, " +
					"Strict, Length, Capacity " +
					"FROM Highway " +
					"INSERT INTO Transport( " +
					"AirplaneType, AirfieldType, " +
					"TransportType, CoatingType, " +
					"TrainType, TrackType, " +
					"Airway_id, Highway_id, Railway_id, " +
					"Strict, Length, Capacity) " +
					"SELECT " +
					"NULL, NULL, " +
					"NULL, NULL, " +
					"TrainType, TrackType, " +
					"NULL, NULL, Railway.Id, " +
					"Strict, Length, Capacity " +
					"FROM Railway");

					dataGridView1.DataSource = db.Query("SELECT ROW_NUMBER() OVER(ORDER BY Strict ASC) AS # ," +
					"ISNULL(Strict, 'NULL') AS Strict, ISNULL(AirplaneType, 'NULL') AS AirplaneType, ISNULL(AirfieldType, 'NULL') AS AirfieldType, " +
					"ISNULL(TransportType, 'NULL') AS TransportType, ISNULL(CoatingType, 'NULL') AS CoatingType, " +
					"ISNULL(TrainType, 'NULL') AS TrainType, ISNULL(TrackType, 'NULL') AS TrackType, " +
					"ISNULL(Airway_id, 0) AS Airway_id, ISNULL(Highway_id, 0) AS Highway_id, " +
					"ISNULL(Railway_id, 0) AS Railway_id, " +
					"ISNULL(Length, 0) AS Length, ISNULL(Capacity, 0) AS Capacity " +
					"FROM Transport").ToList();
				}

				dataGridView1.Columns[1].HeaderText = "Місцевість";
				dataGridView1.Columns[2].HeaderText = "Тип літаку";
				dataGridView1.Columns[3].HeaderText = "Тип аеродрому";
				dataGridView1.Columns[4].HeaderText = "Тип транспорту";
				dataGridView1.Columns[5].HeaderText = "Тип покриття";
				dataGridView1.Columns[6].HeaderText = "Тип потягу";
				dataGridView1.Columns[7].HeaderText = "Тип колії";
				dataGridView1.Columns[8].HeaderText = "Ключ літаку";
				dataGridView1.Columns[9].HeaderText = "Ключ автодороги";
				dataGridView1.Columns[10].HeaderText = "Ключ залізниці";
				dataGridView1.Columns[11].HeaderText = "Протяжність";
				dataGridView1.Columns[12].HeaderText = "Пропускна здатність";
				dataGridView1.Columns[14].HeaderText = "Місцевість";
				dataGridView1.Columns[15].HeaderText = "Тип літаку";
				dataGridView1.Columns[16].HeaderText = "Тип аеродрому";
				dataGridView1.Columns[17].HeaderText = "Тип транспорту";
				dataGridView1.Columns[18].HeaderText = "Тип покриття";
				dataGridView1.Columns[19].HeaderText = "Тип потягу";
				dataGridView1.Columns[20].HeaderText = "Тип колії";
				dataGridView1.Columns[21].HeaderText = "Ключ літаку";
				dataGridView1.Columns[22].HeaderText = "Ключ автодороги";
				dataGridView1.Columns[23].HeaderText = "Ключ залізниці";
				dataGridView1.Columns[24].HeaderText = "Протяжність";
				dataGridView1.Columns[25].HeaderText = "Пропускна здатність";

				dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 204, 255);
				dataGridView1.EnableHeadersVisualStyles = false;

				MessageBox.Show("Звіт успішно створено!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void CratReportsTable_Click(object sender, EventArgs e)
        {
			try
			{
				using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Transport"].ConnectionString))
				{
					db.Query("CREATE TABLE [dbo].[Transport] ( " +
					"[Id][int] IDENTITY(1, 1) NOT NULL, " +
					"[AirplaneType][nvarchar](50) NULL, " +
					"[AirfieldType][nvarchar](50) NULL, " +
					"[TransportType][nvarchar](50) NULL, " +
					"[CoatingType][nvarchar](50) NULL, " +
					"[TrainType][nvarchar](50) NULL, " +
					"[TrackType][nvarchar](50) NULL, " +
					"[Highway_id][int] NULL, " +
					"[Airway_id][int] NULL, " +
					"[Railway_id][int] NULL, " +
					"[Strict][nvarchar](50) NULL, " +
					"[Length][int] NULL, " +
					"[Capacity][int] NULL, " +
					"PRIMARY KEY CLUSTERED([Id] ASC));");
				}

				MessageBox.Show("Таблицю успішно створено!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
			try
			{
				SaveFileDialog dialog = new SaveFileDialog();
				dialog.Filter = "Файл Excel (*.xls)|*.xls";
				var result = dialog.ShowDialog();
				if (result != DialogResult.OK)
					return;

				Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
				excelApp.Application.Workbooks.Add(Type.Missing);
				excelApp.Columns.ColumnWidth = 15;
				excelApp.Columns.Sort(excelApp.Columns[2]);

				excelApp.Cells[1, 1] = "№ п/п";
				excelApp.Cells[1, 2] = "Місцевість";
				excelApp.Cells[1, 3] = "Тип літаку";
				excelApp.Cells[1, 4] = "Тип аеродрому";
				excelApp.Cells[1, 5] = "Тип транспорту";
				excelApp.Cells[1, 6] = "Тип покриття";
				excelApp.Cells[1, 7] = "Тип потягу";
				excelApp.Cells[1, 8] = "Тип колії";
				excelApp.Cells[1, 9] = "Ключ літаку";
				excelApp.Cells[1, 10] = "Ключ автодороги";
				excelApp.Cells[1, 11] = "Ключ залізниці";
				excelApp.Cells[1, 12] = "Протяжність";
				excelApp.Cells[1, 13] = "Пропускна здатність";
				excelApp.Cells[1, 14] = "Місцевість";
				excelApp.Cells[1, 15] = "Тип літаку";
				excelApp.Cells[1, 16] = "Тип аеродрому";
				excelApp.Cells[1, 17] = "Тип транспорту";
				excelApp.Cells[1, 18] = "Тип покриття";
				excelApp.Cells[1, 19] = "Тип потягу";
				excelApp.Cells[1, 20] = "Тип колії";
				excelApp.Cells[1, 21] = "Ключ літаку";
				excelApp.Cells[1, 22] = "Ключ автодороги";
				excelApp.Cells[1, 23] = "Ключ залізниці";
				excelApp.Cells[1, 24] = "Протяжність";
				excelApp.Cells[1, 25] = "Пропускна здатність";

				for (int i = 0; i < dataGridView1.ColumnCount; i++)
				{
					for (int j = 0; j < dataGridView1.RowCount; j++)
					{
						excelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
					}
				}
				excelApp.Visible = true;
			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void SaveAsXLS_Click(object sender, EventArgs e)
        {
			try
			{
				SaveFileDialog dialog = new SaveFileDialog();
				dialog.Filter = "Текстовые файлы (*.txt)|*.txt";
				var result = dialog.ShowDialog();
				if (result != DialogResult.OK)
					return;

				dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
				dataGridView1.SelectAll();

				var rowHeaders = dataGridView1.RowHeadersVisible;
				dataGridView1.RowHeadersVisible = false;

				string content = dataGridView1.GetClipboardContent().GetText();
				dataGridView1.ClearSelection();
				dataGridView1.RowHeadersVisible = rowHeaders;
				File.WriteAllText(dialog.FileName, content + "\t\t");
			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
    }
}
