
namespace TransportManager.Views.Main
{
    partial class ReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveAs = new System.Windows.Forms.Button();
            this.CratReportsTable = new System.Windows.Forms.Button();
            this.SaveAsXLS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Резльтат останніх змін у базі даних \"Транспорт\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Повний облік бази даних:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 446);
            this.dataGridView1.TabIndex = 4;
            // 
            // SaveAs
            // 
            this.SaveAs.Location = new System.Drawing.Point(619, 9);
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(187, 23);
            this.SaveAs.TabIndex = 5;
            this.SaveAs.Text = "Зберегти, як .xls";
            this.SaveAs.UseVisualStyleBackColor = true;
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // CratReportsTable
            // 
            this.CratReportsTable.Location = new System.Drawing.Point(619, 67);
            this.CratReportsTable.Name = "CratReportsTable";
            this.CratReportsTable.Size = new System.Drawing.Size(187, 23);
            this.CratReportsTable.TabIndex = 6;
            this.CratReportsTable.Text = "Створити таблицю звітів";
            this.CratReportsTable.UseVisualStyleBackColor = true;
            this.CratReportsTable.Click += new System.EventHandler(this.CratReportsTable_Click);
            // 
            // SaveAsXLS
            // 
            this.SaveAsXLS.Location = new System.Drawing.Point(619, 38);
            this.SaveAsXLS.Name = "SaveAsXLS";
            this.SaveAsXLS.Size = new System.Drawing.Size(187, 23);
            this.SaveAsXLS.TabIndex = 7;
            this.SaveAsXLS.Text = "Зберегти, як .txt";
            this.SaveAsXLS.UseVisualStyleBackColor = true;
            this.SaveAsXLS.Click += new System.EventHandler(this.SaveAsXLS_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(818, 563);
            this.Controls.Add(this.SaveAsXLS);
            this.Controls.Add(this.CratReportsTable);
            this.Controls.Add(this.SaveAs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звіт до бази даних \"Транспорт\"";
            this.Load += new System.EventHandler(this.ReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveAs;
        private System.Windows.Forms.Button CratReportsTable;
        private System.Windows.Forms.Button SaveAsXLS;
    }
}