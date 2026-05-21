using System;

namespace TaskManager
{
    /// <summary>Приоритет задачи.</summary>
    public enum TaskPriority
    {
        Низкая,
        Средняя,
        Высокая
    }

    /// <summary>Задача с названием, описанием, датой, приоритетом и статусом.</summary>
    public class TaskItem
    {
        /// <summary>Название задачи.</summary>
        public string TaskName { get; set; }

        /// <summary>Описание задачи.</summary>
        public string Description { get; set; }

        /// <summary>Дата выполнения.</summary>
        public DateTime DueDate { get; set; }

        /// <summary>Приоритет задачи (Low | Medium | High).</summary>
        public TaskPriority Priority { get; set; }

        /// <summary>Выполнена ли задача (True | False).</summary>
        public bool IsCompleted { get; set; }

        /// <summary>true, если задача просрочена и не выполнена.</summary>
        public bool IsOverdue => !IsCompleted && DueDate.Date < DateTime.Today;



        /// <summary>Конструктор. Создаёт новую задачу.</summary>
        public TaskItem(string taskName, string description, 
                        DateTime dueDate, TaskPriority priority, 
                        bool isCompleted = false)
        {
            TaskName    = taskName;
            Description = description;
            DueDate     = dueDate;
            Priority    = priority;
            IsCompleted = isCompleted;
        }

        /// <summary>Возвращает строковое представление объекта TaskItem.</summary>
        public override string ToString()
        {
            string check = IsCompleted ? " Да  " : " Нет ";
            return $"[{check}] {TaskName} ({DueDate:dd.MM.yyyy}, {Priority})";
        }
    }
}
