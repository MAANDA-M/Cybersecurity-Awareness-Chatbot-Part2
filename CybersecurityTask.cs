using System;

namespace CybersecurityChatbotWPF
{
    public class CybersecurityTask
    {
        public string Title { get; private set; }
        public DateTime? ReminderDate { get; private set; }
        public string ReminderDescription { get; private set; }
        public bool IsCompleted { get; private set; }

        public CybersecurityTask(string title, DateTime? reminderDate = null, string reminderDescription = null)
        {
            Title = title;
            ReminderDate = reminderDate;
            ReminderDescription = reminderDescription;
            IsCompleted = false;
        }

        public void MarkComplete()
        {
            IsCompleted = true;
        }
    }
}