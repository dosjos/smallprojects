namespace EntityFrameworkTest
{
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set;}
        public int Price { get; set; }

        public Category Category { get; set; }
    }
}
