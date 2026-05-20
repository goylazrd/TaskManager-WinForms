using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        /// <summary> Список задач </summary>
        private BindingList<TaskItem> _tasks = new BindingList<TaskItem>();

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            comboBoxPriority.DataSource = Enum.GetValues(typeof(TaskPriority));
            dataGridViewTasks.AutoGenerateColumns = false;
            dataGridViewTasks.DataSource = _tasks;

            // подписочки
            dataGridViewTasks.SelectionChanged += DataGridViewTasks_SelectionChanged;
            dataGridViewTasks.CellFormatting   += DataGridViewTasks_CellFormatting;
        }


        // "Добавить"
        private void BtnActionAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTaskName.Text))
            {
                MessageBox.Show(
                    "Название задачи пустое, введите что-нибудь.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTask = new TaskItem(
                textBoxTaskName.Text,
                richTextBoxDescription.Text,
                dateTimePickerDueDate.Value,
                (TaskPriority)comboBoxPriority.SelectedItem,
                checkBoxIsCompleted.Checked
            );

            _tasks.Add(newTask);
            ClearInputs();
        }


        // "Редактировать"
        private void BtnActionEdit_Click(object sender, EventArgs e)
        {
            if (IsTaskSelected() == false) 
                return;

            // выбранная задача и её изменение из полей ввода
            var selectedTask = (TaskItem)dataGridViewTasks.CurrentRow.DataBoundItem;

            selectedTask.TaskName    = textBoxTaskName.Text;
            selectedTask.Description = richTextBoxDescription.Text;
            selectedTask.DueDate     = dateTimePickerDueDate.Value;
            selectedTask.Priority    = (TaskPriority)comboBoxPriority.SelectedItem;
            selectedTask.IsCompleted = checkBoxIsCompleted.Checked;

            _tasks.ResetBindings();
            ClearInputs();
        }


        // "Удалить"
        private void BtnActionRemove_Click(object sender, EventArgs e)
        {
            if (IsTaskSelected() == false) 
                return;

            foreach (DataGridViewRow row in dataGridViewTasks.SelectedRows)
            {
                var task = (TaskItem)row.DataBoundItem;
                _tasks.Remove(task);
            }

            ClearInputs();
        }


        // "Помощь"
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "[ TaskManager ]\nПриложение для управления личными задачами.\n\n" +
                "* Добавить: создаёт новую задачу из заполненных полей\n" +
                "* Редактировать: сохраняет изменения выбранной задачи\n" +
                "* Удалить: удаляет отмеченные строки\n\n" +
                "Просроченные невыполненные задачи выделены красным.\n",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // "Выйти"
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Точно выйти?",
            "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
                Application.Exit();
        }




        /// <summary> Заполняет поля ввода при выборе задачи в списке </summary>
        private void DataGridViewTasks_SelectionChanged(object sender, EventArgs e)
        {
            var row = dataGridViewTasks.CurrentRow;
            if (row != null)
            {
                var selectedTask = (TaskItem)row.DataBoundItem;
                if (selectedTask != null)
                {
                    textBoxTaskName.Text          = selectedTask.TaskName;
                    richTextBoxDescription.Text   = selectedTask.Description;
                    dateTimePickerDueDate.Value   = selectedTask.DueDate;
                    comboBoxPriority.SelectedItem = selectedTask.Priority;
                    checkBoxIsCompleted.Checked   = selectedTask.IsCompleted;
                }
            }
        }


        /// <summary> Окрашивает задачи в определённый цвет </summary>
        private void DataGridViewTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var task = (TaskItem)dataGridViewTasks.Rows[e.RowIndex].DataBoundItem;

            if (task == null) 
                return;

            if (task.IsCompleted)
                e.CellStyle.ForeColor = Color.Green;
            else if (task.IsOverdue)
                e.CellStyle.ForeColor = Color.Red;
            else
                e.CellStyle.ForeColor = Color.Black;
        }


        /// <summary> Очищает поля ввода </summary>
        private void ClearInputs()
        {
            textBoxTaskName.Clear();
            richTextBoxDescription.Clear();
            dateTimePickerDueDate.Value = DateTime.Today;
            comboBoxPriority.SelectedIndex = 0;
            checkBoxIsCompleted.Checked = false;

            dataGridViewTasks.ClearSelection();
        }


        /// <summary> Проверяет выбрана ли задача в таблице </summary>
        private bool IsTaskSelected()
        {
            var row = dataGridViewTasks.CurrentRow;
            if (row == null || row.Index < 0)
            {
                MessageBox.Show(
                    "Не выбрана задача!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}