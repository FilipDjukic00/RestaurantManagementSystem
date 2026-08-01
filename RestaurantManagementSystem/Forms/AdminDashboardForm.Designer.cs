namespace RestaurantManagementSystem
{
    partial class AdminDashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            tabControlAdmin = new TabControl();
            tabFoods = new TabPage();
            btnDeleteFood = new Button();
            btnEditFood = new Button();
            btnAddFood = new Button();
            lblFoods = new Label();
            dgvFoods = new DataGridView();
            tabUsers = new TabPage();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            dgvUsers = new DataGridView();
            label1 = new Label();
            tabSideDishes = new TabPage();
            label2 = new Label();
            btnDeleteSideDish = new Button();
            btnEditSideDish = new Button();
            btnAddSideDish = new Button();
            dgvSideDishes = new DataGridView();
            tabInvoices = new TabPage();
            label4 = new Label();
            dgvInvoiceItems = new DataGridView();
            label3 = new Label();
            dgvInvoices = new DataGridView();
            tabLoginHistory = new TabPage();
            label5 = new Label();
            dgvLoginHistory = new DataGridView();
            tabStatistics = new TabPage();
            pnlChart = new Panel();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            lblStatisticsTitle = new Label();
            pnlFoods = new Panel();
            lblFoodsTitle = new Label();
            lblFoodsValue = new Label();
            pnlUsers = new Panel();
            lblUsersTitle = new Label();
            lblUsersValue = new Label();
            pnlSideDishes = new Panel();
            lblSideDishesTitle = new Label();
            lblSideDishesValue = new Label();
            pnlAverageInvoice = new Panel();
            lblAverageInvoiceTitle = new Label();
            lblAverageInvoiceValue = new Label();
            pnlInvoices = new Panel();
            lblInvoiceValue = new Label();
            lblInvoiceTitle = new Label();
            pnlRevenue = new Panel();
            lblRevenueValue = new Label();
            lblRevenueTitle = new Label();
            tabControlAdmin.SuspendLayout();
            tabFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabSideDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSideDishes).BeginInit();
            tabInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            tabLoginHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoginHistory).BeginInit();
            tabStatistics.SuspendLayout();
            pnlChart.SuspendLayout();
            pnlFoods.SuspendLayout();
            pnlUsers.SuspendLayout();
            pnlSideDishes.SuspendLayout();
            pnlAverageInvoice.SuspendLayout();
            pnlInvoices.SuspendLayout();
            pnlRevenue.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAdmin
            // 
            tabControlAdmin.Controls.Add(tabFoods);
            tabControlAdmin.Controls.Add(tabUsers);
            tabControlAdmin.Controls.Add(tabSideDishes);
            tabControlAdmin.Controls.Add(tabInvoices);
            tabControlAdmin.Controls.Add(tabLoginHistory);
            tabControlAdmin.Controls.Add(tabStatistics);
            tabControlAdmin.Location = new Point(-3, -1);
            tabControlAdmin.Name = "tabControlAdmin";
            tabControlAdmin.SelectedIndex = 0;
            tabControlAdmin.Size = new Size(804, 455);
            tabControlAdmin.TabIndex = 0;
            // 
            // tabFoods
            // 
            tabFoods.BackColor = Color.LightCyan;
            tabFoods.Controls.Add(btnDeleteFood);
            tabFoods.Controls.Add(btnEditFood);
            tabFoods.Controls.Add(btnAddFood);
            tabFoods.Controls.Add(lblFoods);
            tabFoods.Controls.Add(dgvFoods);
            tabFoods.Location = new Point(4, 29);
            tabFoods.Name = "tabFoods";
            tabFoods.Padding = new Padding(3);
            tabFoods.Size = new Size(796, 422);
            tabFoods.TabIndex = 0;
            tabFoods.Text = "Foods";
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.BackColor = Color.Red;
            btnDeleteFood.Cursor = Cursors.Hand;
            btnDeleteFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteFood.Location = new Point(490, 370);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(160, 42);
            btnDeleteFood.TabIndex = 9;
            btnDeleteFood.Text = "Delete Food";
            btnDeleteFood.UseVisualStyleBackColor = false;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.BackColor = Color.Cyan;
            btnEditFood.Cursor = Cursors.Hand;
            btnEditFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditFood.Location = new Point(310, 370);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(160, 42);
            btnEditFood.TabIndex = 8;
            btnEditFood.Text = "Edit Food";
            btnEditFood.UseVisualStyleBackColor = false;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Lime;
            btnAddFood.Cursor = Cursors.Hand;
            btnAddFood.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddFood.Location = new Point(130, 370);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(160, 42);
            btnAddFood.TabIndex = 7;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // lblFoods
            // 
            lblFoods.AutoSize = true;
            lblFoods.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoods.Location = new Point(20, 15);
            lblFoods.Name = "lblFoods";
            lblFoods.Size = new Size(248, 31);
            lblFoods.TabIndex = 6;
            lblFoods.Text = "FOOD MANAGEMENT";
            // 
            // dgvFoods
            // 
            dgvFoods.BackgroundColor = Color.White;
            dgvFoods.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFoods.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFoods.EnableHeadersVisualStyles = false;
            dgvFoods.GridColor = Color.LightBlue;
            dgvFoods.Location = new Point(0, 50);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.Size = new Size(796, 310);
            dgvFoods.TabIndex = 5;
            // 
            // tabUsers
            // 
            tabUsers.BackColor = Color.LightCyan;
            tabUsers.Controls.Add(btnDeleteUser);
            tabUsers.Controls.Add(btnEditUser);
            tabUsers.Controls.Add(btnAddUser);
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Controls.Add(label1);
            tabUsers.Location = new Point(4, 29);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(796, 422);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Users";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Red;
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.Location = new Point(490, 370);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(160, 42);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.Cyan;
            btnEditUser.Cursor = Cursors.Hand;
            btnEditUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.Location = new Point(310, 370);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(160, 42);
            btnEditUser.TabIndex = 3;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Lime;
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(130, 370);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(160, 42);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.LightBlue;
            dgvUsers.Location = new Point(0, 50);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(796, 310);
            dgvUsers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(242, 31);
            label1.TabIndex = 0;
            label1.Text = "USER MANAGEMENT";
            // 
            // tabSideDishes
            // 
            tabSideDishes.BackColor = Color.LightCyan;
            tabSideDishes.Controls.Add(label2);
            tabSideDishes.Controls.Add(btnDeleteSideDish);
            tabSideDishes.Controls.Add(btnEditSideDish);
            tabSideDishes.Controls.Add(btnAddSideDish);
            tabSideDishes.Controls.Add(dgvSideDishes);
            tabSideDishes.Location = new Point(4, 29);
            tabSideDishes.Name = "tabSideDishes";
            tabSideDishes.Padding = new Padding(3);
            tabSideDishes.Size = new Size(796, 422);
            tabSideDishes.TabIndex = 2;
            tabSideDishes.Text = "Side Dishes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(295, 31);
            label2.TabIndex = 4;
            label2.Text = "SIDE DISH MANAGEMENT";
            // 
            // btnDeleteSideDish
            // 
            btnDeleteSideDish.BackColor = Color.Red;
            btnDeleteSideDish.Cursor = Cursors.Hand;
            btnDeleteSideDish.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSideDish.Location = new Point(490, 370);
            btnDeleteSideDish.Name = "btnDeleteSideDish";
            btnDeleteSideDish.Size = new Size(160, 42);
            btnDeleteSideDish.TabIndex = 3;
            btnDeleteSideDish.Text = "Delete Side Dish";
            btnDeleteSideDish.UseVisualStyleBackColor = false;
            btnDeleteSideDish.Click += btnDeleteSideDish_Click;
            // 
            // btnEditSideDish
            // 
            btnEditSideDish.BackColor = Color.Cyan;
            btnEditSideDish.Cursor = Cursors.Hand;
            btnEditSideDish.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditSideDish.Location = new Point(310, 370);
            btnEditSideDish.Name = "btnEditSideDish";
            btnEditSideDish.Size = new Size(160, 42);
            btnEditSideDish.TabIndex = 2;
            btnEditSideDish.Text = "Edit Side Dish";
            btnEditSideDish.UseVisualStyleBackColor = false;
            btnEditSideDish.Click += btnEditSideDish_Click;
            // 
            // btnAddSideDish
            // 
            btnAddSideDish.BackColor = Color.Lime;
            btnAddSideDish.Cursor = Cursors.Hand;
            btnAddSideDish.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSideDish.Location = new Point(130, 370);
            btnAddSideDish.Name = "btnAddSideDish";
            btnAddSideDish.Size = new Size(160, 42);
            btnAddSideDish.TabIndex = 1;
            btnAddSideDish.Text = "Add Side Dish";
            btnAddSideDish.UseVisualStyleBackColor = false;
            btnAddSideDish.Click += btnAddSideDish_Click;
            // 
            // dgvSideDishes
            // 
            dgvSideDishes.BackgroundColor = Color.White;
            dgvSideDishes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvSideDishes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvSideDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSideDishes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvSideDishes.EnableHeadersVisualStyles = false;
            dgvSideDishes.GridColor = Color.LightBlue;
            dgvSideDishes.Location = new Point(0, 50);
            dgvSideDishes.Name = "dgvSideDishes";
            dgvSideDishes.RowHeadersWidth = 51;
            dgvSideDishes.Size = new Size(796, 310);
            dgvSideDishes.TabIndex = 0;
            // 
            // tabInvoices
            // 
            tabInvoices.BackColor = Color.LightCyan;
            tabInvoices.Controls.Add(label4);
            tabInvoices.Controls.Add(dgvInvoiceItems);
            tabInvoices.Controls.Add(label3);
            tabInvoices.Controls.Add(dgvInvoices);
            tabInvoices.Location = new Point(4, 29);
            tabInvoices.Name = "tabInvoices";
            tabInvoices.Padding = new Padding(3);
            tabInvoices.Size = new Size(796, 422);
            tabInvoices.TabIndex = 3;
            tabInvoices.Text = "Invoices";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 3;
            label4.Text = "INVOICE DETAILS";
            // 
            // dgvInvoiceItems
            // 
            dgvInvoiceItems.BackgroundColor = Color.White;
            dgvInvoiceItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvInvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvInvoiceItems.DefaultCellStyle = dataGridViewCellStyle8;
            dgvInvoiceItems.EnableHeadersVisualStyles = false;
            dgvInvoiceItems.GridColor = Color.LightBlue;
            dgvInvoiceItems.Location = new Point(0, 255);
            dgvInvoiceItems.Name = "dgvInvoiceItems";
            dgvInvoiceItems.RowHeadersWidth = 51;
            dgvInvoiceItems.Size = new Size(796, 161);
            dgvInvoiceItems.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 15);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 1;
            label3.Text = "INVOICES";
            // 
            // dgvInvoices
            // 
            dgvInvoices.BackgroundColor = Color.White;
            dgvInvoices.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle10;
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.GridColor = Color.LightBlue;
            dgvInvoices.Location = new Point(0, 50);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.Size = new Size(796, 171);
            dgvInvoices.TabIndex = 0;
            dgvInvoices.SelectionChanged += dgvInvoices_SelectionChanged;
            // 
            // tabLoginHistory
            // 
            tabLoginHistory.BackColor = Color.LightCyan;
            tabLoginHistory.Controls.Add(label5);
            tabLoginHistory.Controls.Add(dgvLoginHistory);
            tabLoginHistory.Location = new Point(4, 29);
            tabLoginHistory.Name = "tabLoginHistory";
            tabLoginHistory.Padding = new Padding(3);
            tabLoginHistory.Size = new Size(796, 422);
            tabLoginHistory.TabIndex = 4;
            tabLoginHistory.Text = "Login History";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 15);
            label5.Name = "label5";
            label5.Size = new Size(185, 31);
            label5.TabIndex = 1;
            label5.Text = "LOGIN HISTORY";
            // 
            // dgvLoginHistory
            // 
            dgvLoginHistory.BackgroundColor = Color.White;
            dgvLoginHistory.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvLoginHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvLoginHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvLoginHistory.DefaultCellStyle = dataGridViewCellStyle12;
            dgvLoginHistory.EnableHeadersVisualStyles = false;
            dgvLoginHistory.GridColor = Color.LightBlue;
            dgvLoginHistory.Location = new Point(0, 50);
            dgvLoginHistory.Name = "dgvLoginHistory";
            dgvLoginHistory.RowHeadersWidth = 51;
            dgvLoginHistory.Size = new Size(796, 310);
            dgvLoginHistory.TabIndex = 0;
            // 
            // tabStatistics
            // 
            tabStatistics.BackColor = Color.LightCyan;
            tabStatistics.Controls.Add(pnlChart);
            tabStatistics.Controls.Add(lblStatisticsTitle);
            tabStatistics.Controls.Add(pnlFoods);
            tabStatistics.Controls.Add(pnlUsers);
            tabStatistics.Controls.Add(pnlSideDishes);
            tabStatistics.Controls.Add(pnlAverageInvoice);
            tabStatistics.Controls.Add(pnlInvoices);
            tabStatistics.Controls.Add(pnlRevenue);
            tabStatistics.Location = new Point(4, 29);
            tabStatistics.Name = "tabStatistics";
            tabStatistics.Padding = new Padding(3);
            tabStatistics.Size = new Size(796, 422);
            tabStatistics.TabIndex = 5;
            tabStatistics.Text = "Statistics";
            // 
            // pnlChart
            // 
            pnlChart.Controls.Add(cartesianChart1);
            pnlChart.Location = new Point(6, 176);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(784, 234);
            pnlChart.TabIndex = 5;
            // 
            // cartesianChart1
            // 
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart1.Legend = skDefaultLegend1;
            cartesianChart1.Location = new Point(16, 26);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(188, 188);
            cartesianChart1.TabIndex = 0;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart1.Tooltip = skDefaultTooltip1;
            cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // lblStatisticsTitle
            // 
            lblStatisticsTitle.AutoSize = true;
            lblStatisticsTitle.Location = new Point(3, 3);
            lblStatisticsTitle.Name = "lblStatisticsTitle";
            lblStatisticsTitle.Size = new Size(142, 20);
            lblStatisticsTitle.TabIndex = 4;
            lblStatisticsTitle.Text = "Restaurant Analytics";
            // 
            // pnlFoods
            // 
            pnlFoods.Controls.Add(lblFoodsTitle);
            pnlFoods.Controls.Add(lblFoodsValue);
            pnlFoods.Location = new Point(6, 104);
            pnlFoods.Name = "pnlFoods";
            pnlFoods.Size = new Size(257, 66);
            pnlFoods.TabIndex = 3;
            // 
            // lblFoodsTitle
            // 
            lblFoodsTitle.AutoSize = true;
            lblFoodsTitle.Location = new Point(0, 0);
            lblFoodsTitle.Name = "lblFoodsTitle";
            lblFoodsTitle.Size = new Size(49, 20);
            lblFoodsTitle.TabIndex = 6;
            lblFoodsTitle.Text = "Foods";
            // 
            // lblFoodsValue
            // 
            lblFoodsValue.AutoSize = true;
            lblFoodsValue.Location = new Point(3, 35);
            lblFoodsValue.Name = "lblFoodsValue";
            lblFoodsValue.Size = new Size(17, 20);
            lblFoodsValue.TabIndex = 7;
            lblFoodsValue.Text = "0";
            // 
            // pnlUsers
            // 
            pnlUsers.Controls.Add(lblUsersTitle);
            pnlUsers.Controls.Add(lblUsersValue);
            pnlUsers.Location = new Point(269, 104);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(257, 66);
            pnlUsers.TabIndex = 3;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = true;
            lblUsersTitle.Location = new Point(0, 0);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(44, 20);
            lblUsersTitle.TabIndex = 8;
            lblUsersTitle.Text = "Users";
            // 
            // lblUsersValue
            // 
            lblUsersValue.AutoSize = true;
            lblUsersValue.Location = new Point(3, 35);
            lblUsersValue.Name = "lblUsersValue";
            lblUsersValue.Size = new Size(17, 20);
            lblUsersValue.TabIndex = 9;
            lblUsersValue.Text = "0";
            // 
            // pnlSideDishes
            // 
            pnlSideDishes.Controls.Add(lblSideDishesTitle);
            pnlSideDishes.Controls.Add(lblSideDishesValue);
            pnlSideDishes.Location = new Point(533, 104);
            pnlSideDishes.Name = "pnlSideDishes";
            pnlSideDishes.Size = new Size(257, 66);
            pnlSideDishes.TabIndex = 3;
            // 
            // lblSideDishesTitle
            // 
            lblSideDishesTitle.AutoSize = true;
            lblSideDishesTitle.Location = new Point(0, 0);
            lblSideDishesTitle.Name = "lblSideDishesTitle";
            lblSideDishesTitle.Size = new Size(85, 20);
            lblSideDishesTitle.TabIndex = 10;
            lblSideDishesTitle.Text = "Side Dishes";
            // 
            // lblSideDishesValue
            // 
            lblSideDishesValue.AutoSize = true;
            lblSideDishesValue.Location = new Point(3, 35);
            lblSideDishesValue.Name = "lblSideDishesValue";
            lblSideDishesValue.Size = new Size(17, 20);
            lblSideDishesValue.TabIndex = 11;
            lblSideDishesValue.Text = "0";
            // 
            // pnlAverageInvoice
            // 
            pnlAverageInvoice.Controls.Add(lblAverageInvoiceTitle);
            pnlAverageInvoice.Controls.Add(lblAverageInvoiceValue);
            pnlAverageInvoice.Location = new Point(533, 30);
            pnlAverageInvoice.Name = "pnlAverageInvoice";
            pnlAverageInvoice.Size = new Size(257, 66);
            pnlAverageInvoice.TabIndex = 2;
            // 
            // lblAverageInvoiceTitle
            // 
            lblAverageInvoiceTitle.AutoSize = true;
            lblAverageInvoiceTitle.Location = new Point(-1, 0);
            lblAverageInvoiceTitle.Name = "lblAverageInvoiceTitle";
            lblAverageInvoiceTitle.Size = new Size(115, 20);
            lblAverageInvoiceTitle.TabIndex = 4;
            lblAverageInvoiceTitle.Text = "Average Invoice";
            // 
            // lblAverageInvoiceValue
            // 
            lblAverageInvoiceValue.AutoSize = true;
            lblAverageInvoiceValue.Location = new Point(-1, 37);
            lblAverageInvoiceValue.Name = "lblAverageInvoiceValue";
            lblAverageInvoiceValue.Size = new Size(68, 20);
            lblAverageInvoiceValue.TabIndex = 5;
            lblAverageInvoiceValue.Text = "0.00 RSD";
            // 
            // pnlInvoices
            // 
            pnlInvoices.Controls.Add(lblInvoiceValue);
            pnlInvoices.Controls.Add(lblInvoiceTitle);
            pnlInvoices.Location = new Point(269, 30);
            pnlInvoices.Name = "pnlInvoices";
            pnlInvoices.Size = new Size(257, 66);
            pnlInvoices.TabIndex = 1;
            // 
            // lblInvoiceValue
            // 
            lblInvoiceValue.AutoSize = true;
            lblInvoiceValue.Location = new Point(3, 37);
            lblInvoiceValue.Name = "lblInvoiceValue";
            lblInvoiceValue.Size = new Size(17, 20);
            lblInvoiceValue.TabIndex = 3;
            lblInvoiceValue.Text = "0";
            // 
            // lblInvoiceTitle
            // 
            lblInvoiceTitle.AutoSize = true;
            lblInvoiceTitle.Location = new Point(0, 0);
            lblInvoiceTitle.Name = "lblInvoiceTitle";
            lblInvoiceTitle.Size = new Size(62, 20);
            lblInvoiceTitle.TabIndex = 2;
            lblInvoiceTitle.Text = "Invoices";
            // 
            // pnlRevenue
            // 
            pnlRevenue.Controls.Add(lblRevenueValue);
            pnlRevenue.Controls.Add(lblRevenueTitle);
            pnlRevenue.Location = new Point(6, 30);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(257, 66);
            pnlRevenue.TabIndex = 0;
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Location = new Point(3, 37);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(68, 20);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "0.00 RSD";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Location = new Point(0, 0);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(65, 20);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "Revenue";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlAdmin);
            Font = new Font("Segoe UI", 9F);
            Name = "AdminDashboardForm";
            Text = "Admin Dashboard - Restaurant Management System";
            Load += AdminDashboardForm_Load;
            tabControlAdmin.ResumeLayout(false);
            tabFoods.ResumeLayout(false);
            tabFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            tabUsers.ResumeLayout(false);
            tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabSideDishes.ResumeLayout(false);
            tabSideDishes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSideDishes).EndInit();
            tabInvoices.ResumeLayout(false);
            tabInvoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            tabLoginHistory.ResumeLayout(false);
            tabLoginHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoginHistory).EndInit();
            tabStatistics.ResumeLayout(false);
            tabStatistics.PerformLayout();
            pnlChart.ResumeLayout(false);
            pnlFoods.ResumeLayout(false);
            pnlFoods.PerformLayout();
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            pnlSideDishes.ResumeLayout(false);
            pnlSideDishes.PerformLayout();
            pnlAverageInvoice.ResumeLayout(false);
            pnlAverageInvoice.PerformLayout();
            pnlInvoices.ResumeLayout(false);
            pnlInvoices.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tabFoods;
        private Button btnDeleteFood;
        private Button btnEditFood;
        private Button btnAddFood;
        private Label lblFoods;
        private DataGridView dgvFoods;
        private TabPage tabUsers;
        private TabPage tabSideDishes;
        private TabPage tabInvoices;
        private TabPage tabLoginHistory;
        private TabPage tabStatistics;
        private DataGridView dgvUsers;
        private Label label1;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private DataGridView dgvSideDishes;
        private Button btnDeleteSideDish;
        private Button btnEditSideDish;
        private Button btnAddSideDish;
        private DataGridView dgvInvoices;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvInvoiceItems;
        private DataGridView dgvLoginHistory;
        private Panel pnlUsers;
        private Panel pnlSideDishes;
        private Panel pnlAverageInvoice;
        private Panel pnlInvoices;
        private Panel pnlRevenue;
        private Panel pnlFoods;
        private Label lblFoodsTitle;
        private Label lblFoodsValue;
        private Label lblUsersTitle;
        private Label lblUsersValue;
        private Label lblSideDishesTitle;
        private Label lblSideDishesValue;
        private Label lblAverageInvoiceTitle;
        private Label lblAverageInvoiceValue;
        private Label lblInvoiceValue;
        private Label lblInvoiceTitle;
        private Label lblRevenueValue;
        private Label lblRevenueTitle;
        private Label lblStatisticsTitle;
        private Panel pnlChart;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label5;
    }
}
