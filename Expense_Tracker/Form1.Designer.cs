namespace WinFormsApp1
{
    partial class Form1
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
            lviewExpenses = new ListView();
            lblExpenses = new Label();
            btnAddExpense = new Button();
            txtbAddExpenseName = new TextBox();
            lblAddExpenseHeader = new Label();
            lblAddExpenseName = new Label();
            lblAddExpenseCost = new Label();
            txtbAddExpenseCost = new TextBox();
            cbxAddExpenseCat = new ComboBox();
            lblAddExpenseCat = new Label();
            SuspendLayout();
            // 
            // lviewExpenses
            // 
            lviewExpenses.Location = new Point(25, 67);
            lviewExpenses.Name = "lviewExpenses";
            lviewExpenses.Size = new Size(568, 423);
            lviewExpenses.TabIndex = 0;
            lviewExpenses.UseCompatibleStateImageBehavior = false;
            // 
            // lblExpenses
            // 
            lblExpenses.AutoSize = true;
            lblExpenses.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblExpenses.Location = new Point(25, 26);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(98, 28);
            lblExpenses.TabIndex = 1;
            lblExpenses.Text = "Expenses";
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(615, 298);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(116, 23);
            btnAddExpense.TabIndex = 2;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // txtbAddExpenseName
            // 
            txtbAddExpenseName.Location = new Point(615, 137);
            txtbAddExpenseName.Name = "txtbAddExpenseName";
            txtbAddExpenseName.Size = new Size(100, 23);
            txtbAddExpenseName.TabIndex = 4;
            // 
            // lblAddExpenseHeader
            // 
            lblAddExpenseHeader.AutoSize = true;
            lblAddExpenseHeader.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddExpenseHeader.Location = new Point(615, 67);
            lblAddExpenseHeader.Name = "lblAddExpenseHeader";
            lblAddExpenseHeader.Size = new Size(133, 28);
            lblAddExpenseHeader.TabIndex = 5;
            lblAddExpenseHeader.Text = "Add Expense";
            // 
            // lblAddExpenseName
            // 
            lblAddExpenseName.AutoSize = true;
            lblAddExpenseName.Location = new Point(617, 119);
            lblAddExpenseName.Name = "lblAddExpenseName";
            lblAddExpenseName.Size = new Size(50, 15);
            lblAddExpenseName.TabIndex = 6;
            lblAddExpenseName.Text = "Expense";
            // 
            // lblAddExpenseCost
            // 
            lblAddExpenseCost.AutoSize = true;
            lblAddExpenseCost.Location = new Point(617, 176);
            lblAddExpenseCost.Name = "lblAddExpenseCost";
            lblAddExpenseCost.Size = new Size(31, 15);
            lblAddExpenseCost.TabIndex = 8;
            lblAddExpenseCost.Text = "Cost";
            // 
            // txtbAddExpenseCost
            // 
            txtbAddExpenseCost.Location = new Point(617, 194);
            txtbAddExpenseCost.Name = "txtbAddExpenseCost";
            txtbAddExpenseCost.Size = new Size(100, 23);
            txtbAddExpenseCost.TabIndex = 7;
            // 
            // cbxAddExpenseCat
            // 
            cbxAddExpenseCat.FormattingEnabled = true;
            cbxAddExpenseCat.Location = new Point(615, 253);
            cbxAddExpenseCat.Name = "cbxAddExpenseCat";
            cbxAddExpenseCat.Size = new Size(100, 23);
            cbxAddExpenseCat.TabIndex = 9;
            // 
            // lblAddExpenseCat
            // 
            lblAddExpenseCat.AutoSize = true;
            lblAddExpenseCat.Location = new Point(617, 235);
            lblAddExpenseCat.Name = "lblAddExpenseCat";
            lblAddExpenseCat.Size = new Size(55, 15);
            lblAddExpenseCat.TabIndex = 10;
            lblAddExpenseCat.Text = "Category";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 667);
            Controls.Add(lblAddExpenseCat);
            Controls.Add(cbxAddExpenseCat);
            Controls.Add(lblAddExpenseCost);
            Controls.Add(txtbAddExpenseCost);
            Controls.Add(lblAddExpenseName);
            Controls.Add(lblAddExpenseHeader);
            Controls.Add(txtbAddExpenseName);
            Controls.Add(btnAddExpense);
            Controls.Add(lblExpenses);
            Controls.Add(lviewExpenses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lviewExpenses;
        private Label lblExpenses;
        private Button btnAddExpense;
        private TextBox txtbAddExpenseName;
        private Label lblAddExpenseHeader;
        private Label lblAddExpenseName;
        private Label lblAddExpenseCost;
        private TextBox txtbAddExpenseCost;
        private ComboBox cbxAddExpenseCat;
        private Label lblAddExpenseCat;
    }
}