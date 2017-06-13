namespace DomowyFastFood
{
    partial class frmUserControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserControlPanel));
            this.lblSyncInfo = new System.Windows.Forms.Label();
            this.lblSyncTitle = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.dgvRestaurant = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSyncInfo
            // 
            this.lblSyncInfo.AutoSize = true;
            this.lblSyncInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSyncInfo.Location = new System.Drawing.Point(160, 318);
            this.lblSyncInfo.Name = "lblSyncInfo";
            this.lblSyncInfo.Size = new System.Drawing.Size(11, 15);
            this.lblSyncInfo.TabIndex = 8;
            this.lblSyncInfo.Text = "-";
            // 
            // lblSyncTitle
            // 
            this.lblSyncTitle.AutoSize = true;
            this.lblSyncTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSyncTitle.Location = new System.Drawing.Point(12, 318);
            this.lblSyncTitle.Name = "lblSyncTitle";
            this.lblSyncTitle.Size = new System.Drawing.Size(139, 15);
            this.lblSyncTitle.TabIndex = 7;
            this.lblSyncTitle.Text = "Ostatnia Synchronizacja:";
            // 
            // btnSync
            // 
            this.btnSync.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSync.Location = new System.Drawing.Point(466, 318);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(94, 23);
            this.btnSync.TabIndex = 6;
            this.btnSync.Text = "Synchronizuj";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrder.Location = new System.Drawing.Point(590, 318);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Zamów!";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // dgvRestaurant
            // 
            this.dgvRestaurant.AllowUserToAddRows = false;
            this.dgvRestaurant.AllowUserToDeleteRows = false;
            this.dgvRestaurant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRestaurant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurant.Location = new System.Drawing.Point(12, 12);
            this.dgvRestaurant.Name = "dgvRestaurant";
            this.dgvRestaurant.ReadOnly = true;
            this.dgvRestaurant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestaurant.Size = new System.Drawing.Size(653, 266);
            this.dgvRestaurant.TabIndex = 9;
            this.dgvRestaurant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestaurant_CellContentClick);
            // 
            // frmUserControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 363);
            this.Controls.Add(this.dgvRestaurant);
            this.Controls.Add(this.lblSyncInfo);
            this.Controls.Add(this.lblSyncTitle);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUserControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domowy Fast Food";
            this.Load += new System.EventHandler(this.frmUserControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSyncInfo;
        private System.Windows.Forms.Label lblSyncTitle;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridView dgvRestaurant;
    }
}