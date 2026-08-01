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
using RestaurantManagementSystem.Forms;

namespace RestaurantManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;
        private readonly LoginHistoryService loginHistoryService;
        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
            loginHistoryService = new LoginHistoryService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password."
                );

                return;
            }
            User user = userService.Login(username, password);
            if (user == null)
            {
                loginHistoryService.AddLoginHistory(null, username, false);
                MessageBox.Show("Invalid username or password.");
                return;
            }
            loginHistoryService.AddLoginHistory(user.UserId, user.Username, true);

            switch (user.Role)
            {
                case UserRole.Admin:

                    AdminDashboardForm adminForm = new AdminDashboardForm(user);
                    adminForm.FormClosed += DashboardForm_FormClosed;

                    adminForm.Show();
                    this.Hide();
                    break;

                case UserRole.Waiter:
                    WaiterDashboardForm waiterForm = new WaiterDashboardForm(user);
                    waiterForm.FormClosed += DashboardForm_FormClosed;

                    waiterForm.Show();
                    this.Hide();
                    break;

                case UserRole.Customer:

                    CustomerDashboardForm customerForm = new CustomerDashboardForm(user);
                    customerForm.FormClosed += DashboardForm_FormClosed;
                    customerForm.Show();
                    this.Hide();
                    break;
            }
        }
        private void DashboardForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
