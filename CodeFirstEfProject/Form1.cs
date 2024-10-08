using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstEfProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            dataGridView1.DataSource = dbContext.Cars.Include("Brands")
                .Select(x => new
                {
                    BrandName = x.Brands.BrandName,
                    CarModel = x.Model,
                    Color = x.Color,
                    DoorCount = x.DoorCount,
                    GlassCount = x.GlassCount
                }).ToList();
        }
    }
}
