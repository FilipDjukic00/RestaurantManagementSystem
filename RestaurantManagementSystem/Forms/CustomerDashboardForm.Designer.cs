namespace RestaurantManagementSystem.Forms
{
    partial class CustomerDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFoods = new DataGridView();
            dgvSideDishes = new DataGridView();
            lblCurrentUser = new Label();
            label2 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            chkOnlyAvailable = new CheckBox();
            txtDescription = new TextBox();
            lblFoodName = new Label();
            lblPrice = new Label();
            lblAvailability = new Label();
            label3 = new Label();
            panelDetails = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSideDishes).BeginInit();
            panelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFoods
            // 
            dgvFoods.BackgroundColor = Color.White;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.GridColor = Color.Green;
            dgvFoods.Location = new Point(20, 75);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.Size = new Size(370, 230);
            dgvFoods.TabIndex = 0;
            dgvFoods.SelectionChanged += dgvFoods_SelectionChanged;
            // 
            // dgvSideDishes
            // 
            dgvSideDishes.BackgroundColor = Color.White;
            dgvSideDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSideDishes.GridColor = Color.Green;
            dgvSideDishes.Location = new Point(410, 75);
            dgvSideDishes.Name = "dgvSideDishes";
            dgvSideDishes.RowHeadersWidth = 51;
            dgvSideDishes.Size = new Size(350, 230);
            dgvSideDishes.TabIndex = 1;
            dgvSideDishes.CellContentClick += dgvSideDishes_CellContentClick;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.DimGray;
            lblCurrentUser.Location = new Point(12, 9);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(82, 20);
            lblCurrentUser.TabIndex = 2;
            lblCurrentUser.Text = "Logged in:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 3;
            label2.Text = "Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(410, 50);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 5;
            label4.Text = "Side Dishes";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(440, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 30);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 9;
            label1.Text = "Search:";
            // 
            // chkOnlyAvailable
            // 
            chkOnlyAvailable.AutoSize = true;
            chkOnlyAvailable.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkOnlyAvailable.Location = new Point(630, 15);
            chkOnlyAvailable.Name = "chkOnlyAvailable";
            chkOnlyAvailable.Size = new Size(145, 27);
            chkOnlyAvailable.TabIndex = 10;
            chkOnlyAvailable.Text = "Only available";
            chkOnlyAvailable.UseVisualStyleBackColor = true;
            chkOnlyAvailable.CheckedChanged += chkOnlyAvailable_CheckedChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(320, 35);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(405, 70);
            txtDescription.TabIndex = 11;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodName.Location = new Point(15, 15);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(48, 20);
            lblFoodName.TabIndex = 12;
            lblFoodName.Text = "Food:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(15, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 20);
            lblPrice.TabIndex = 13;
            lblPrice.Text = "Price:";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailability.Location = new Point(15, 75);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(91, 20);
            lblAvailability.TabIndex = 14;
            lblAvailability.Text = "Availability:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(320, 15);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 15;
            label3.Text = "Description:";
            // 
            // panelDetails
            // 
            panelDetails.BackColor = Color.White;
            panelDetails.Controls.Add(txtDescription);
            panelDetails.Controls.Add(lblAvailability);
            panelDetails.Controls.Add(label3);
            panelDetails.Controls.Add(lblPrice);
            panelDetails.Controls.Add(lblFoodName);
            panelDetails.Location = new Point(20, 311);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(740, 136);
            panelDetails.TabIndex = 16;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDetails);
            Controls.Add(chkOnlyAvailable);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblCurrentUser);
            Controls.Add(dgvSideDishes);
            Controls.Add(dgvFoods);
            Name = "CustomerDashboardForm";
            Text = "Customer Dashboard - Restaurant Management System";
            Load += CustomerDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSideDishes).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFoods;
        private DataGridView dgvSideDishes;
        private Label lblCurrentUser;
        private Label label2;
        private Label label4;
        private TextBox txtSearch;
        private Label label1;
        private CheckBox chkOnlyAvailable;
        private TextBox txtDescription;
        private Label lblFoodName;
        private Label lblPrice;
        private Label lblAvailability;
        private Label label3;
        private Panel panelDetails;
    }
}