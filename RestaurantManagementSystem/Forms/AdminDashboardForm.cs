
using RestaurantManagementSystem.Forms;
using RestaurantManagementSystem.Models;
using RestaurantManagementSystem.Services;
using SkiaSharp;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace RestaurantManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        private readonly FoodService foodService;
        private readonly SideDishService sideDishService;
        private readonly User currentUser;
        private readonly UserService userService;
        private readonly InvoiceService invoiceService;
        private readonly LoginHistoryService loginHistoryService;
        private readonly StatisticsService statisticsService;
        public AdminDashboardForm(User user)
        {
            InitializeComponent();

            currentUser = user;
            foodService = new FoodService();
            sideDishService = new SideDishService();
            userService = new UserService();
            invoiceService = new InvoiceService();
            loginHistoryService = new LoginHistoryService();
            statisticsService = new StatisticsService();
            tabControlAdmin.Selected += tabControlAdmin_Selected;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadFoods();
            LoadSideDishes();
            LoadUsers();
            LoadInvoices();
            LoadLoginHistory();
            LoadStatistics();
        }
        private bool chartLoaded = false;

        private void tabControlAdmin_Selected(object? sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabStatistics && !chartLoaded)
            {
                cartesianChart1.Dock = DockStyle.Fill;

                LoadChart();

                chartLoaded = true;
            }
        }
        private void LoadChart()
        {
            List<FoodSalesStatistics> foods = statisticsService.GetTopSellingFoods();
            List<double> values = new List<double>();
            List<string> labels = new List<string>();
            foreach (FoodSalesStatistics food in foods)
            {
                values.Add(food.TimesOrdered);

                labels.Add(food.FoodName);
            }
            double maxValue = 0;
            foreach (double value in values)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
            maxValue++;
            cartesianChart1.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Values = values
                }
            };
            cartesianChart1.XAxes = new[]
            {
                new Axis
                {
                    Labels = labels,
                    Name = "Food"
                }
            };
            cartesianChart1.YAxes = new[]
            {
                new Axis
                {
                    Name = "Times Ordered",
                    MinLimit = 0,
                    MaxLimit = maxValue,
                    MinStep = 1
                }
            };
            cartesianChart1.Refresh();
        }
        private void LoadFoods()
        {
            List<Food> foods = foodService.GetAllFoods();

            dgvFoods.DataSource = foods;

            ConfigureGrid(dgvFoods);

            ConfigureFoodsGrid();
        }
        private void LoadUsers()
        {
            List<User> users = userService.GetAllUsers();

            dgvUsers.DataSource = users;

            ConfigureGrid(dgvUsers);

            ConfigureUsersGrid();
        }
        private void LoadSideDishes()
        {
            List<SideDish> sideDishes =
                sideDishService.GetAllSideDishes();

            dgvSideDishes.DataSource = sideDishes;

            ConfigureGrid(dgvSideDishes);

            ConfigureSideDishesGrid();
        }
        private void LoadInvoices()
        {
            dgvInvoices.DataSource = null;

            dgvInvoices.DataSource =
                invoiceService.GetAllInvoices();

            ConfigureGrid(dgvInvoices);

            ConfigureInvoicesGrid();
        }
        private void LoadLoginHistory()
        {
            dgvLoginHistory.DataSource = null;

            dgvLoginHistory.DataSource =
                loginHistoryService.GetLoginHistory();

            ConfigureGrid(dgvLoginHistory);

            ConfigureLoginHistoryGrid();
        }
        private void LoadStatistics()
        {
            StatisticsView statistics =
                statisticsService.GetStatistics();

            lblRevenueValue.Text =
                $"{statistics.TotalRevenue:0.00} RSD";

            lblInvoiceValue.Text =
                statistics.TotalInvoices.ToString();

            lblAverageInvoiceValue.Text =
                $"{statistics.AverageInvoice:0.00} RSD";

            lblFoodsValue.Text =
                statistics.TotalFoods.ToString();

            lblUsersValue.Text =
                statistics.TotalUsers.ToString();

            lblSideDishesValue.Text =
                statistics.TotalSideDishes.ToString();
        }
        private void ConfigureFoodsGrid()
        {
            dgvFoods.Columns["FoodId"].Visible = false;

            dgvFoods.Columns["Description"].Visible = false;

            dgvFoods.Columns["Name"].HeaderText = "Food";

            dgvFoods.Columns["Price"].HeaderText = "Price (RSD)";

            dgvFoods.Columns["IsAvailable"].HeaderText = "Available";
        }

        private void ConfigureInvoicesGrid()
        {
            dgvInvoices.Columns["InvoiceId"].HeaderText =
                "Invoice";

            dgvInvoices.Columns["CreatedAt"].HeaderText =
                "Created";

            dgvInvoices.Columns["CreatedBy"].HeaderText =
                "Waiter";

            dgvInvoices.Columns["TotalPrice"].HeaderText =
                "Total (RSD)";
        }

        private void ConfigureSideDishesGrid()
        {
            dgvSideDishes.Columns["SideDishId"].Visible = false;

            dgvSideDishes.Columns["Name"].HeaderText = "Side Dish";

            dgvSideDishes.Columns["Price"].HeaderText = "Price (RSD)";

            dgvSideDishes.Columns["IsAvailable"].HeaderText = "Available";
        }
        private void ConfigureUsersGrid()
        {
            dgvUsers.Columns["UserId"].Visible = false;

            dgvUsers.Columns["Password"].Visible = false;


            dgvUsers.Columns["Username"].HeaderText = "Username";

            dgvUsers.Columns["FullName"].HeaderText = "Full Name";

            dgvUsers.Columns["Role"].HeaderText = "Role";

            dgvUsers.Columns["IsActive"].HeaderText = "Active";
        }
        private void ConfigureLoginHistoryGrid()
        {
            dgvLoginHistory.Columns["LoginHistoryId"].Visible = false;

            dgvLoginHistory.Columns["UserId"].Visible = false;

            dgvLoginHistory.Columns["Username"].HeaderText =
                "Username";

            dgvLoginHistory.Columns["LoginTime"].HeaderText =
                "Login Time";

            dgvLoginHistory.Columns["IsSuccessful"].HeaderText =
                "Successful";

            dgvLoginHistory.Columns["LoginTime"].DefaultCellStyle.Format =
                "dd.MM.yyyy HH:mm";
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddEditFoodForm form = new AddEditFoodForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFoods();
            }
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

        private User GetSelectedUser()
        {
            if (dgvUsers.CurrentRow == null)
            {
                return null;
            }

            return dgvUsers.CurrentRow.DataBoundItem as User;
        }
        private InvoiceView GetSelectedInvoice()
        {
            if (dgvInvoices.CurrentRow == null)
            {
                return null;
            }

            return dgvInvoices.CurrentRow.DataBoundItem as InvoiceView;
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            Food selectedFood = GetSelectedFood();
            if (selectedFood == null)
            {
                MessageBox.Show(
                    "Please select a food."
                );

                return;
            }
            AddEditFoodForm form = new AddEditFoodForm(selectedFood);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFoods();
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            Food selectedFood = GetSelectedFood();

            if (selectedFood == null)
            {
                MessageBox.Show("Please select a food.");
                return;
            }

            if (MessageBox.Show(
                $"Are you sure you want to delete '{selectedFood.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                foodService.DeleteFood(selectedFood.FoodId);

                MessageBox.Show("Food deleted successfully.");

                LoadFoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddEditUserForm form = new AddEditUserForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User selectedUser = GetSelectedUser();
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            AddEditUserForm form = new AddEditUserForm(selectedUser);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User selectedUser = GetSelectedUser();

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user.");
                return;
            }

            if (selectedUser.UserId == currentUser.UserId)
            {
                MessageBox.Show("You cannot delete the currently logged in user.");

                return;
            }

            if (MessageBox.Show(
                $"Are you sure you want to delete '{selectedUser.FullName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                userService.DeleteUser(selectedUser.UserId);

                MessageBox.Show("User deleted successfully.");

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSideDish_Click(object sender, EventArgs e)
        {
            AddEditSideDishForm form = new AddEditSideDishForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSideDishes();
            }
        }

        private void btnEditSideDish_Click(object sender, EventArgs e)
        {
            SideDish selectedSideDish = GetSelectedSideDish();
            if (selectedSideDish == null)
            {
                MessageBox.Show("Please select a side dish.");
                return;
            }

            AddEditSideDishForm form = new AddEditSideDishForm(selectedSideDish);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSideDishes();
            }
        }

        private void btnDeleteSideDish_Click(object sender, EventArgs e)
        {
            SideDish selectedSideDish = GetSelectedSideDish();
            if (selectedSideDish == null)
            {
                MessageBox.Show("Please select a side dish.");
                return;
            }

            if (MessageBox.Show(
                $"Are you sure you want to delete '{selectedSideDish.Name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                sideDishService.DeleteSideDish(selectedSideDish.SideDishId);

                MessageBox.Show("Side dish deleted successfully.");

                LoadSideDishes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ConfigureGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;

            dgv.ReadOnly = true;

            dgv.MultiSelect = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgv.RowHeadersVisible = false;

            dgv.AllowUserToResizeRows = false;

            dgv.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;
        }
        private void LoadInvoiceItems()
        {
            InvoiceView selectedInvoice =
                GetSelectedInvoice();

            if (selectedInvoice == null)
            {
                dgvInvoiceItems.DataSource = null;

                return;
            }

            dgvInvoiceItems.DataSource = null;

            dgvInvoiceItems.DataSource =
                invoiceService.GetInvoiceItems(
                    selectedInvoice.InvoiceId);

            ConfigureGrid(dgvInvoiceItems);

            ConfigureInvoiceItemsGrid();
        }
        private void ConfigureInvoiceItemsGrid()
        {
            dgvInvoiceItems.Columns["Food"].HeaderText =
                "Food";

            dgvInvoiceItems.Columns["SideDish"].HeaderText =
                "Side Dish";

            dgvInvoiceItems.Columns["FoodPrice"].HeaderText =
                "Food Price";

            dgvInvoiceItems.Columns["SideDishPrice"].HeaderText =
                "Side Dish Price";

            dgvInvoiceItems.Columns["Total"].HeaderText =
                "Total";
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            LoadInvoiceItems();
        }
    }
}
