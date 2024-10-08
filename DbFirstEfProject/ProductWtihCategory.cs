namespace DbFirstEfProject
{
    public class ProductWtihCategory
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
