using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.ModelsView
{
    public class Manager
    {
        #region Fields

        #endregion Fields

        #region Properties
        List<Models.Category> categories = new List<Models.Category>();
        public List<Models.Category> Categories 
        {
            get { return categories; }
            set { categories = value; }
        }
        #endregion Properties

        #region Events
        public event Action CategoryListChanged;
        public event Action<string,string> CategoryNameChanged;


        #endregion Events

        #region Constructors

        #endregion Constructors

        #region Methods

        #region Privates

        #endregion Privates	

        #region Public
        public void AddCategory(string name, string secondName, int year)
        {
            var category = new Models.Category { Name = name, SecondName = secondName, Year = year };
            categories.Add(category);
            CategoryListChanged?.Invoke();
        }

        public List<string> GetCategoryNames()
        {
            var result = new List<string>();
            foreach (var category in Categories)
            {
                result.Add(category.Name);
            }
            return result;
        }
        public void RenameCategory(string oldName, string newName)
        {
            foreach (var category in Categories)
            {
                if (category.Name == oldName)
                {
                    category.Name = newName;
                }
            }
            CategoryNameChanged?.Invoke(oldName, newName);
        }


        #endregion Public

        #endregion Methods

    }
}
