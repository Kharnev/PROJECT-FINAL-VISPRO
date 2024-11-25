namespace PROJECT_FINAL_VISPRO
{
    partial class FormDashAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashAdmin));
            this.picDash = new System.Windows.Forms.PictureBox();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnResProf = new System.Windows.Forms.Button();
            this.btnDorm = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnUserManage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDash)).BeginInit();
            this.SuspendLayout();
            // 
            // picDash
            // 
            this.picDash.Image = ((System.Drawing.Image)(resources.GetObject("picDash.Image")));
            this.picDash.Location = new System.Drawing.Point(1, 1);
            this.picDash.Name = "picDash";
            this.picDash.Size = new System.Drawing.Size(1920, 1080);
            this.picDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDash.TabIndex = 0;
            this.picDash.TabStop = false;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Indigo;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Location = new System.Drawing.Point(55, 201);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(150, 35);
            this.btnDash.TabIndex = 1;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnResProf
            // 
            this.btnResProf.BackColor = System.Drawing.Color.Indigo;
            this.btnResProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResProf.ForeColor = System.Drawing.Color.White;
            this.btnResProf.Location = new System.Drawing.Point(55, 302);
            this.btnResProf.Name = "btnResProf";
            this.btnResProf.Size = new System.Drawing.Size(150, 35);
            this.btnResProf.TabIndex = 2;
            this.btnResProf.Text = "Resident Profile";
            this.btnResProf.UseVisualStyleBackColor = false;
            this.btnResProf.Click += new System.EventHandler(this.btnResProf_Click);
            // 
            // btnDorm
            // 
            this.btnDorm.BackColor = System.Drawing.Color.Indigo;
            this.btnDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDorm.ForeColor = System.Drawing.Color.White;
            this.btnDorm.Location = new System.Drawing.Point(55, 402);
            this.btnDorm.Name = "btnDorm";
            this.btnDorm.Size = new System.Drawing.Size(150, 35);
            this.btnDorm.TabIndex = 3;
            this.btnDorm.Text = "Dormitories";
            this.btnDorm.UseVisualStyleBackColor = false;
            this.btnDorm.Click += new System.EventHandler(this.btnDorm_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.BackColor = System.Drawing.Color.Indigo;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Location = new System.Drawing.Point(55, 500);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(150, 35);
            this.btnFinance.TabIndex = 4;
            this.btnFinance.Text = "Finance";
            this.btnFinance.UseVisualStyleBackColor = false;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnUserManage
            // 
            this.btnUserManage.BackColor = System.Drawing.Color.Indigo;
            this.btnUserManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManage.ForeColor = System.Drawing.Color.White;
            this.btnUserManage.Location = new System.Drawing.Point(913, 653);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Size = new System.Drawing.Size(308, 42);
            this.btnUserManage.TabIndex = 5;
            this.btnUserManage.Text = "User Management";
            this.btnUserManage.UseVisualStyleBackColor = false;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // FormDashAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnUserManage);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.btnDorm);
            this.Controls.Add(this.btnResProf);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.picDash);
            this.Name = "FormDashAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picDash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDash;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnResProf;
        private System.Windows.Forms.Button btnDorm;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnUserManage;
    }
}