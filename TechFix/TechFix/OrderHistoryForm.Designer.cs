namespace TechFix
{
    partial class OrderHistoryForm
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
            this.dgvorders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBacktoMnu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvorders
            // 
            this.dgvorders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvorders.Location = new System.Drawing.Point(99, 144);
            this.dgvorders.Name = "dgvorders";
            this.dgvorders.RowHeadersWidth = 51;
            this.dgvorders.RowTemplate.Height = 24;
            this.dgvorders.Size = new System.Drawing.Size(1109, 467);
            this.dgvorders.TabIndex = 0;
            this.dgvorders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorders_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(470, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order History";
            // 
            // btnBacktoMnu
            // 
            this.btnBacktoMnu.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBacktoMnu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMnu.Location = new System.Drawing.Point(561, 617);
            this.btnBacktoMnu.Name = "btnBacktoMnu";
            this.btnBacktoMnu.Size = new System.Drawing.Size(194, 31);
            this.btnBacktoMnu.TabIndex = 12;
            this.btnBacktoMnu.Text = "Back to Main Menu";
            this.btnBacktoMnu.UseVisualStyleBackColor = false;
            this.btnBacktoMnu.Click += new System.EventHandler(this.btnBacktoMnu_Click);
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnBacktoMnu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvorders);
            this.Name = "OrderHistoryForm";
            this.Text = "OrderHistoryForm";
            this.Load += new System.EventHandler(this.OrderHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvorders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBacktoMnu;
    }
}