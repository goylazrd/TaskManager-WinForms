using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        /// <summary> Список задач </summary>
        private BindingList<TaskItem> _tasks = new BindingList<TaskItem>();

        /// <summary> Скрытая копия всех задач для восстановления при фильтрации </summary>
        private List<TaskItem> _allTasksCache = new List<TaskItem>();


        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            comboBoxPriority.DataSource = Enum.GetValues(typeof(TaskPriority)); // Ввод данных задачи
            comboBoxSortby.DataSource = Enum.GetValues(typeof(SortBy));         // СОРТИРовка

            dataGridViewTasks.AutoGenerateColumns = false;
            dataGridViewTasks.DataSource = _tasks;

            // подписочки
            comboBoxSortby.SelectedIndexChanged += ComboBoxSortby_SelectedIndexChanged;
            textBoxFiltration.TextChanged       += TextBoxFiltration_TextChanged;
            dataGridViewTasks.SelectionChanged  += DataGridViewTasks_SelectionChanged;
            dataGridViewTasks.CellFormatting    += DataGridViewTasks_CellFormatting;
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
            _allTasksCache.Add(newTask);

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
                _allTasksCache.Remove(task);

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
                "Просроченные невыполненные задачи выделены красным. Выполненные - зелёным.\n",
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

        /// <summary>
        /// Функция сортировки столбцов в DataGridView. Сортирует по одному параметру из enum SortBy
        /// </summary>
        private void ComboBoxSortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSortby.SelectedItem == null) 
                return;

            SortBy criteria = (SortBy)comboBoxSortby.SelectedItem;

            var tempList = new List<TaskItem>(_tasks);

            tempList.Sort(delegate (TaskItem x, TaskItem y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return -1;
                if (y == null) return 1;

                switch (criteria)
                {
                    case SortBy.Название:
                        return string.Compare(x.TaskName, y.TaskName, StringComparison.OrdinalIgnoreCase);
                    case SortBy.Описание:
                        return string.Compare(x.Description, y.Description, StringComparison.OrdinalIgnoreCase);
                    case SortBy.Дата:
                        return x.DueDate.CompareTo(y.DueDate);
                    case SortBy.Приоритет:
                        return x.Priority.CompareTo(y.Priority);
                    case SortBy.Выполнено:
                        return x.IsCompleted.CompareTo(y.IsCompleted);
                    default:
                        return 0;
                }
            });

            _tasks.RaiseListChangedEvents = false;
            _tasks.Clear();
            foreach (var item in tempList)
            {
                _tasks.Add(item);
            }
            _tasks.RaiseListChangedEvents = true;
            _tasks.ResetBindings();
        }

        /// <summary>
        /// Функция фильтрации столбцов в DataGridView. Ищет в "Названии" и "Описание"
        /// </summary>
        private void TextBoxFiltration_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFiltration.Text.Trim();

            if (_allTasksCache.Count == 0 && _tasks.Count > 0)
            {
                _allTasksCache.AddRange(_tasks);
            }

            _tasks.RaiseListChangedEvents = false;
            _tasks.Clear();

            foreach (var task in _allTasksCache)
            {
                // если строка поиска пуста, возвращает все элементы
                if (string.IsNullOrEmpty(filterText))
                {
                    _tasks.Add(task);
                    continue;
                }

                bool matchName = task.TaskName != null && task.TaskName.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0;
                bool matchDesc = task.Description != null && task.Description.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0;

                if (matchName || matchDesc)
                {
                    _tasks.Add(task);
                }
            }

            _tasks.RaiseListChangedEvents = true;
            _tasks.ResetBindings();
        }



        /// <summary>
        /// Список столбцов для функции сортировки.
        /// </summary>
        public enum SortBy
        {
            Название,
            Описание,
            Дата,
            Приоритет,
            Выполнено
        }

    }
}