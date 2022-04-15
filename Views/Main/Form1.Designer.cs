
namespace TransportManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tasks = new System.Windows.Forms.Button();
            this.Operations = new System.Windows.Forms.Button();
            this.DeleteDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.GetReport = new System.Windows.Forms.Button();
            this.RefreshDG1 = new System.Windows.Forms.Button();
            this.RefreshDG2 = new System.Windows.Forms.Button();
            this.RefreshDG3 = new System.Windows.Forms.Button();
            this.AirwayCB = new System.Windows.Forms.ComboBox();
            this.RailwayCB = new System.Windows.Forms.ComboBox();
            this.HighwayCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Tasks
            // 
            this.Tasks.Location = new System.Drawing.Point(26, 601);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(136, 23);
            this.Tasks.TabIndex = 3;
            this.Tasks.Text = "Завдання";
            this.Tasks.UseVisualStyleBackColor = true;
            this.Tasks.Click += new System.EventHandler(this.Tasks_Click);
            // 
            // Operations
            // 
            this.Operations.Location = new System.Drawing.Point(650, 16);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(136, 23);
            this.Operations.TabIndex = 4;
            this.Operations.Text = "Операції";
            this.Operations.UseVisualStyleBackColor = true;
            this.Operations.Click += new System.EventHandler(this.Operations_Click);
            // 
            // DeleteDB
            // 
            this.DeleteDB.Location = new System.Drawing.Point(650, 601);
            this.DeleteDB.Name = "DeleteDB";
            this.DeleteDB.Size = new System.Drawing.Size(136, 23);
            this.DeleteDB.TabIndex = 5;
            this.DeleteDB.Text = "Видалити базу";
            this.DeleteDB.UseVisualStyleBackColor = true;
            this.DeleteDB.Click += new System.EventHandler(this.DeleteDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Таблиця \"Авіатрнспорт\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Таблиця \"Залізниця\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Таблиця \"Автомобільна дорога\"";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(760, 150);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(26, 445);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(760, 150);
            this.dataGridView3.TabIndex = 10;
            // 
            // GetReport
            // 
            this.GetReport.Location = new System.Drawing.Point(346, 601);
            this.GetReport.Name = "GetReport";
            this.GetReport.Size = new System.Drawing.Size(136, 23);
            this.GetReport.TabIndex = 11;
            this.GetReport.Text = "Отримати звіт";
            this.GetReport.UseVisualStyleBackColor = true;
            this.GetReport.Click += new System.EventHandler(this.GetReport_Click);
            // 
            // RefreshDG1
            // 
            this.RefreshDG1.Location = new System.Drawing.Point(508, 16);
            this.RefreshDG1.Name = "RefreshDG1";
            this.RefreshDG1.Size = new System.Drawing.Size(136, 23);
            this.RefreshDG1.TabIndex = 12;
            this.RefreshDG1.Text = "Оновити";
            this.RefreshDG1.UseVisualStyleBackColor = true;
            this.RefreshDG1.Click += new System.EventHandler(this.RefreshDG1_Click);
            // 
            // RefreshDG2
            // 
            this.RefreshDG2.Location = new System.Drawing.Point(650, 214);
            this.RefreshDG2.Name = "RefreshDG2";
            this.RefreshDG2.Size = new System.Drawing.Size(136, 23);
            this.RefreshDG2.TabIndex = 13;
            this.RefreshDG2.Text = "Оновити";
            this.RefreshDG2.UseVisualStyleBackColor = true;
            this.RefreshDG2.Click += new System.EventHandler(this.RefreshDG2_Click);
            // 
            // RefreshDG3
            // 
            this.RefreshDG3.Location = new System.Drawing.Point(650, 416);
            this.RefreshDG3.Name = "RefreshDG3";
            this.RefreshDG3.Size = new System.Drawing.Size(136, 23);
            this.RefreshDG3.TabIndex = 14;
            this.RefreshDG3.Text = "Оновити";
            this.RefreshDG3.UseVisualStyleBackColor = true;
            this.RefreshDG3.Click += new System.EventHandler(this.RefreshDG3_Click);
            // 
            // AirwayCB
            // 
            this.AirwayCB.FormattingEnabled = true;
            this.AirwayCB.Location = new System.Drawing.Point(295, 16);
            this.AirwayCB.Name = "AirwayCB";
            this.AirwayCB.Size = new System.Drawing.Size(207, 21);
            this.AirwayCB.TabIndex = 15;
            this.AirwayCB.SelectedIndexChanged += new System.EventHandler(this.AirwayCB_SelectedIndexChanged);
            // 
            // RailwayCB
            // 
            this.RailwayCB.FormattingEnabled = true;
            this.RailwayCB.Location = new System.Drawing.Point(436, 214);
            this.RailwayCB.Name = "RailwayCB";
            this.RailwayCB.Size = new System.Drawing.Size(208, 21);
            this.RailwayCB.TabIndex = 16;
            this.RailwayCB.SelectedIndexChanged += new System.EventHandler(this.RailwayCB_SelectedIndexChanged);
            // 
            // HighwayCB
            // 
            this.HighwayCB.FormattingEnabled = true;
            this.HighwayCB.Location = new System.Drawing.Point(437, 416);
            this.HighwayCB.Name = "HighwayCB";
            this.HighwayCB.Size = new System.Drawing.Size(207, 21);
            this.HighwayCB.TabIndex = 17;
            this.HighwayCB.SelectedIndexChanged += new System.EventHandler(this.HighwayCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(810, 641);
            this.Controls.Add(this.HighwayCB);
            this.Controls.Add(this.RailwayCB);
            this.Controls.Add(this.AirwayCB);
            this.Controls.Add(this.RefreshDG3);
            this.Controls.Add(this.RefreshDG2);
            this.Controls.Add(this.RefreshDG1);
            this.Controls.Add(this.GetReport);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteDB);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Db Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Tasks;
        private System.Windows.Forms.Button Operations;
        private System.Windows.Forms.Button DeleteDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button GetReport;
        private System.Windows.Forms.Button RefreshDG1;
        private System.Windows.Forms.Button RefreshDG2;
        private System.Windows.Forms.Button RefreshDG3;
        private System.Windows.Forms.ComboBox AirwayCB;
        private System.Windows.Forms.ComboBox RailwayCB;
        private System.Windows.Forms.ComboBox HighwayCB;
    }
}

