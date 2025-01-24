using System;
using System.Collections.ObjectModel;
using System.Windows;
using тсж1;

namespace TSJApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Category> Categories { get; set; }
        private Category selectedCategory;
        public Category SelectedCategory
        {
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                if (selectedCategory != null)
                {
                    ProblemsListBox.ItemsSource = selectedCategory.Problems;
                }
            }
        }

        public Problem SelectedProblem { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Categories = new ObservableCollection<Category>
            {
                new Category("Качество коммунальных услуг"),
                new Category("Планы по обустройству дома и территории"),
                new Category("Иные проблемы жителей")
            };

            DataContext = this;
        }

        private void CreateProblem_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedCategory != null)
            {
                var newProblem = new Problem
                {
                    Title = "Новая жалоба",
                    Description = "Описание новой жалобы"
                };

                SelectedCategory.Problems.Add(newProblem);
                SelectedProblem = newProblem; 
            }
        }
    }

    public class Problem
    {
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Applicant { get; set; }
        public string ResolutionPlan { get; set; }
        public string Status { get; set; }

        public Problem()
        {
            CreationDate = DateTime.Now;
            Status = "Вопрос открыт";
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public ObservableCollection<Problem> Problems { get; set; }

        public Category(string name)
        {
            Name = name;
            Problems = new ObservableCollection<Problem>();
        }
    }
}
