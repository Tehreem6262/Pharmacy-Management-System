using System;

namespace ManageMarkPharmacy
{
    partial class InventoryManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstInventory = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAddQty = new System.Windows.Forms.TextBox();
            this.lblLowStockAlert = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 109);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(225, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Management System";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 37);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 109);
            this.panel2.TabIndex = 0;
            // 
            // lstInventory
            // 
            this.lstInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnQuantity});
            this.lstInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInventory.HideSelection = false;
            this.lstInventory.Location = new System.Drawing.Point(287, 194);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(536, 325);
            this.lstInventory.TabIndex = 9;
            this.lstInventory.UseCompatibleStateImageBehavior = false;
            this.lstInventory.View = System.Windows.Forms.View.Details;
            this.lstInventory.SelectedIndexChanged += new System.EventHandler(this.lstInventory_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 121;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 263;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStock.Location = new System.Drawing.Point(863, 545);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(194, 50);
            this.btnAddStock.TabIndex = 10;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(4, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 83);
            this.button2.TabIndex = 13;
            this.button2.Text = "🢀";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAddQty
            // 
            this.txtAddQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddQty.Location = new System.Drawing.Point(910, 487);
            this.txtAddQty.Name = "txtAddQty";
            this.txtAddQty.Size = new System.Drawing.Size(82, 32);
            this.txtAddQty.TabIndex = 14;
            this.txtAddQty.TextChanged += new System.EventHandler(this.txtAddQuantity_TextChanged);
            // 
            // lblLowStockAlert
            // 
            this.lblLowStockAlert.AutoSize = true;
            this.lblLowStockAlert.BackColor = System.Drawing.Color.Silver;
            this.lblLowStockAlert.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblLowStockAlert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLowStockAlert.Location = new System.Drawing.Point(346, 124);
            this.lblLowStockAlert.Name = "lblLowStockAlert";
            this.lblLowStockAlert.Size = new System.Drawing.Size(405, 48);
            this.lblLowStockAlert.TabIndex = 11;
            this.lblLowStockAlert.Text = "Inventory Management";
            // 
            // InventoryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 626);
            this.Controls.Add(this.txtAddQty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblLowStockAlert);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryManagementForm";
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.InventoryManagementForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstInventory;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAddQty;

        // Add this method in the main form code file (InventoryManagementForm.cs)
        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: put your code to handle selection changes here
        }

        private System.Windows.Forms.Label lblLowStockAlert;
    }
}
