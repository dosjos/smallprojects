using System.Collections.Generic;

namespace EntityFrameworkTest
{
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        IList<Category> Categories { get; set; }
    }
}  
