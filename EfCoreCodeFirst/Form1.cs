namespace EfCoreCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDbContext db = new();
            dataGridView1.DataSource = db.Students.ToList();
        }
    }
}
