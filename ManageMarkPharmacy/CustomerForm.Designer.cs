namespace ManageMarkPharmacy
{
    partial class CustomerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPainRelievers = new System.Windows.Forms.Button();
            this.btnCoughSyrups = new System.Windows.Forms.Button();
            this.btnAntibiotics = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSupplements = new System.Windows.Forms.Button();
            this.btnVitamins = new System.Windows.Forms.Button();
            this.btnOthers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 122);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(177, 21);
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
            this.panel3.Size = new System.Drawing.Size(105, 41);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(27, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 114);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(333, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pharmacy Categories";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPainRelievers
            // 
            this.btnPainRelievers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPainRelievers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainRelievers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPainRelievers.Location = new System.Drawing.Point(156, 243);
            this.btnPainRelievers.Name = "btnPainRelievers";
            this.btnPainRelievers.Size = new System.Drawing.Size(226, 53);
            this.btnPainRelievers.TabIndex = 5;
            this.btnPainRelievers.Text = "1. Pain Relievers";
            this.btnPainRelievers.UseVisualStyleBackColor = false;
            this.btnPainRelievers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCoughSyrups
            // 
            this.btnCoughSyrups.AutoEllipsis = true;
            this.btnCoughSyrups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCoughSyrups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCoughSyrups.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCoughSyrups.Location = new System.Drawing.Point(156, 343);
            this.btnCoughSyrups.Name = "btnCoughSyrups";
            this.btnCoughSyrups.Size = new System.Drawing.Size(229, 50);
            this.btnCoughSyrups.TabIndex = 6;
            this.btnCoughSyrups.Text = "2. Cough Syrups";
            this.btnCoughSyrups.UseVisualStyleBackColor = false;
            this.btnCoughSyrups.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAntibiotics
            // 
            this.btnAntibiotics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAntibiotics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAntibiotics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAntibiotics.Location = new System.Drawing.Point(159, 437);
            this.btnAntibiotics.Name = "btnAntibiotics";
            this.btnAntibiotics.Size = new System.Drawing.Size(226, 47);
            this.btnAntibiotics.TabIndex = 7;
            this.btnAntibiotics.Text = "3. Antibiotics";
            this.btnAntibiotics.UseVisualStyleBackColor = false;
            this.btnAntibiotics.Click += new System.EventHandler(this.btnAntibiotics_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(359, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 59);
            this.button4.TabIndex = 8;
            this.button4.Text = "Billing";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSupplements
            // 
            this.btnSupplements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSupplements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupplements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupplements.Location = new System.Drawing.Point(563, 243);
            this.btnSupplements.Name = "btnSupplements";
            this.btnSupplements.Size = new System.Drawing.Size(216, 53);
            this.btnSupplements.TabIndex = 9;
            this.btnSupplements.Text = "4. Supplements";
            this.btnSupplements.UseVisualStyleBackColor = false;
            this.btnSupplements.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVitamins
            // 
            this.btnVitamins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVitamins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVitamins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVitamins.Location = new System.Drawing.Point(563, 334);
            this.btnVitamins.Name = "btnVitamins";
            this.btnVitamins.Size = new System.Drawing.Size(216, 50);
            this.btnVitamins.TabIndex = 10;
            this.btnVitamins.Text = "5. Vitamins";
            this.btnVitamins.UseVisualStyleBackColor = false;
            this.btnVitamins.Click += new System.EventHandler(this.btnVitamins_Click);
            // 
            // btnOthers
            // 
            this.btnOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOthers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOthers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOthers.Location = new System.Drawing.Point(563, 428);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(216, 47);
            this.btnOthers.TabIndex = 11;
            this.btnOthers.Text = "6. Others";
            this.btnOthers.UseVisualStyleBackColor = false;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 83);
            this.button1.TabIndex = 12;
            this.button1.Text = "🢀";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOthers);
            this.Controls.Add(this.btnVitamins);
            this.Controls.Add(this.btnSupplements);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAntibiotics);
            this.Controls.Add(this.btnCoughSyrups);
            this.Controls.Add(this.btnPainRelievers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Text = "CostumerForm";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPainRelievers;
        private System.Windows.Forms.Button btnCoughSyrups;
        private System.Windows.Forms.Button btnAntibiotics;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSupplements;
        private System.Windows.Forms.Button btnVitamins;
        private System.Windows.Forms.Button btnOthers;
        private System.Windows.Forms.Button button1;
    }
}