namespace RestaurantManagementSystem.Forms
{
    partial class WaiterDashboardForm
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
            label1 = new Label();
            label2 = new Label();
            dgvFoods = new DataGridView();
            dgvInvoiceItems = new DataGridView();
            dgvSideDishes = new DataGridView();
            label3 = new Label();
            btnAddToInvoice = new Button();
            btnSaveInvoice = new Button();
            btnClearInvoice = new Button();
            lblTotal = new Label();
            btnRemoveItem = new Button();
            lblLoggedInUser = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSideDishes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 45);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 0;
            label1.Text = "Available Foods";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(410, 45);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "Current Invoice";
            // 
            // dgvFoods
            // 
            dgvFoods.BackgroundColor = Color.White;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.GridColor = SystemColors.HotTrack;
            dgvFoods.Location = new Point(20, 70);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.Size = new Size(370, 150);
            dgvFoods.TabIndex = 2;
            dgvFoods.SelectionChanged += dgvFoods_SelectionChanged;
            // 
            // dgvInvoiceItems
            // 
            dgvInvoiceItems.BackgroundColor = Color.White;
            dgvInvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceItems.GridColor = SystemColors.HotTrack;
            dgvInvoiceItems.Location = new Point(410, 70);
            dgvInvoiceItems.Name = "dgvInvoiceItems";
            dgvInvoiceItems.RowHeadersWidth = 51;
            dgvInvoiceItems.Size = new Size(370, 220);
            dgvInvoiceItems.TabIndex = 3;
            // 
            // dgvSideDishes
            // 
            dgvSideDishes.BackgroundColor = Color.White;
            dgvSideDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSideDishes.GridColor = SystemColors.HotTrack;
            dgvSideDishes.Location = new Point(20, 255);
            dgvSideDishes.Name = "dgvSideDishes";
            dgvSideDishes.RowHeadersWidth = 51;
            dgvSideDishes.Size = new Size(370, 150);
            dgvSideDishes.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 230);
            label3.Name = "label3";
            label3.Size = new Size(180, 23);
            label3.TabIndex = 5;
            label3.Text = "Available Side Dishes";
            // 
            // btnAddToInvoice
            // 
            btnAddToInvoice.BackColor = Color.ForestGreen;
            btnAddToInvoice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToInvoice.ForeColor = Color.White;
            btnAddToInvoice.Location = new Point(20, 411);
            btnAddToInvoice.Name = "btnAddToInvoice";
            btnAddToInvoice.Size = new Size(370, 35);
            btnAddToInvoice.TabIndex = 6;
            btnAddToInvoice.Text = "Add To Invoice";
            btnAddToInvoice.UseVisualStyleBackColor = false;
            btnAddToInvoice.Click += btnAddToInvoice_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.BackColor = Color.RoyalBlue;
            btnSaveInvoice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveInvoice.ForeColor = Color.White;
            btnSaveInvoice.Location = new Point(410, 400);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(350, 45);
            btnSaveInvoice.TabIndex = 7;
            btnSaveInvoice.Text = "Save Invoice";
            btnSaveInvoice.UseVisualStyleBackColor = false;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // btnClearInvoice
            // 
            btnClearInvoice.BackColor = Color.Red;
            btnClearInvoice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearInvoice.ForeColor = Color.White;
            btnClearInvoice.Location = new Point(590, 350);
            btnClearInvoice.Name = "btnClearInvoice";
            btnClearInvoice.Size = new Size(170, 35);
            btnClearInvoice.TabIndex = 8;
            btnClearInvoice.Text = "Clear Invoice";
            btnClearInvoice.UseVisualStyleBackColor = false;
            btnClearInvoice.Click += btnClearInvoice_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(480, 298);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(156, 28);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: 0.00 RSD";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.DarkOrange;
            btnRemoveItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(410, 350);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(170, 35);
            btnRemoveItem.TabIndex = 10;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoggedInUser.ForeColor = Color.DimGray;
            lblLoggedInUser.Location = new Point(12, 9);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(86, 20);
            lblLoggedInUser.TabIndex = 11;
            lblLoggedInUser.Text = "Logged in: ";
            // 
            // WaiterDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoggedInUser);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblTotal);
            Controls.Add(btnClearInvoice);
            Controls.Add(btnSaveInvoice);
            Controls.Add(btnAddToInvoice);
            Controls.Add(label3);
            Controls.Add(dgvSideDishes);
            Controls.Add(dgvInvoiceItems);
            Controls.Add(dgvFoods);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WaiterDashboardForm";
            Text = "Waiter Order";
            Load += WaiterDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSideDishes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvFoods;
        private DataGridView dgvInvoiceItems;
        private DataGridView dgvSideDishes;
        private Label label3;
        private Button btnAddToInvoice;
        private Button btnSaveInvoice;
        private Button btnClearInvoice;
        private Label lblTotal;
        private Button btnRemoveItem;
        private Label lblLoggedInUser;
    }
}