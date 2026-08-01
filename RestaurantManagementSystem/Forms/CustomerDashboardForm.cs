using RestaurantManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Forms
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly User currentUser;
        private readonly FoodService foodService;
        private readonly SideDishService sideDishService;
        private List<Food> allFoods;
        public CustomerDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            foodService = new FoodService();
            sideDishService = new SideDishService();
            allFoods = new List<Food>();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();

            LoadFoods();
        }
        private void LoadFoods()
        {
            allFoods = foodService.GetAllFoods();

            dgvFoods.DataSource = allFoods;
            ApplyFilters();
            ConfigureFoodsGrid();
            LoadFoodDetails();
            LoadSideDishes();

            dgvFoods.AllowUserToAddRows = false;

            dgvFoods.ReadOnly = true;

            dgvFoods.MultiSelect = false;

            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadCurrentUser()
        {
            lblCurrentUser.Text =
                $"Logged in: {currentUser.FullName}";

        }
        private Food GetSelectedFood()
        {
            if (dgvFoods.CurrentRow == null)
            {
                return null;
            }

            return dgvFoods.CurrentRow.DataBoundItem as Food;
        }
        private void LoadSideDishes()
        {
            Food selectedFood = GetSelectedFood();

            if (selectedFood == null)
            {
                dgvSideDishes.DataSource = null;

                return;
            }

            List<SideDish> sideDishes = sideDishService.GetSideDishesForFood(selectedFood.FoodId);

            dgvSideDishes.DataSource = sideDishes;
            ConfigureSideDishesGrid();

            dgvSideDishes.AllowUserToAddRows = false;

            dgvSideDishes.ReadOnly = true;

            dgvSideDishes.MultiSelect = false;

            dgvSideDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSideDishes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            LoadSideDishes();
            LoadFoodDetails();
        }
        private void ApplyFilters()
        {
            List<Food> filteredFoods = new List<Food>();
            string search = txtSearch.Text.Trim().ToLower();
            foreach (Food food in allFoods)
            {
                if (chkOnlyAvailable.Checked && !food.IsAvailable)
                {
                    continue;
                }

                if (!string.IsNullOrWhiteSpace(search))
                {
                    if (!food.Name.ToLower().Contains(search))
                    {
                        continue;
                    }
                }
                filteredFoods.Add(food);
            }
            dgvFoods.DataSource = null;
            dgvFoods.DataSource = filteredFoods;
            ConfigureFoodsGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void LoadFoodDetails()
        {
            Food selectedFood = GetSelectedFood();

            if (selectedFood == null)
            {
                lblFoodName.Text = "Food:";
                lblPrice.Text = "Price:";
                lblAvailability.Text = "Availability:";
                txtDescription.Clear();

                return;
            }

            lblFoodName.Text = $"Food: {selectedFood.Name}";

            lblPrice.Text = $"Price: {selectedFood.Price:0.00} RSD";

            if (selectedFood.IsAvailable)
            {
                lblAvailability.Text = "Availability: Available";
            }
            else
            {
                lblAvailability.Text = "Availability: Currently unavailable";
            }

            txtDescription.Text = selectedFood.Description ?? "";
        }
        private void ConfigureFoodsGrid()
        {
            dgvFoods.Columns["FoodId"].Visible = false;

            dgvFoods.Columns["Description"].Visible = false;

            dgvFoods.Columns["Name"].HeaderText = "Food";

            dgvFoods.Columns["Price"].HeaderText = "Price (RSD)";

            dgvFoods.Columns["IsAvailable"].HeaderText = "Available";

            dgvFoods.Columns["Name"].Width = 220;

            dgvFoods.Columns["Price"].Width = 120;

            dgvFoods.Columns["IsAvailable"].Width = 100;
        }
        private void ConfigureSideDishesGrid()
        {
            dgvSideDishes.Columns["SideDishId"].Visible = false;

            dgvSideDishes.Columns["Name"].HeaderText = "Side Dish";

            dgvSideDishes.Columns["Price"].HeaderText = "Price (RSD)";

            dgvSideDishes.Columns["Name"].Width = 200;

            dgvSideDishes.Columns["Price"].Width = 120;
        }

        private void chkOnlyAvailable_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dgvSideDishes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
