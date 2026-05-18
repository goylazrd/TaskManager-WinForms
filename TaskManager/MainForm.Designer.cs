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
            this.DataIsCopmleted = new System.Windows.Forms.CheckBox();
            this.DataPriority = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxTasks = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnActionAdd
            // 
            this.BtnActionAdd.BackColor = System.Drawing.Color.LightGreen;
            this.BtnActionAdd.Location = new System.Drawing.Point(11, 36);
            this.BtnActionAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnActionAdd.Name = "BtnActionAdd";
            this.BtnActionAdd.Size = new System.Drawing.Size(136, 61);
            this.BtnActionAdd.TabIndex = 0;
            this.BtnActionAdd.Text = "Добавить";
            this.BtnActionAdd.UseVisualStyleBackColor = false;
            // 
            // btnActionEdit
            // 
            this.btnActionEdit.Location = new System.Drawing.Point(11, 110);
            this.btnActionEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActionEdit.Name = "btnActionEdit";
            this.btnActionEdit.Size = new System.Drawing.Size(136, 54);
            this.btnActionEdit.TabIndex = 1;
            this.btnActionEdit.Text = "Редактировать";
            this.btnActionEdit.UseVisualStyleBackColor = true;
            // 
            // BtnActionRemove
            // 
            this.BtnActionRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnActionRemove.Location = new System.Drawing.Point(11, 180);
            this.BtnActionRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnActionRemove.Name = "BtnActionRemove";
            this.BtnActionRemove.Size = new System.Drawing.Size(136, 54);
            this.BtnActionRemove.TabIndex = 2;
            this.BtnActionRemove.Text = "Удалить";
            this.BtnActionRemove.UseVisualStyleBackColor = false;
            // 
            // DataIsCopmleted
            // 
            this.DataIsCopmleted.AutoSize = true;
            this.DataIsCopmleted.Location = new System.Drawing.Point(111, 220);
            this.DataIsCopmleted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataIsCopmleted.Name = "DataIsCopmleted";
            this.DataIsCopmleted.Size = new System.Drawing.Size(83, 17);
            this.DataIsCopmleted.TabIndex = 4;
            this.DataIsCopmleted.Text = "Выполнено";
            this.DataIsCopmleted.UseVisualStyleBackColor = true;
            // 
            // DataPriority
            // 
            this.DataPriority.FormattingEnabled = true;
            this.DataPriority.Location = new System.Drawing.Point(111, 186);
            this.DataPriority.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataPriority.Name = "DataPriority";
            this.DataPriority.Size = new System.Drawing.Size(150, 21);
            this.DataPriority.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Description,
            this.Date,
            this.Priority,
            this.IsCompleted});
            this.dataGridView1.Location = new System.Drawing.Point(168, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(792, 250);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBoxTasks
            // 
            this.groupBoxTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTasks.Controls.Add(this.label6);
            this.groupBoxTasks.Controls.Add(this.label5);
            this.groupBoxTasks.Controls.Add(this.label4);
            this.groupBoxTasks.Controls.Add(this.label3);
            this.groupBoxTasks.Controls.Add(this.label2);
            this.groupBoxTasks.Controls.Add(this.richTextBox1);
            this.groupBoxTasks.Controls.Add(this.textBox1);
            this.groupBoxTasks.Controls.Add(this.dateTimePicker1);
            this.groupBoxTasks.Controls.Add(this.DataIsCopmleted);
            this.groupBoxTasks.Controls.Add(this.DataPriority);
            this.groupBoxTasks.Location = new System.Drawing.Point(168, 300);
            this.groupBoxTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTasks.Name = "groupBoxTasks";
            this.groupBoxTasks.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(111, 68);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(631, 64);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(111, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 20);
            this.textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 151);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 6;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(29, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(29, 468);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Помощь";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Название";
            this.TaskName.MinimumWidth = 8;
            this.TaskName.Name = "TaskName";
            this.TaskName.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 250;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Важность";
            this.Priority.MinimumWidth = 8;
            this.Priority.Name = "Priority";
            // 
            // IsCompleted
            // 
            this.IsCompleted.HeaderText = "Выполнено";
            this.IsCompleted.MinimumWidth = 8;
            this.IsCompleted.Name = "IsCompleted";
            this.IsCompleted.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxTasks);
            this.Controls.Add(this.BtnActionRemove);
            this.Controls.Add(this.btnActionEdit);
            this.Controls.Add(this.BtnActionAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TaskManager - Управление задачами";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxTasks.ResumeLayout(false);
            this.groupBoxTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button BtnActionAdd;
        private System.Windows.Forms.Button BtnActionRemove;
        private System.Windows.Forms.Button btnActionEdit;
        private System.Windows.Forms.CheckBox DataIsCopmleted;
        private System.Windows.Forms.ComboBox DataPriority;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCompleted;
    }
}

