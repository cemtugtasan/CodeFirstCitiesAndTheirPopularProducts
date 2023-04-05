using CitiesCodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CitiesCodeFirst
{
    public partial class Form1 : Form
    {
        CitiesContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new CitiesContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrestCities();
            
        }

        private void btnSehirAdýEkle_Click(object sender, EventArgs e)
        {
            var city = new City();
            city.CityName = tbSehir.Text;
            _context.Cities.Add(city);
            _context.SaveChanges();
            RefrestCities();
        }

        

        private void dgwSehirler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwSehirler.SelectedRows.Count == 0) return;
            
            int id = (int)dgwSehirler.SelectedRows[0].Cells[0].Value;

            RefreshPopularProduct(id);



        }

        private void btnSehirSil_Click(object sender, EventArgs e)
        {
            var deleteItem = (City)dgwSehirler.SelectedRows[0].DataBoundItem;
            _context.Cities.Remove(deleteItem);
            _context.SaveChanges();
            RefrestCities();
        }

        private void btnOzellikSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgwSehirler.SelectedRows[0].Cells[0].Value;
            var deleteItem = (PopularProduct)dgwMeshur.SelectedRows[0].DataBoundItem;
            _context.PopularProducts.Remove(deleteItem);
            _context.SaveChanges();
            RefreshPopularProduct(id);

        }

        private void btnMeshurOzellikEkle_Click(object sender, EventArgs e)
        {
            int id = (int)dgwSehirler.SelectedRows[0].Cells[0].Value;
            var PopularProduct = new PopularProduct();
            PopularProduct.ProductName = tbMeshur.Text;
            PopularProduct.Cities = (City)dgwSehirler.SelectedRows[0].DataBoundItem;
            PopularProduct.CityID = (int)dgwSehirler.SelectedRows[0].Cells[0].Value;
            _context.PopularProducts.Add(PopularProduct);
            _context.SaveChanges();
            RefreshPopularProduct(id);

        }

        private void RefreshPopularProduct(int cityID)
        {
            dgwMeshur.Columns.Clear();
            dgwMeshur.DataSource = null;
            dgwMeshur.DataSource = _context.PopularProducts.Where(x => x.CityID == cityID).ToList();
            var cityColumn = dgwMeshur.Columns["Cities"];
            dgwMeshur.Columns.Remove(cityColumn);
        }
        private void RefrestCities()
        {   
            dgwSehirler.Columns.Clear();
            dgwSehirler.DataSource = null;
            dgwSehirler.DataSource = _context.Cities.ToList();
            var popularProducts = dgwSehirler.Columns["PopularProducts"];
            dgwSehirler.Columns.Remove(popularProducts);
        }
    }
}