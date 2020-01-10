namespace JustTry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.coursework2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_work_2DataSet = new JustTry.course_work_2DataSet();
            this.dataSet11 = new JustTry.DataSet1();
            this.dataSet21 = new JustTry.DataSet2();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsTableAdapter = new JustTry.course_work_2DataSetTableAdapters.DetailsTableAdapter();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new JustTry.course_work_2DataSetTableAdapters.SectorsTableAdapter();
            this.programOfProductionGridView = new System.Windows.Forms.DataGridView();
            this.programOfProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programOfProductionTableAdapter = new JustTry.course_work_2DataSetTableAdapters.ProgramOfProductionTableAdapter();
            this.CurrentTable = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альтернативнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.SectorsButton = new System.Windows.Forms.Button();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.ProgramOfProductionButton = new System.Windows.Forms.Button();
            this.задача3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.coursework2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_work_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programOfProductionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programOfProductionBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(848, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // coursework2DataSetBindingSource
            // 
            this.coursework2DataSetBindingSource.DataSource = this.course_work_2DataSet;
            this.coursework2DataSetBindingSource.Position = 0;
            // 
            // course_work_2DataSet
            // 
            this.course_work_2DataSet.DataSetName = "course_work_2DataSet";
            this.course_work_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.coursework2DataSetBindingSource;
            this.detailsBindingSource.CurrentChanged += new System.EventHandler(this.detailsBindingSource_CurrentChanged);
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.course_work_2DataSet;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // programOfProductionGridView
            // 
            this.programOfProductionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programOfProductionGridView.Location = new System.Drawing.Point(12, 58);
            this.programOfProductionGridView.Name = "programOfProductionGridView";
            this.programOfProductionGridView.RowTemplate.Height = 24;
            this.programOfProductionGridView.Size = new System.Drawing.Size(808, 318);
            this.programOfProductionGridView.TabIndex = 10;
            this.programOfProductionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.programOfProductionGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // programOfProductionBindingSource
            // 
            this.programOfProductionBindingSource.DataMember = "ProgramOfProduction";
            this.programOfProductionBindingSource.DataSource = this.course_work_2DataSet;
            // 
            // programOfProductionTableAdapter
            // 
            this.programOfProductionTableAdapter.ClearBeforeFill = true;
            // 
            // CurrentTable
            // 
            this.CurrentTable.AutoSize = true;
            this.CurrentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentTable.Location = new System.Drawing.Point(393, 28);
            this.CurrentTable.Name = "CurrentTable";
            this.CurrentTable.Size = new System.Drawing.Size(167, 29);
            this.CurrentTable.TabIndex = 11;
            this.CurrentTable.Text = "CurrentTable";
            this.CurrentTable.Click += new System.EventHandler(this.Table1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Location = new System.Drawing.Point(848, 145);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 41);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основнаяToolStripMenuItem,
            this.альтернативнаяToolStripMenuItem,
            this.Task2ToolStripMenuItem,
            this.задача3ToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // основнаяToolStripMenuItem
            // 
            this.основнаяToolStripMenuItem.Name = "основнаяToolStripMenuItem";
            this.основнаяToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.основнаяToolStripMenuItem.Text = "Основная";
            // 
            // альтернативнаяToolStripMenuItem
            // 
            this.альтернативнаяToolStripMenuItem.Name = "альтернативнаяToolStripMenuItem";
            this.альтернативнаяToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.альтернативнаяToolStripMenuItem.Text = "Задача 1";
            this.альтернативнаяToolStripMenuItem.Click += new System.EventHandler(this.альтернативнаяToolStripMenuItem_Click);
            // 
            // Task2ToolStripMenuItem
            // 
            this.Task2ToolStripMenuItem.Name = "Task2ToolStripMenuItem";
            this.Task2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.Task2ToolStripMenuItem.Text = "Задача 2";
            this.Task2ToolStripMenuItem.Click += new System.EventHandler(this.задача2ToolStripMenuItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.programOfProductionBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 28);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1016, 27);
            this.bindingNavigator1.TabIndex = 8;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SectorsButton
            // 
            this.SectorsButton.Location = new System.Drawing.Point(12, 457);
            this.SectorsButton.Name = "SectorsButton";
            this.SectorsButton.Size = new System.Drawing.Size(216, 57);
            this.SectorsButton.TabIndex = 17;
            this.SectorsButton.Text = "Секторы";
            this.SectorsButton.UseVisualStyleBackColor = true;
            this.SectorsButton.Click += new System.EventHandler(this.SectorsButton_Click);
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(254, 457);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(250, 57);
            this.DetailsButton.TabIndex = 18;
            this.DetailsButton.Text = "Детали";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // ProgramOfProductionButton
            // 
            this.ProgramOfProductionButton.Location = new System.Drawing.Point(534, 457);
            this.ProgramOfProductionButton.Name = "ProgramOfProductionButton";
            this.ProgramOfProductionButton.Size = new System.Drawing.Size(235, 57);
            this.ProgramOfProductionButton.TabIndex = 19;
            this.ProgramOfProductionButton.Text = "Программа производства";
            this.ProgramOfProductionButton.UseVisualStyleBackColor = true;
            this.ProgramOfProductionButton.Click += new System.EventHandler(this.ProgramOfProductionButton_Click);
            // 
            // задача3ToolStripMenuItem
            // 
            this.задача3ToolStripMenuItem.Name = "задача3ToolStripMenuItem";
            this.задача3ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.задача3ToolStripMenuItem.Text = "Задача 3";
            this.задача3ToolStripMenuItem.Click += new System.EventHandler(this.задача3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 571);
            this.Controls.Add(this.ProgramOfProductionButton);
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.SectorsButton);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.CurrentTable);
            this.Controls.Add(this.programOfProductionGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSave);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursework2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_work_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programOfProductionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programOfProductionBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource coursework2DataSetBindingSource;
        private course_work_2DataSet course_work_2DataSet;
        private DataSet1 dataSet11;
        private DataSet2 dataSet21;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private course_work_2DataSetTableAdapters.DetailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private course_work_2DataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.DataGridView programOfProductionGridView;
        private System.Windows.Forms.BindingSource programOfProductionBindingSource;
        private course_work_2DataSetTableAdapters.ProgramOfProductionTableAdapter programOfProductionTableAdapter;
        private System.Windows.Forms.Label CurrentTable;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альтернативнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Button SectorsButton;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Button ProgramOfProductionButton;
        private System.Windows.Forms.ToolStripMenuItem Task2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задача3ToolStripMenuItem;
    }
}

