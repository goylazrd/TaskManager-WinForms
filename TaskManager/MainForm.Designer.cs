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
            this.components = new System.ComponentModel.Container();
            this.BtnActionAdd = new System.Windows.Forms.Button();
            this.btnActionEdit = new System.Windows.Forms.Button();
            this.BtnActionRemove = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxFiltration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSortby = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.checkBoxIsCompleted = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.taskItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.groupBoxTasks.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnActionAdd
            // 
            this.BtnActionAdd.BackColor = System.Drawing.Color.LightGreen;
            this.BtnActionAdd.Location = new System.Drawing.Point(13, 42);
            this.BtnActionAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActionAdd.Name = "BtnActionAdd";
            this.BtnActionAdd.Size = new System.Drawing.Size(159, 70);
            this.BtnActionAdd.TabIndex = 0;
            this.BtnActionAdd.Text = "Добавить";
            this.BtnActionAdd.UseVisualStyleBackColor = false;
            this.BtnActionAdd.Click += new System.EventHandler(this.BtnActionAdd_Click);
            // 
            // btnActionEdit
            // 
            this.btnActionEdit.Location = new System.Drawing.Point(13, 127);
            this.btnActionEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnActionEdit.Name = "btnActionEdit";
            this.btnActionEdit.Size = new System.Drawing.Size(159, 62);
            this.btnActionEdit.TabIndex = 1;
            this.btnActionEdit.Text = "Редактировать";
            this.btnActionEdit.UseVisualStyleBackColor = true;
            this.btnActionEdit.Click += new System.EventHandler(this.BtnActionEdit_Click);
            // 
            // BtnActionRemove
            // 
            this.BtnActionRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnActionRemove.Location = new System.Drawing.Point(13, 208);
            this.BtnActionRemove.Margin = new System.Windows.Forms.Padding(2);
            this.BtnActionRemove.Name = "BtnActionRemove";
            this.BtnActionRemove.Size = new System.Drawing.Size(159, 62);
            this.BtnActionRemove.TabIndex = 2;
            this.BtnActionRemove.Text = "Удалить";
            this.BtnActionRemove.UseVisualStyleBackColor = false;
            this.BtnActionRemove.Click += new System.EventHandler(this.BtnActionRemove_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Description,
            this.DueDate,
            this.Priority,
            this.IsCompleted});
            this.dataGridViewTasks.Location = new System.Drawing.Point(196, 26);
            this.dataGridViewTasks.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.RowHeadersWidth = 62;
            this.dataGridViewTasks.RowTemplate.Height = 28;
            this.dataGridViewTasks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.Size = new System.Drawing.Size(808, 288);
            this.dataGridViewTasks.TabIndex = 4;
            // 
            // TaskName
            // 
            this.TaskName.DataPropertyName = "TaskName";
            this.TaskName.HeaderText = "Название";
            this.TaskName.MinimumWidth = 8;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 250;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "Дата";
            this.DueDate.MinimumWidth = 8;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 150;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Важность";
            this.Priority.MinimumWidth = 8;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // IsCompleted
            // 
            this.IsCompleted.DataPropertyName = "IsCompleted";
            this.IsCompleted.HeaderText = "Выполнено";
            this.IsCompleted.MinimumWidth = 8;
            this.IsCompleted.Name = "IsCompleted";
            this.IsCompleted.ReadOnly = true;
            this.IsCompleted.Width = 80;
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTasks.Controls.Add(this.label5);
            this.groupBoxTasks.Controls.Add(this.label4);
            this.groupBoxTasks.Controls.Add(this.label3);
            this.groupBoxTasks.Controls.Add(this.label2);
            this.groupBoxTasks.Controls.Add(this.richTextBoxDescription);
            this.groupBoxTasks.Controls.Add(this.textBoxTaskName);
            this.groupBoxTasks.Controls.Add(this.dateTimePickerDueDate);
            this.groupBoxTasks.Controls.Add(this.checkBoxIsCompleted);
            this.groupBoxTasks.Controls.Add(this.comboBoxPriority);
            this.groupBoxTasks.Location = new System.Drawing.Point(196, 318);
            this.groupBoxTasks.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTasks.Size = new System.Drawing.Size(808, 203);
            this.groupBoxTasks.TabIndex = 3;
            this.groupBoxTasks.TabStop = false;
            this.groupBoxTasks.Text = "Описание задачи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Важность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список задач";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(11, 524);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(159, 46);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Gray;
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHelp.Location = new System.Drawing.Point(11, 467);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(159, 40);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Помощь";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // textBoxFiltration
            // 
            this.textBoxFiltration.Location = new System.Drawing.Point(130, 21);
            this.textBoxFiltration.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFiltration.Name = "textBoxFiltration";
            this.textBoxFiltration.Size = new System.Drawing.Size(222, 23);
            this.textBoxFiltration.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Фильтрация";
            // 
            // comboBoxSortby
            // 
            this.comboBoxSortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortby.FormattingEnabled = true;
            this.comboBoxSortby.Location = new System.Drawing.Point(501, 19);
            this.comboBoxSortby.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSortby.Name = "comboBoxSortby";
            this.comboBoxSortby.Size = new System.Drawing.Size(210, 23);
            this.comboBoxSortby.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Сортировка";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBoxSortby);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxFiltration);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(196, 526);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(808, 57);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображение";
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(501, 164);
            this.comboBoxPriority.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(143, 23);
            this.comboBoxPriority.TabIndex = 5;
            // 
            // checkBoxIsCompleted
            // 
            this.checkBoxIsCompleted.AutoSize = true;
            this.checkBoxIsCompleted.Location = new System.Drawing.Point(676, 164);
            this.checkBoxIsCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxIsCompleted.Name = "checkBoxIsCompleted";
            this.checkBoxIsCompleted.Size = new System.Drawing.Size(90, 19);
            this.checkBoxIsCompleted.TabIndex = 4;
            this.checkBoxIsCompleted.Text = "Выполнено";
            this.checkBoxIsCompleted.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(130, 161);
            this.dateTimePickerDueDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(222, 23);
            this.dateTimePickerDueDate.TabIndex = 6;
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTaskName.Location = new System.Drawing.Point(130, 36);
            this.textBoxTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(636, 23);
            this.textBoxTaskName.TabIndex = 7;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(130, 74);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(636, 73);
            this.richTextBoxDescription.TabIndex = 8;
            this.richTextBoxDescription.Text = "";
            // 
            // taskItemBindingSource
            // 
            this.taskItemBindingSource.DataSource = typeof(TaskManager.TaskItem);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1028, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTasks);
            this.Controls.Add(this.groupBoxTasks);
            this.Controls.Add(this.BtnActionRemove);
            this.Controls.Add(this.btnActionEdit);
            this.Controls.Add(this.BtnActionAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TaskManager - Управление задачами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.groupBoxTasks.ResumeLayout(false);
            this.groupBoxTasks.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button BtnActionAdd;
        private System.Windows.Forms.Button BtnActionRemove;
        private System.Windows.Forms.Button btnActionEdit;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCompleted;
        private System.Windows.Forms.BindingSource taskItemBindingSource;
        private System.Windows.Forms.TextBox textBoxFiltration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSortby;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.CheckBox checkBoxIsCompleted;
        private System.Windows.Forms.ComboBox comboBoxPriority;
    }
}

