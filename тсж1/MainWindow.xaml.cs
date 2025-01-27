using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
                    Description = "Описание новой жалобы",
                    ResolutionPlan = "План решения новой жалобы",
                    Status = "Открыта"

                };
                


                SelectedCategory.Problems.Add(newProblem);
                SelectedProblem = newProblem;
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}

