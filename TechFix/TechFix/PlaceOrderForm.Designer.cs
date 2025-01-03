namespace TechFix
{
    partial class PlaceOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReq = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewSupplier1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewSupplier2 = new System.Windows.Forms.DataGridView();
            this.btnorder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBacktoMnu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // btnReq
            // 
            this.btnReq.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReq.Location = new System.Drawing.Point(467, 218);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(194, 33);
            this.btnReq.TabIndex = 2;
            this.btnReq.Text = "Request Quotation";
            this.btnReq.UseVisualStyleBackColor = true;
            this.btnReq.Click += new System.EventHandler(this.btnReq_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(539, 128);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(151, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(539, 179);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 22);
            this.txtQuantity.TabIndex = 4;
            // 
            // dataGridViewSupplier1
            // 
            this.dataGridViewSupplier1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSupplier1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier1.Location = new System.Drawing.Point(12, 402);
            this.dataGridViewSupplier1.Name = "dataGridViewSupplier1";
            this.dataGridViewSupplier1.RowHeadersWidth = 51;
            this.dataGridViewSupplier1.RowTemplate.Height = 24;
            this.dataGridViewSupplier1.Size = new System.Drawing.Size(561, 229);
            this.dataGridViewSupplier1.TabIndex = 5;
            // 
            // dataGridViewSupplier2
            // 
            this.dataGridViewSupplier2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewSupplier2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier2.Location = new System.Drawing.Point(653, 402);
            this.dataGridViewSupplier2.Name = "dataGridViewSupplier2";
            this.dataGridViewSupplier2.RowHeadersWidth = 51;
            this.dataGridViewSupplier2.RowTemplate.Height = 24;
            this.dataGridViewSupplier2.Size = new System.Drawing.Size(567, 229);
            this.dataGridViewSupplier2.TabIndex = 6;
            // 
            // btnorder
            // 
            this.btnorder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.Location = new System.Drawing.Point(467, 257);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(194, 36);
            this.btnorder.TabIndex = 7;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Supplier 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Supplier 2";
            // 
            // btnBacktoMnu
            // 
            this.btnBacktoMnu.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBacktoMnu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMnu.Location = new System.Drawing.Point(467, 299);
            this.btnBacktoMnu.Name = "btnBacktoMnu";
            this.btnBacktoMnu.Size = new System.Drawing.Size(194, 31);
            this.btnBacktoMnu.TabIndex = 10;
            this.btnBacktoMnu.Text = "Back to Main Menu";
            this.btnBacktoMnu.UseVisualStyleBackColor = false;
            this.btnBacktoMnu.Click += new System.EventHandler(this.btnBacktoMnu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(402, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 68);
            this.label5.TabIndex = 11;
            this.label5.Text = "Place Orders";
            // 
            // PlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1262, 674);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBacktoMnu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.dataGridViewSupplier2);
            this.Controls.Add(this.dataGridViewSupplier1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrderForm";
            this.Text = "PlaceOrderForm";
            this.Load += new System.EventHandler(this.PlaceOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReq;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DataGridView dataGridViewSupplier1;
        private System.Windows.Forms.DataGridView dataGridViewSupplier2;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBacktoMnu;
        private System.Windows.Forms.Label label5;
    }
}