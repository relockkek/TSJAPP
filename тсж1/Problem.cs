using System;
using System.ComponentModel;

namespace тсж1
{
    public class Problem : INotifyPropertyChanged
    {
        private string title;
        private string description;
        private string resolutionPlan;
        private string status;

        public DateTime CreationDate { get; set; }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        public string ResolutionPlan
        {
            get => resolutionPlan;
            set
            {
                resolutionPlan = value;
                OnPropertyChanged("ResolutionPlan");
            }
        }
        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Problem()
        {
            CreationDate = DateTime.Now;
            Status = "Вопрос открыт";
            Title = "Новая жалоба";
            Description = "Описание новой жалобы";
        }
    }
}
