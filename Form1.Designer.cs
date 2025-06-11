namespace DeadlockDetection
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up
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
            this.txtProcesses = new System.Windows.Forms.TextBox();
            this.txtResources = new System.Windows.Forms.TextBox();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.dgvAllocation = new System.Windows.Forms.DataGridView();
            this.dgvMax = new System.Windows.Forms.DataGridView();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.btnBankers = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.dgvNeed = new System.Windows.Forms.DataGridView();
            this.lblNeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeed)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProcesses
            // 
            this.txtProcesses.Location = new System.Drawing.Point(156, 14);
            this.txtProcesses.Name = "txtProcesses";
            this.txtProcesses.Size = new System.Drawing.Size(93, 26);
            this.txtProcesses.TabIndex = 0;
            // 
            // txtResources
            // 
            this.txtResources.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResources.Location = new System.Drawing.Point(405, 16);
            this.txtResources.Name = "txtResources";
            this.txtResources.Size = new System.Drawing.Size(95, 26);
            this.txtResources.TabIndex = 1;
            this.txtResources.TextChanged += new System.EventHandler(this.txtResources_TextChanged);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInitialize.Location = new System.Drawing.Point(626, 12);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(165, 36);
            this.btnInitialize.TabIndex = 2;
            this.btnInitialize.Text = "Initialize Matrices";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // dgvAllocation
            // 
            this.dgvAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocation.Location = new System.Drawing.Point(26, 104);
            this.dgvAllocation.Name = "dgvAllocation";
            this.dgvAllocation.RowHeadersWidth = 62;
            this.dgvAllocation.Size = new System.Drawing.Size(309, 174);
            this.dgvAllocation.TabIndex = 3;
            // 
            // dgvMax
            // 
            this.dgvMax.AllowUserToOrderColumns = true;
            this.dgvMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMax.Location = new System.Drawing.Point(341, 104);
            this.dgvMax.Name = "dgvMax";
            this.dgvMax.RowHeadersWidth = 62;
            this.dgvMax.Size = new System.Drawing.Size(311, 174);
            this.dgvMax.TabIndex = 4;
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(658, 104);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.RowHeadersWidth = 62;
            this.dgvAvailable.Size = new System.Drawing.Size(301, 63);
            this.dgvAvailable.TabIndex = 5;
            this.dgvAvailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailable_CellContentClick);
            // 
            // dgvNeed
            // 
            this.dgvNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeed.Location = new System.Drawing.Point(965, 104);
            this.dgvNeed.Name = "dgvNeed";
            this.dgvNeed.RowHeadersWidth = 62;
            this.dgvNeed.Size = new System.Drawing.Size(301, 174);
            this.dgvNeed.TabIndex = 6;
            this.dgvNeed.Visible = false;
            // 
            // btnBankers
            // 
            this.btnBankers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBankers.Location = new System.Drawing.Point(569, 313);
            this.btnBankers.Name = "btnBankers";
            this.btnBankers.Size = new System.Drawing.Size(184, 45);
            this.btnBankers.TabIndex = 6;
            this.btnBankers.Text = "Run Banker\'s Algorithm";
            this.btnBankers.UseVisualStyleBackColor = true;
            this.btnBankers.Click += new System.EventHandler(this.btnBankers_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(21, 423);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(730, 60);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result will be shown here...";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. of Processes:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(281, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of resources:";
            // 
            // lblAllocation
            // 
            this.lblAllocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAllocation.Location = new System.Drawing.Point(21, 81);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(100, 20);
            this.lblAllocation.TabIndex = 2;
            this.lblAllocation.Text = "Allocation:";
            // 
            // lblMax
            // 
            this.lblMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMax.Location = new System.Drawing.Point(336, 81);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 20);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Max";
            this.lblMax.Click += new System.EventHandler(this.lblMax_Click);
            // 
            // lblAvailable
            // 
            this.lblAvailable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvailable.Location = new System.Drawing.Point(653, 81);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(100, 20);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "Available:";
            // 
            // lblNeed
            // 
            this.lblNeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNeed.Location = new System.Drawing.Point(960, 81);
            this.lblNeed.Name = "lblNeed";
            this.lblNeed.Size = new System.Drawing.Size(100, 20);
            this.lblNeed.TabIndex = 5;
            this.lblNeed.Text = "Need:";
            this.lblNeed.Visible = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1290, 585);
            this.Controls.Add(this.lblNeed);
            this.Controls.Add(this.dgvNeed);
            this.Controls.Add(this.dgvMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAllocation);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dgvAvailable);
            this.Controls.Add(this.dgvAllocation);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.txtResources);
            this.Controls.Add(this.txtProcesses);
            this.Controls.Add(this.btnBankers);
            this.Name = "Form1";
            this.Text = "Deadlock Detection and Avoidance - Banker\'s Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcesses;
        private System.Windows.Forms.TextBox txtResources;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.DataGridView dgvAllocation;
        private System.Windows.Forms.DataGridView dgvMax;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.DataGridView dgvNeed;
        private System.Windows.Forms.Button btnBankers;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblNeed;

    }
}
