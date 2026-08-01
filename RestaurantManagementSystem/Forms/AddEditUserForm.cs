using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestaurantManagementSystem.Enum;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;

namespace RestaurantManagementSystem.Forms
{
    public partial class AddEditUserForm : Form
    {
        private readonly UserService userService;

        private User user;

        public AddEditUserForm()
        {
            InitializeComponent();
            userService = new UserService();
            LoadRoles();
            user = null;
        }
        public AddEditUserForm(User selectedUser)
        {
            InitializeComponent();

            userService = new UserService();
            LoadRoles();
            user = selectedUser;

            LoadUserData();
        }
        private void LoadRoles()
        {
            cmbRole.DataSource = System.Enum.GetValues(typeof(UserRole));
        }
        private void LoadUserData()
        {
            txtFullName.Text = user.FullName;

            txtUsername.Text = user.Username;

            txtPassword.Text = user.Password;

            cmbRole.SelectedItem = user.Role;

            chkIsActive.Checked = user.IsActive;
        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new User();
            }

            user.FullName = txtFullName.Text.Trim();

            user.Username = txtUsername.Text.Trim();

            user.Password = txtPassword.Text;

            user.Role = (UserRole)cmbRole.SelectedItem;

            user.IsActive = chkIsActive.Checked;

            if (string.IsNullOrWhiteSpace(user.FullName))
            {
                MessageBox.Show("Full name is required.");

                return;
            }

            if (string.IsNullOrWhiteSpace(user.Username))
            {
                MessageBox.Show("Username is required.");

                return;
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Password is required.");

                return;
            }

            try
            {
                if (user.UserId == 0)
                {
                    userService.AddUser(user);

                    MessageBox.Show("User added successfully.");
                }
                else
                {
                    userService.UpdateUser(user);

                    MessageBox.Show("User updated successfully.");
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
