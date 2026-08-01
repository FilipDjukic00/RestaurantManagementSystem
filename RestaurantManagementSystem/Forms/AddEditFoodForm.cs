using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;

namespace RestaurantManagementSystem.Forms
{
    public partial class AddEditFoodForm : Form
    {
        private readonly FoodService foodService;
        private Food food;
        public AddEditFoodForm()
        {
            InitializeComponent();
            foodService = new FoodService();
            food = null;
        }
        public AddEditFoodForm(Food selectedFood)
        {
            InitializeComponent();

            foodService = new FoodService();

            food = selectedFood;

            LoadFoodData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (food == null)
            {
                food = new Food();
            }
            food.Name = txtName.Text.Trim();

            food.Price = nudPrice.Value;

            food.Description = txtDescription.Text.Trim();

            food.IsAvailable = chkIsAvailable.Checked;

            if (string.IsNullOrWhiteSpace(food.Name))
            {
                MessageBox.Show("Food name is required.");

                return;
            }
            if (food.Price <= 0)
            {
                MessageBox.Show("Price must be greater than zero.");

                return;
            }

            try
            {
                bool isNewFood = (food.FoodId == 0);
                if (isNewFood)
                {
                    foodService.AddFood(food);
                }
                else
                {
                    foodService.UpdateFood(food);
                }

                MessageBox.Show(isNewFood ? "Food added successfully." : "Food updated successfully.");

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadFoodData()
        {
            txtName.Text = food.Name;

            nudPrice.Value = food.Price;

            txtDescription.Text = food.Description;

            chkIsAvailable.Checked = food.IsAvailable;
        }
    }
}
