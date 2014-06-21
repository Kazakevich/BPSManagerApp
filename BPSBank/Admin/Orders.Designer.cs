namespace BPSBank.Admin
{
    partial class Orders
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
            System.Windows.Forms.Label название_организацииLabel;
            System.Windows.Forms.Label видLabel;
            System.Windows.Forms.Label дата_регистрацииLabel;
            System.Windows.Forms.Label статусLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.видComboBox = new System.Windows.Forms.ComboBox();
            this.view_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bPSDBDataSet = new BPSBank.BPSDBDataSet();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.название_организацииComboBox = new System.Windows.Forms.ComboBox();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статусCheckBox = new System.Windows.Forms.CheckBox();
            this.дата_регистрацииDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.view_1TableAdapter = new BPSBank.BPSDBDataSetTableAdapters.View_1TableAdapter();
            this.tableAdapterManager = new BPSBank.BPSDBDataSetTableAdapters.TableAdapterManager();
            this.view_1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.ЗаказTableAdapter();
            this.услугиTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.УслугиTableAdapter();
            this.клиентTableAdapter = new BPSBank.BPSDBDataSetTableAdapters.КлиентTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            название_организацииLabel = new System.Windows.Forms.Label();
            видLabel = new System.Windows.Forms.Label();
            дата_регистрацииLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // название_организацииLabel
            // 
            название_организацииLabel.AutoSize = true;
            название_организацииLabel.Location = new System.Drawing.Point(6, 12);
            название_организацииLabel.Name = "название_организацииLabel";
            название_организацииLabel.Size = new System.Drawing.Size(166, 16);
            название_организацииLabel.TabIndex = 10;
            название_организацииLabel.Text = "Название организации:";
            // 
            // видLabel
            // 
            видLabel.AutoSize = true;
            видLabel.Location = new System.Drawing.Point(8, 42);
            видLabel.Name = "видLabel";
            видLabel.Size = new System.Drawing.Size(36, 16);
            видLabel.TabIndex = 11;
            видLabel.Text = "Вид:";
            // 
            // дата_регистрацииLabel
            // 
            дата_регистрацииLabel.AutoSize = true;
            дата_регистрацииLabel.Location = new System.Drawing.Point(8, 76);
            дата_регистрацииLabel.Name = "дата_регистрацииLabel";
            дата_регистрацииLabel.Size = new System.Drawing.Size(130, 16);
            дата_регистрацииLabel.TabIndex = 12;
            дата_регистрацииLabel.Text = "Дата регистрации:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(8, 134);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(57, 16);
            статусLabel.TabIndex = 13;
            статусLabel.Text = "Статус:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 226);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(299, 235);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.видComboBox);
            this.tabPage1.Controls.Add(this.название_организацииComboBox);
            this.tabPage1.Controls.Add(статусLabel);
            this.tabPage1.Controls.Add(this.статусCheckBox);
            this.tabPage1.Controls.Add(дата_регистрацииLabel);
            this.tabPage1.Controls.Add(this.дата_регистрацииDateTimePicker);
            this.tabPage1.Controls.Add(видLabel);
            this.tabPage1.Controls.Add(название_организацииLabel);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(291, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // видComboBox
            // 
            this.видComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Вид", true));
            this.видComboBox.DataSource = this.услугиBindingSource;
            this.видComboBox.DisplayMember = "Вид";
            this.видComboBox.FormattingEnabled = true;
            this.видComboBox.Location = new System.Drawing.Point(52, 39);
            this.видComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.видComboBox.Name = "видComboBox";
            this.видComboBox.Size = new System.Drawing.Size(226, 24);
            this.видComboBox.TabIndex = 16;
            this.видComboBox.ValueMember = "Код_услуги";
            // 
            // view_1BindingSource
            // 
            this.view_1BindingSource.DataMember = "View_1";
            this.view_1BindingSource.DataSource = this.bPSDBDataSet;
            // 
            // bPSDBDataSet
            // 
            this.bPSDBDataSet.DataSetName = "BPSDBDataSet";
            this.bPSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.bPSDBDataSet;
            // 
            // название_организацииComboBox
            // 
            this.название_организацииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_1BindingSource, "Название_организации", true));
            this.название_организацииComboBox.DataSource = this.клиентBindingSource;
            this.название_организацииComboBox.DisplayMember = "Название_организации";
            this.название_организацииComboBox.FormattingEnabled = true;
            this.название_организацииComboBox.Location = new System.Drawing.Point(171, 10);
            this.название_организацииComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.название_организацииComboBox.Name = "название_организацииComboBox";
            this.название_организацииComboBox.Size = new System.Drawing.Size(108, 24);
            this.название_организацииComboBox.TabIndex = 15;
            this.название_организацииComboBox.ValueMember = "Код_клиента";
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.bPSDBDataSet;
            // 
            // статусCheckBox
            // 
            this.статусCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.view_1BindingSource, "Статус", true));
            this.статусCheckBox.Location = new System.Drawing.Point(72, 134);
            this.статусCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.статусCheckBox.Name = "статусCheckBox";
            this.статусCheckBox.Size = new System.Drawing.Size(144, 19);
            this.статусCheckBox.TabIndex = 14;
            this.статусCheckBox.Text = "Готов\\Не готов";
            this.статусCheckBox.UseVisualStyleBackColor = true;
            // 
            // дата_регистрацииDateTimePicker
            // 
            this.дата_регистрацииDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.view_1BindingSource, "Дата_регистрации", true));
            this.дата_регистрацииDateTimePicker.Location = new System.Drawing.Point(12, 94);
            this.дата_регистрацииDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.дата_регистрацииDateTimePicker.Name = "дата_регистрацииDateTimePicker";
            this.дата_регистрацииDateTimePicker.Size = new System.Drawing.Size(267, 22);
            this.дата_регистрацииDateTimePicker.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(293, 203);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 50);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "Сортировка по убыванию";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сортировка по возрастанию";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(317, 230);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(301, 232);
            this.tabControl2.TabIndex = 4;
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
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
            // view_1DataGridView
            // 
            this.view_1DataGridView.AutoGenerateColumns = false;
            this.view_1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.view_1DataGridView.DataSource = this.view_1BindingSource;
            this.view_1DataGridView.Location = new System.Drawing.Point(7, 28);
            this.view_1DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_1DataGridView.Name = "view_1DataGridView";
            this.view_1DataGridView.Size = new System.Drawing.Size(607, 196);
            this.view_1DataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название_организации";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название_организации";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вид";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата_регистрации";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата_регистрации";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Статус";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Статус";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.bPSDBDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click_1);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 482);
            this.Controls.Add(this.view_1DataGridView);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orders";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPSDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private BPSDBDataSet bPSDBDataSet;
        private System.Windows.Forms.BindingSource view_1BindingSource;
        private BPSDBDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private BPSDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox статусCheckBox;
        private System.Windows.Forms.DateTimePicker дата_регистрацииDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView view_1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox видComboBox;
        private System.Windows.Forms.ComboBox название_организацииComboBox;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private BPSDBDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private BPSDBDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private BPSDBDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}