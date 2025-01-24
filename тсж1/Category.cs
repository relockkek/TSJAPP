using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тсж1
{
    internal class Category
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
