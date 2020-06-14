namespace Task8_3_WinForms_
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
            this.addVertexButton = new System.Windows.Forms.Button();
            this.vertexDataGridView = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vertexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ribDataGridView = new System.Windows.Forms.DataGridView();
            this.ribNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRibButton = new System.Windows.Forms.Button();
            this.vertexLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.graphTextBox = new System.Windows.Forms.TextBox();
            this.vertexTextBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVertexMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRibMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testNextButton = new System.Windows.Forms.Button();
            this.testStopButton = new System.Windows.Forms.Button();
            this.запуститьГенераторТестовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.vertexDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addVertexButton
            // 
            this.addVertexButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addVertexButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.addVertexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVertexButton.Location = new System.Drawing.Point(13, 440);
            this.addVertexButton.Name = "addVertexButton";
            this.addVertexButton.Size = new System.Drawing.Size(203, 59);
            this.addVertexButton.TabIndex = 0;
            this.addVertexButton.Text = "Добавить вершину";
            this.addVertexButton.UseVisualStyleBackColor = false;
            this.addVertexButton.Click += new System.EventHandler(this.addVertexButton_Click);
            // 
            // vertexDataGridView
            // 
            this.vertexDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vertexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vertexDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.vertexColumn});
            this.vertexDataGridView.Location = new System.Drawing.Point(13, 89);
            this.vertexDataGridView.Name = "vertexDataGridView";
            this.vertexDataGridView.Size = new System.Drawing.Size(203, 284);
            this.vertexDataGridView.TabIndex = 1;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.number.HeaderText = "№";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 43;
            // 
            // vertexColumn
            // 
            this.vertexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vertexColumn.HeaderText = "Список вершин";
            this.vertexColumn.Name = "vertexColumn";
            this.vertexColumn.ReadOnly = true;
            // 
            // ribDataGridView
            // 
            this.ribDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ribDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ribDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ribNumber,
            this.dataGridViewTextBoxColumn1});
            this.ribDataGridView.Location = new System.Drawing.Point(239, 89);
            this.ribDataGridView.Name = "ribDataGridView";
            this.ribDataGridView.Size = new System.Drawing.Size(262, 284);
            this.ribDataGridView.TabIndex = 2;
            // 
            // ribNumber
            // 
            this.ribNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ribNumber.HeaderText = "№";
            this.ribNumber.Name = "ribNumber";
            this.ribNumber.ReadOnly = true;
            this.ribNumber.Width = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Список Ребер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addRibButton
            // 
            this.addRibButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addRibButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.addRibButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addRibButton.Location = new System.Drawing.Point(239, 440);
            this.addRibButton.Name = "addRibButton";
            this.addRibButton.Size = new System.Drawing.Size(262, 59);
            this.addRibButton.TabIndex = 3;
            this.addRibButton.Text = "Добавить ребро";
            this.addRibButton.UseVisualStyleBackColor = false;
            this.addRibButton.Click += new System.EventHandler(this.addRibButton_Click);
            // 
            // vertexLabel
            // 
            this.vertexLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vertexLabel.AutoSize = true;
            this.vertexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertexLabel.Location = new System.Drawing.Point(231, 388);
            this.vertexLabel.Name = "vertexLabel";
            this.vertexLabel.Size = new System.Drawing.Size(276, 46);
            this.vertexLabel.TabIndex = 4;
            this.vertexLabel.Text = "(         ;         )";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 45);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(377, 393);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 45);
            this.comboBox2.TabIndex = 6;
            // 
            // graphTextBox
            // 
            this.graphTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.graphTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphTextBox.Location = new System.Drawing.Point(537, 89);
            this.graphTextBox.Multiline = true;
            this.graphTextBox.Name = "graphTextBox";
            this.graphTextBox.ReadOnly = true;
            this.graphTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.graphTextBox.Size = new System.Drawing.Size(240, 326);
            this.graphTextBox.TabIndex = 7;
            this.graphTextBox.WordWrap = false;
            // 
            // vertexTextBox
            // 
            this.vertexTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.vertexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vertexTextBox.Location = new System.Drawing.Point(13, 392);
            this.vertexTextBox.Multiline = true;
            this.vertexTextBox.Name = "vertexTextBox";
            this.vertexTextBox.Size = new System.Drawing.Size(203, 42);
            this.vertexTextBox.TabIndex = 8;
            // 
            // countButton
            // 
            this.countButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.countButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.countButton.Location = new System.Drawing.Point(556, 421);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(198, 78);
            this.countButton.TabIndex = 9;
            this.countButton.Text = "Посчитать кол-во компонент связности";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenuItem,
            this.удалитьToolStripMenuItem,
            this.запуститьГенераторТестовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(115, 20);
            this.clearMenuItem.Text = "Очистить данные";
            this.clearMenuItem.Click += new System.EventHandler(this.clearMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteVertexMenuItem,
            this.deleteRibMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // deleteVertexMenuItem
            // 
            this.deleteVertexMenuItem.Name = "deleteVertexMenuItem";
            this.deleteVertexMenuItem.Size = new System.Drawing.Size(198, 22);
            this.deleteVertexMenuItem.Text = "Выделенную вершину";
            this.deleteVertexMenuItem.Click += new System.EventHandler(this.deleteVertexMenuItem_Click);
            // 
            // deleteRibMenuItem
            // 
            this.deleteRibMenuItem.Name = "deleteRibMenuItem";
            this.deleteRibMenuItem.Size = new System.Drawing.Size(198, 22);
            this.deleteRibMenuItem.Text = "Выделенное ребро";
            this.deleteRibMenuItem.Click += new System.EventHandler(this.deleteRibMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Список вершин";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Список ребер";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(520, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Матрица смежности";
            // 
            // testNextButton
            // 
            this.testNextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.testNextButton.BackColor = System.Drawing.Color.PaleGreen;
            this.testNextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.testNextButton.Location = new System.Drawing.Point(396, 513);
            this.testNextButton.Name = "testNextButton";
            this.testNextButton.Size = new System.Drawing.Size(262, 59);
            this.testNextButton.TabIndex = 14;
            this.testNextButton.Text = "Следующий тест";
            this.testNextButton.UseVisualStyleBackColor = false;
            this.testNextButton.Visible = false;
            this.testNextButton.Click += new System.EventHandler(this.testNextButton_Click);
            // 
            // testStopButton
            // 
            this.testStopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.testStopButton.BackColor = System.Drawing.Color.LightCoral;
            this.testStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.testStopButton.Location = new System.Drawing.Point(93, 513);
            this.testStopButton.Name = "testStopButton";
            this.testStopButton.Size = new System.Drawing.Size(262, 59);
            this.testStopButton.TabIndex = 15;
            this.testStopButton.Text = "Остановить тестирование";
            this.testStopButton.UseVisualStyleBackColor = false;
            this.testStopButton.Visible = false;
            this.testStopButton.Click += new System.EventHandler(this.testStopButton_Click);
            // 
            // запуститьГенераторТестовToolStripMenuItem
            // 
            this.запуститьГенераторТестовToolStripMenuItem.Name = "запуститьГенераторТестовToolStripMenuItem";
            this.запуститьГенераторТестовToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.запуститьГенераторТестовToolStripMenuItem.Text = "Запустить генератор тестов";
            this.запуститьГенераторТестовToolStripMenuItem.Click += new System.EventHandler(this.запуститьГенераторТестовToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.testStopButton);
            this.Controls.Add(this.testNextButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.vertexTextBox);
            this.Controls.Add(this.graphTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vertexLabel);
            this.Controls.Add(this.addRibButton);
            this.Controls.Add(this.ribDataGridView);
            this.Controls.Add(this.vertexDataGridView);
            this.Controls.Add(this.addVertexButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vertexDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVertexButton;
        private System.Windows.Forms.DataGridView vertexDataGridView;
        private System.Windows.Forms.DataGridView ribDataGridView;
        private System.Windows.Forms.Button addRibButton;
        private System.Windows.Forms.Label vertexLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox graphTextBox;
        private System.Windows.Forms.TextBox vertexTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVertexMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRibMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn vertexColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ribNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button testNextButton;
        private System.Windows.Forms.Button testStopButton;
        private System.Windows.Forms.ToolStripMenuItem запуститьГенераторТестовToolStripMenuItem;
    }
}

