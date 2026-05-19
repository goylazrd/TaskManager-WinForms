namespace TaskManager
{
    partial class MainForm
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

      //#region Windows Form Designer generated code
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnActionAdd = new System.Windows.Forms.Button();
            this.btnActionEdit = new System.Windows.Forms.Button();
            this.BtnActionRemove = new System.Windows.Forms.Button();
            this.checkBoxIsCompleted = new System.Windows.Forms.CheckBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.groupBoxTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnActionAdd
            // 
            this.BtnActionAdd.BackColor = System.Drawing.Color.LightGreen;
            this.BtnActionAdd.Location = new System.Drawing.Point(11, 36);
            this.BtnActionAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActionAdd.Name = "BtnActionAdd";
            this.BtnActionAdd.Size = new System.Drawing.Size(136, 61);
            this.BtnActionAdd.TabIndex = 0;
            this.BtnActionAdd.Text = "Добавить";
            this.BtnActionAdd.UseVisualStyleBackColor = false;
            this.BtnActionAdd.Click += new System.EventHandler(this.BtnActionAdd_Click);
            // 
            // btnActionEdit
            // 
            this.btnActionEdit.Location = new System.Drawing.Point(11, 110);
            this.btnActionEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnActionEdit.Name = "btnActionEdit";
            this.btnActionEdit.Size = new System.Drawing.Size(136, 54);
            this.btnActionEdit.TabIndex = 1;
            this.btnActionEdit.Text = "Редактировать";
            this.btnActionEdit.UseVisualStyleBackColor = true;
            this.btnActionEdit.Click += new System.EventHandler(this.BtnActionEdit_Click);
            // 
            // BtnActionRemove
            // 
            this.BtnActionRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnActionRemove.Location = new System.Drawing.Point(11, 180);
            this.BtnActionRemove.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActionRemove.Name = "BtnActionRemove";
            this.BtnActionRemove.Size = new System.Drawing.Size(136, 54);
            this.BtnActionRemove.TabIndex = 2;
            this.BtnActionRemove.Text = "Удалить";
            this.BtnActionRemove.UseVisualStyleBackColor = false;
            this.BtnActionRemove.Click += new System.EventHandler(this.BtnActionRemove_Click);
            // 
            // checkBoxIsCompleted
            // 
            this.checkBoxIsCompleted.AutoSize = true;
            this.checkBoxIsCompleted.Location = new System.Drawing.Point(111, 220);
            this.checkBoxIsCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIsCompleted.Name = "checkBoxIsCompleted";
            this.checkBoxIsCompleted.Size = new System.Drawing.Size(83, 17);
            this.checkBoxIsCompleted.TabIndex = 4;
            this.checkBoxIsCompleted.Text = "Выполнено";
            this.checkBoxIsCompleted.UseVisualStyleBackColor = true;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(111, 186);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPriority.TabIndex = 5;
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Description,
            this.DueDate,
            this.Priority,
            this.IsCompleted});
            this.dataGridViewTasks.Location = new System.Drawing.Point(168, 36);
            this.dataGridViewTasks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 62;
            this.dataGridViewTasks.RowTemplate.Height = 28;
            this.dataGridViewTasks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(792, 250);
            this.dataGridViewTasks.TabIndex = 4;
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTasks.Controls.Add(this.label6);
            this.groupBoxTasks.Controls.Add(this.label5);
            this.groupBoxTasks.Controls.Add(this.label4);
            this.groupBoxTasks.Controls.Add(this.label3);
            this.groupBoxTasks.Controls.Add(this.label2);
            this.groupBoxTasks.Controls.Add(this.richTextBoxDescription);
            this.groupBoxTasks.Controls.Add(this.textBoxTaskName);
            this.groupBoxTasks.Controls.Add(this.dateTimePickerDueDate);
            this.groupBoxTasks.Controls.Add(this.checkBoxIsCompleted);
            this.groupBoxTasks.Controls.Add(this.comboBoxPriority);
            this.groupBoxTasks.Location = new System.Drawing.Point(168, 300);
            this.groupBoxTasks.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTasks.Size = new System.Drawing.Size(792, 251);
            this.groupBoxTasks.TabIndex = 3;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Описание задачи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выполнено?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Важность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(111, 68);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(631, 64);
            this.richTextBoxDescription.TabIndex = 8;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTaskName.Location = new System.Drawing.Point(111, 27);
            this.textBoxTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(631, 20);
            this.textBoxTaskName.TabIndex = 7;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(111, 151);
            this.dateTimePickerDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDueDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список задач";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(29, 518);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(118, 33);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHelp.Location = new System.Drawing.Point(29, 468);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(118, 33);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Название";
            this.TaskName.MinimumWidth = 8;
            this.TaskName.Name = "TaskName";
            this.TaskName.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 250;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Дата";
            this.DueDate.MinimumWidth = 8;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 150;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Важность";
            this.Priority.MinimumWidth = 8;
            this.Priority.Name = "Priority";
            // 
            // IsCompleted
            // 
            this.IsCompleted.DataPropertyName = "IsCompleted";
            this.IsCompleted.HeaderText = "Выполнено";
            this.IsCompleted.MinimumWidth = 8;
            this.IsCompleted.Name = "IsCompleted";
            this.IsCompleted.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.groupBoxTasks);
            this.Controls.Add(this.BtnActionRemove);
            this.Controls.Add(this.btnActionEdit);
            this.Controls.Add(this.BtnActionAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TaskManager - Управление задачами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.groupBoxTasks.ResumeLayout(false);
            this.groupBoxTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button BtnActionAdd;
        private System.Windows.Forms.Button BtnActionRemove;
        private System.Windows.Forms.Button btnActionEdit;
        private System.Windows.Forms.CheckBox checkBoxIsCompleted;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCompleted;
    }
}

