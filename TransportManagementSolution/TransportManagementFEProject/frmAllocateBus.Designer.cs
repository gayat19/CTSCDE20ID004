
namespace TransportManagementFEProject
{
    partial class frmAllocateBus
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
            this.components = new System.ComponentModel.Container();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.ddlBusNumbers = new System.Windows.Forms.ComboBox();
            this.btnFetchBus = new System.Windows.Forms.Button();
            this.btnAllocate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(430, 21);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(618, 18);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 26);
            this.txtEmployeeId.TabIndex = 1;
            this.txtEmployeeId.TextChanged += new System.EventHandler(this.txtEmployeeId_TextChanged);
            // 
            // ddlBusNumbers
            // 
            this.ddlBusNumbers.FormattingEnabled = true;
            this.ddlBusNumbers.Location = new System.Drawing.Point(618, 77);
            this.ddlBusNumbers.Name = "ddlBusNumbers";
            this.ddlBusNumbers.Size = new System.Drawing.Size(121, 28);
            this.ddlBusNumbers.TabIndex = 2;
            this.ddlBusNumbers.Visible = false;
            // 
            // btnFetchBus
            // 
            this.btnFetchBus.Location = new System.Drawing.Point(818, 21);
            this.btnFetchBus.Name = "btnFetchBus";
            this.btnFetchBus.Size = new System.Drawing.Size(127, 36);
            this.btnFetchBus.TabIndex = 3;
            this.btnFetchBus.Text = "Get Bus";
            this.btnFetchBus.UseVisualStyleBackColor = true;
            this.btnFetchBus.Click += new System.EventHandler(this.btnFetchBus_Click);
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(618, 138);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(135, 38);
            this.btnAllocate.TabIndex = 4;
            this.btnAllocate.Text = "Allot Bus";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAllocateBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 450);
            this.Controls.Add(this.btnAllocate);
            this.Controls.Add(this.btnFetchBus);
            this.Controls.Add(this.ddlBusNumbers);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblEmployeeId);
            this.Name = "frmAllocateBus";
            this.Text = "frmAllocateBus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.ComboBox ddlBusNumbers;
        private System.Windows.Forms.Button btnFetchBus;
        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Timer timer1;
    }
}