namespace BPSBank.Admin
{
    partial class Projects
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label код_заказаLabel;
            System.Windows.Forms.Label дата_созданияLabel;
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.дата_окончанияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.проектыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bPSDBDataSet = new BPSBank.BPSDBDataSet();
            this.код_заказаComboBox = new System.Windows.Forms.ComboBox();
            this.view_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фамилияComboBox = new System.Windows.Forms.ComboBox();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_2TableAdapter = new BPSBank.BPSDBDataSetTableAdapters.View_2TableAdapter();
            this.tableAdapterManager = new BPSBank.BPSDBDataSetTableAdapters.TableAdapterManager();
            this.проектыTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.ПроектыTableAdapter();
            this.сотрудникиTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.СотрудникиTableAdapter();
            this.заказTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.ЗаказTableAdapter();
            this.view_2DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            названиеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            код_заказаLabel = new System.Windows.Forms.Label();
            дата_созданияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.проектыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_2DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(25, 27);
            названиеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(77, 16);
            названиеLabel.TabIndex = 16;
            названиеLabel.Text = "Название:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(25, 68);
            описаниеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(76, 16);
            описаниеLabel.TabIndex = 17;
            описаниеLabel.Text = "Описание:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(31, 240);
            фамилияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(70, 16);
            фамилияLabel.TabIndex = 19;
            фамилияLabel.Text = "Фамилия:";
            // 
            // код_заказаLabel
            // 
            код_заказаLabel.AutoSize = true;
            код_заказаLabel.Location = new System.Drawing.Point(31, 287);
            код_заказаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            код_заказаLabel.Name = "код_заказаLabel";
            код_заказаLabel.Size = new System.Drawing.Size(104, 16);
            код_заказаLabel.TabIndex = 20;
            код_заказаLabel.Text = "Номер заказа:";
            // 
            // дата_созданияLabel
            // 
            дата_созданияLabel.AutoSize = true;
            дата_созданияLabel.Location = new System.Drawing.Point(23, 190);
            дата_созданияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дата_созданияLabel.Name = "дата_созданияLabel";
            дата_созданияLabel.Size = new System.Drawing.Size(126, 16);
            дата_созданияLabel.TabIndex = 18;
            дата_созданияLabel.Text = "Дата завершения:";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.дата_окончанияDateTimePicker);
            this.tabPage1.Controls.Add(код_заказаLabel);
            this.tabPage1.Controls.Add(this.код_заказаComboBox);
            this.tabPage1.Controls.Add(фамилияLabel);
            this.tabPage1.Controls.Add(this.фамилияComboBox);
            this.tabPage1.Controls.Add(дата_созданияLabel);
            this.tabPage1.Controls.Add(описаниеLabel);
            this.tabPage1.Controls.Add(this.описаниеTextBox);
            this.tabPage1.Controls.Add(названиеLabel);
            this.tabPage1.Controls.Add(this.названиеTextBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(693, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // дата_окончанияDateTimePicker
            // 
            this.дата_окончанияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.проектыBindingSource, "Дата_окончания", true));
            this.дата_окончанияDateTimePicker.Location = new System.Drawing.Point(156, 184);
            this.дата_окончанияDateTimePicker.Name = "дата_окончанияDateTimePicker";
            this.дата_окончанияDateTimePicker.Size = new System.Drawing.Size(508, 22);
            this.дата_окончанияDateTimePicker.TabIndex = 22;
            // 
            // проектыBindingSource
            // 
            this.проектыBindingSource.DataMember = "Проекты";
            this.проектыBindingSource.DataSource = this.bPSDBDataSet;
            // 
            // bPSDBDataSet
            // 
            this.bPSDBDataSet.DataSetName = "BPSDBDataSet";
            this.bPSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // код_заказаComboBox
            // 
            this.код_заказаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_2BindingSource, "Код_заказа", true));
            this.код_заказаComboBox.DataSource = this.заказBindingSource;
            this.код_заказаComboBox.DisplayMember = "Код_заказа";
            this.код_заказаComboBox.FormattingEnabled = true;
            this.код_заказаComboBox.Location = new System.Drawing.Point(149, 283);
            this.код_заказаComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.код_заказаComboBox.Name = "код_заказаComboBox";
            this.код_заказаComboBox.Size = new System.Drawing.Size(277, 24);
            this.код_заказаComboBox.TabIndex = 21;
            this.код_заказаComboBox.ValueMember = "Код_заказа";
            // 
            // view_2BindingSource
            // 
            this.view_2BindingSource.DataMember = "View_2";
            this.view_2BindingSource.DataSource = this.bPSDBDataSet;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.bPSDBDataSet;
            // 
            // фамилияComboBox
            // 
            this.фамилияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_2BindingSource, "Фамилия", true));
            this.фамилияComboBox.DataSource = this.сотрудникиBindingSource;
            this.фамилияComboBox.DisplayMember = "Фамилия";
            this.фамилияComboBox.FormattingEnabled = true;
            this.фамилияComboBox.Location = new System.Drawing.Point(149, 230);
            this.фамилияComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.фамилияComboBox.Name = "фамилияComboBox";
            this.фамилияComboBox.Size = new System.Drawing.Size(277, 24);
            this.фамилияComboBox.TabIndex = 20;
            this.фамилияComboBox.ValueMember = "Код_сотрудника";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.bPSDBDataSet;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_2BindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(113, 64);
            this.описаниеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(551, 115);
            this.описаниеTextBox.TabIndex = 18;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_2BindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(113, 23);
            this.названиеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(551, 22);
            this.названиеTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(20, 265);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 360);
            this.tabControl1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BPSBank.BPSDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПроектыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.УслугиTableAdapter = null;
            // 
            // проектыTableAdapter
            // 
            this.проектыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // view_2DataGridView
            // 
            this.view_2DataGridView.AutoGenerateColumns = false;
            this.view_2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.view_2DataGridView.DataSource = this.view_2BindingSource;
            this.view_2DataGridView.Location = new System.Drawing.Point(20, 38);
            this.view_2DataGridView.Name = "view_2DataGridView";
            this.view_2DataGridView.Size = new System.Drawing.Size(697, 220);
            this.view_2DataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_создания";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_создания";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код_заказа";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код_заказа";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата_окончания";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата_окончания";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(731, 638);
            this.Controls.Add(this.view_2DataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Projects";
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.проектыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_2DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private BPSDBDataSet bPSDBDataSet;
        private System.Windows.Forms.BindingSource view_2BindingSource;
        private BPSDBDataSetTableAdapters.View_2TableAdapter view_2TableAdapter;
        private BPSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox код_заказаComboBox;
        private System.Windows.Forms.ComboBox фамилияComboBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.BindingSource проектыBindingSource;
        private BPSDBDataSetTableAdapters.ПроектыTableAdapter проектыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private BPSDBDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private BPSDBDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DateTimePicker дата_окончанияDateTimePicker;
        private System.Windows.Forms.DataGridView view_2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}