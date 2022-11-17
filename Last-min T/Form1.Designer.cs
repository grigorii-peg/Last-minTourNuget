namespace Last_min_Tour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.TourGridView = new System.Windows.Forms.DataGridView();
            this.DirectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfNightsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostVacationerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfVacationersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WiFiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurchargesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCostAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NumberOfToursStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalCostStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberOfToursWithSurchargesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalCostSurchargesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.AboutProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(49, 20);
            this.File.Text = "Файл";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(111, 22);
            this.ExitMenuItem.Text = "Выход";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.EditMenuItem,
            this.toolStripSeparator1,
            this.DeleteMenuItem});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(58, 20);
            this.Edit.Text = "Правка";
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AddMenuItem.Text = "Добавить";
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Enabled = false;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(128, 22);
            this.EditMenuItem.Text = "Изменить";
            this.EditMenuItem.Click += new System.EventHandler(this.ChangeMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Enabled = false;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteMenuItem.Text = "Удалить";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeliteMenu_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoMenuItem});
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(91, 20);
            this.AboutProgram.Text = "О программе";
            // 
            // InfoMenuItem
            // 
            this.InfoMenuItem.Name = "InfoMenuItem";
            this.InfoMenuItem.Size = new System.Drawing.Size(105, 22);
            this.InfoMenuItem.Text = "Инфо";
            this.InfoMenuItem.Click += new System.EventHandler(this.InfoMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripButton,
            this.EditStripButton,
            this.toolStripSeparator2,
            this.DeleteStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddStripButton
            // 
            this.AddStripButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.AddStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStripButton.Image")));
            this.AddStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddStripButton.Name = "AddStripButton";
            this.AddStripButton.Size = new System.Drawing.Size(81, 22);
            this.AddStripButton.Text = "Добавить";
            this.AddStripButton.Click += new System.EventHandler(this.AddStripButton_Click);
            // 
            // EditStripButton
            // 
            this.EditStripButton.Enabled = false;
            this.EditStripButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EditStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditStripButton.Image")));
            this.EditStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditStripButton.Name = "EditStripButton";
            this.EditStripButton.Size = new System.Drawing.Size(81, 22);
            this.EditStripButton.Text = "Изменить";
            this.EditStripButton.Click += new System.EventHandler(this.EditStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteStripButton
            // 
            this.DeleteStripButton.Enabled = false;
            this.DeleteStripButton.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteStripButton.Image")));
            this.DeleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteStripButton.Name = "DeleteStripButton";
            this.DeleteStripButton.Size = new System.Drawing.Size(74, 22);
            this.DeleteStripButton.Text = "Удалить";
            this.DeleteStripButton.Click += new System.EventHandler(this.DeleteStripButton_Click);
            // 
            // TourGridView
            // 
            this.TourGridView.AllowUserToAddRows = false;
            this.TourGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TourGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TourGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TourGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TourGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TourGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirectionColumn,
            this.DepartureColumn,
            this.NumberOfNightsColumn,
            this.CostVacationerColumn,
            this.NumberOfVacationersColumn,
            this.WiFiColumn,
            this.SurchargesColumn,
            this.TotalCostAmountColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TourGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.TourGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TourGridView.Location = new System.Drawing.Point(0, 49);
            this.TourGridView.MultiSelect = false;
            this.TourGridView.Name = "TourGridView";
            this.TourGridView.ReadOnly = true;
            this.TourGridView.Size = new System.Drawing.Size(800, 401);
            this.TourGridView.TabIndex = 2;
            this.TourGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TourGridView_CellFormatting);
            this.TourGridView.SelectionChanged += new System.EventHandler(this.TourGridView_SelectionChanged);
            // 
            // DirectionColumn
            // 
            this.DirectionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirectionColumn.DataPropertyName = "Direction";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectionColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DirectionColumn.HeaderText = "Направление";
            this.DirectionColumn.Name = "DirectionColumn";
            this.DirectionColumn.ReadOnly = true;
            // 
            // DepartureColumn
            // 
            this.DepartureColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DepartureColumn.DataPropertyName = "Departure";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DepartureColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DepartureColumn.HeaderText = "Дата вылета";
            this.DepartureColumn.Name = "DepartureColumn";
            this.DepartureColumn.ReadOnly = true;
            // 
            // NumberOfNightsColumn
            // 
            this.NumberOfNightsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberOfNightsColumn.DataPropertyName = "NumberOfNights";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfNightsColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.NumberOfNightsColumn.HeaderText = "Кол-во ночей";
            this.NumberOfNightsColumn.Name = "NumberOfNightsColumn";
            this.NumberOfNightsColumn.ReadOnly = true;
            // 
            // CostVacationerColumn
            // 
            this.CostVacationerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostVacationerColumn.DataPropertyName = "CostVacationer";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostVacationerColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.CostVacationerColumn.HeaderText = "Стоимость за отдыхающего";
            this.CostVacationerColumn.Name = "CostVacationerColumn";
            this.CostVacationerColumn.ReadOnly = true;
            // 
            // NumberOfVacationersColumn
            // 
            this.NumberOfVacationersColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberOfVacationersColumn.DataPropertyName = "NumberOfVacationers";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfVacationersColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.NumberOfVacationersColumn.HeaderText = "Кол-во отдыхающих";
            this.NumberOfVacationersColumn.Name = "NumberOfVacationersColumn";
            this.NumberOfVacationersColumn.ReadOnly = true;
            // 
            // WiFiColumn
            // 
            this.WiFiColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WiFiColumn.DataPropertyName = "WiFi";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WiFiColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.WiFiColumn.HeaderText = "Наличие Wi-Fi";
            this.WiFiColumn.Name = "WiFiColumn";
            this.WiFiColumn.ReadOnly = true;
            // 
            // SurchargesColumn
            // 
            this.SurchargesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SurchargesColumn.DataPropertyName = "Surcharges";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurchargesColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.SurchargesColumn.HeaderText = "Доплаты";
            this.SurchargesColumn.Name = "SurchargesColumn";
            this.SurchargesColumn.ReadOnly = true;
            // 
            // TotalCostAmountColumn
            // 
            this.TotalCostAmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalCostAmountColumn.DataPropertyName = "TotalCostAmount";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalCostAmountColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.TotalCostAmountColumn.HeaderText = "Общая стоимость";
            this.TotalCostAmountColumn.Name = "TotalCostAmountColumn";
            this.TotalCostAmountColumn.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NumberOfToursStatus,
            this.TotalCostStatus,
            this.NumberOfToursWithSurchargesStatus,
            this.TotalCostSurchargesStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NumberOfToursStatus
            // 
            this.NumberOfToursStatus.Name = "NumberOfToursStatus";
            this.NumberOfToursStatus.Size = new System.Drawing.Size(96, 17);
            this.NumberOfToursStatus.Text = "Кол-во туров: 0";
            // 
            // TotalCostStatus
            // 
            this.TotalCostStatus.Name = "TotalCostStatus";
            this.TotalCostStatus.Size = new System.Drawing.Size(94, 17);
            this.TotalCostStatus.Text = "Общая сумма: 0";
            // 
            // NumberOfToursWithSurchargesStatus
            // 
            this.NumberOfToursWithSurchargesStatus.Name = "NumberOfToursWithSurchargesStatus";
            this.NumberOfToursWithSurchargesStatus.Size = new System.Drawing.Size(170, 17);
            this.NumberOfToursWithSurchargesStatus.Text = "Кол-во туров с доплатами: 0";
            // 
            // TotalCostSurchargesStatus
            // 
            this.TotalCostSurchargesStatus.Name = "TotalCostSurchargesStatus";
            this.TotalCostSurchargesStatus.Size = new System.Drawing.Size(138, 17);
            this.TotalCostSurchargesStatus.Text = "Общая сумма доплат: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TourGridView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Горящие туры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.ToolStripMenuItem InfoMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddStripButton;
        private System.Windows.Forms.ToolStripButton EditStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeleteStripButton;
        private System.Windows.Forms.DataGridView TourGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NumberOfToursStatus;
        private System.Windows.Forms.ToolStripStatusLabel TotalCostStatus;
        private System.Windows.Forms.ToolStripStatusLabel NumberOfToursWithSurchargesStatus;
        private System.Windows.Forms.ToolStripStatusLabel TotalCostSurchargesStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfNightsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostVacationerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfVacationersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WiFiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurchargesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCostAmountColumn;
    }
}

