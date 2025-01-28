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
        private DateTime creationDate;

        public DateTime CreationDate
        {
            get => creationDate;
            set
            {
                creationDate = value;
                OnPropertyChanged(nameof(CreationDate));
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string ResolutionPlan
        {
            get => resolutionPlan;
            set
            {
                resolutionPlan = value;
                OnPropertyChanged(nameof(ResolutionPlan));
            }
        }

        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
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