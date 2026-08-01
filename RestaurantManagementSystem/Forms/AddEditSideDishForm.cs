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
    public partial class AddEditSideDishForm : Form
    {
        private readonly SideDishService sideDishService;

        private SideDish sideDish;
        public AddEditSideDishForm()
        {
            InitializeComponent();
            sideDishService = new SideDishService();

            sideDish = null;
        }
        public AddEditSideDishForm(SideDish selectedSideDish)
        {
            InitializeComponent();

            sideDishService = new SideDishService();

            sideDish = selectedSideDish;

            LoadSideDishData();
        }
        private void LoadSideDishData()
        {
            txtName.Text = sideDish.Name;

            nudPrice.Value = sideDish.Price;

            chkIsAvailable.Checked = sideDish.IsAvailable;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sideDish == null)
            {
                sideDish = new SideDish();
            }

            sideDish.Name = txtName.Text.Trim();

            sideDish.Price = nudPrice.Value;

            sideDish.IsAvailable = chkIsAvailable.Checked;

            if (string.IsNullOrWhiteSpace(sideDish.Name))
            {
                MessageBox.Show("Side dish name is required.");

                return;
            }

            if (sideDish.Price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");

                return;
            }

            try
            {
                if (sideDish.SideDishId == 0)
                {
                    sideDishService.AddSideDish(sideDish);

                    MessageBox.Show("Side dish added successfully.");
                }
                else
                {
                    sideDishService.UpdateSideDish(sideDish);

                    MessageBox.Show("Side dish updated successfully.");
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
