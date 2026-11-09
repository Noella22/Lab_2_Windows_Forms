namespace Lab_2
{
    partial class BicycleForm
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
            this.btnStartHour = new System.Windows.Forms.Label();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartHour
            // 
            this.btnStartHour.AutoSize = true;
            this.btnStartHour.BackColor = System.Drawing.Color.Cyan;
            this.btnStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartHour.Location = new System.Drawing.Point(73, 137);
            this.btnStartHour.Name = "btnStartHour";
            this.btnStartHour.Size = new System.Drawing.Size(102, 22);
            this.btnStartHour.TabIndex = 0;
            this.btnStartHour.Text = "Start Hour";
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(272, 137);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(144, 22);
            this.txtStartHour.TabIndex = 1;
            // 
            // lblEndHour
            // 
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.BackColor = System.Drawing.Color.Cyan;
            this.lblEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndHour.Location = new System.Drawing.Point(74, 221);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(94, 22);
            this.lblEndHour.TabIndex = 2;
            this.lblEndHour.Text = "End Hour";
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(272, 221);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(144, 22);
            this.txtEndHour.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(66, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 40);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalCost.Location = new System.Drawing.Point(300, 322);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(116, 18);
            this.lblRentalCost.TabIndex = 6;
            this.lblRentalCost.Text = "Rental Cost: 0";
            this.lblRentalCost.Click += new System.EventHandler(this.lblRentalCost_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(633, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BicycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRentalCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.lblEndHour);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.btnStartHour);
            this.Name = "BicycleForm";
            this.Text = "Bicycle_Rental_Form";
            this.Load += new System.EventHandler(this.BicycleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnStartHour;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.Button btnBack;
    }
}