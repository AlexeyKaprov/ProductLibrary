using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Models
{
    public class Category
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Year { get; set; }
        List<Category> ChildCatogryCollection;
        
    }
}
