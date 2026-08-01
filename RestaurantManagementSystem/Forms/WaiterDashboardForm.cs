using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Forms
{
    public partial class WaiterDashboardForm : Form
    {
        private readonly FoodService foodService;
        private readonly User currentUser;
        private readonly SideDishService sideDishService;
        private List<InvoiceItemView> invoiceItems;
        private readonly InvoiceService invoiceService;
        public WaiterDashboardForm(User user)
        {
            InitializeComponent();

            currentUser = user;

            foodService = new FoodService();
            sideDishService = new SideDishService();
            invoiceItems = new List<InvoiceItemView>();
            invoiceService = new InvoiceService();
        }

        private void WaiterDashboardForm_Load(object sender, EventArgs e)
        {
            LoadCurrentUser();
            LoadFoods();
        }
        private void LoadFoods()
        {
            List<Food> foods =
                foodService.GetAllFoods();

            dgvFoods.DataSource = foods;
        }
        private void LoadSideDishes()
        {
            Food selectedFood = GetSelectedFood();

            if (selectedFood == null)
            {
                dgvSideDishes.DataSource = null;
                return;
            }

            List<SideDish> sideDishes =
                sideDishService.GetSideDishesForFood(selectedFood.FoodId);

            dgvSideDishes.DataSource = sideDishes;
        }
        private void RefreshInvoiceGrid()
        {
            dgvInvoiceItems.DataSource = null;

            dgvInvoiceItems.DataSource = invoiceItems;
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (InvoiceItemView item in invoiceItems)
            {
                total += item.TotalPrice;
            }
            lblTotal.Text = $"Total: {total:0.00} RSD";
        }
        private Food GetSelectedFood()
        {
            if (dgvFoods.CurrentRow == null)
            {
                return null;
            }

            return dgvFoods.CurrentRow.DataBoundItem as Food;
        }
        private SideDish GetSelectedSideDish()
        {
            if (dgvSideDishes.CurrentRow == null)
            {
                return null;
            }

            return dgvSideDishes.CurrentRow.DataBoundItem as SideDish;
        }

        private InvoiceItemView GetSelectedInvoiceItem()
        {
            if (dgvInvoiceItems.CurrentRow == null)
            {
                return null;
            }

            return dgvInvoiceItems.CurrentRow.DataBoundItem as InvoiceItemView;
        }

        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            LoadSideDishes();
        }

        private void btnAddToInvoice_Click(object sender, EventArgs e)
        {
            Food selectedFood = GetSelectedFood();

            if (selectedFood == null)
            {
                MessageBox.Show("Please select a food.");

                return;
            }
            SideDish selectedSideDish = GetSelectedSideDish();
            InvoiceItemView item = new InvoiceItemView();
            item.FoodId = selectedFood.FoodId;
            item.FoodName = selectedFood.Name;
            item.FoodPrice = selectedFood.Price;
            if (selectedSideDish != null)
            {
                item.SideDishId = selectedSideDish.SideDishId;
                item.SideDishName = selectedSideDish.Name;
                item.SideDishPrice = selectedSideDish.Price;
            }
            invoiceItems.Add(item);
            RefreshInvoiceGrid();
            UpdateTotal();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            InvoiceItemView selectedItem = GetSelectedInvoiceItem();

            if (selectedItem == null)
            {
                MessageBox.Show("Please select an invoice item.");
                return;
            }
            if (MessageBox.Show(
                "Remove selected item from invoice?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            invoiceItems.Remove(selectedItem);
            RefreshInvoiceGrid();
            UpdateTotal();
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            if (invoiceItems.Count == 0)
            {
                MessageBox.Show("Invoice is already empty.");

                return;
            }
            if (MessageBox.Show(
                "Clear current invoice?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                != DialogResult.Yes)
            {
                return;
            }
            invoiceItems.Clear();
            RefreshInvoiceGrid();
            UpdateTotal();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                int invoiceId = invoiceService.SaveInvoice(invoiceItems, currentUser.UserId);

                MessageBox.Show($"Invoice {invoiceId} saved successfully.");

                invoiceItems.Clear();
                RefreshInvoiceGrid();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadCurrentUser()
        {
            lblLoggedInUser.Text =
                $"Logged in: {currentUser.FullName}";
        }
    }
}
