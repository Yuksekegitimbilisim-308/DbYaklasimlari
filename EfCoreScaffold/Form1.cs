using EfCoreScaffold.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EfCoreScaffold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDbContext context = new();
            //dataGridView1.DataSource = context.Products.ToList();
            //var query = context.Products.Include(x => x.Category)
            //    .Select(x => new
            //    {
            //        ProductId = x.ProductId,
            //        ProductName = x.ProductName,
            //        UnitInStock = x.UnitsInStock,
            //        UnitPrice = x.UnitPrice,
            //        CategoryName = x.Category.CategoryName
            //    }).ToList();
            //dataGridView1.DataSource = query;
            var query = context.Products.AsNoTracking().Include(x=> x.Supplier).Include(x => x.Category)
                .Select(x => new
                {
                    SupplierName = x.Supplier.ContactName,
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    UnitInStock = x.UnitsInStock,
                    UnitPrice = x.UnitPrice,
                    CategoryName = x.Category.CategoryName
                }).OrderBy(x => x.CategoryName).ThenBy(x => x.UnitPrice).Where(x => x.UnitPrice > 10).ToList();
            dataGridView1.DataSource = query;
        }
    }
}
