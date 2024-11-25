namespace PROJECT_FINAL_VISPRO
{
    partial class FormDormCrystal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDormCrystal));
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnDorm = new System.Windows.Forms.Button();
            this.btnResProf = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInputBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinance
            // 
            this.btnFinance.BackColor = System.Drawing.Color.Indigo;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Location = new System.Drawing.Point(55, 500);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(150, 35);
            this.btnFinance.TabIndex = 68;
            this.btnFinance.Text = "Finance";
            this.btnFinance.UseVisualStyleBackColor = false;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnDorm
            // 
            this.btnDorm.BackColor = System.Drawing.Color.Indigo;
            this.btnDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDorm.ForeColor = System.Drawing.Color.White;
            this.btnDorm.Location = new System.Drawing.Point(55, 402);
            this.btnDorm.Name = "btnDorm";
            this.btnDorm.Size = new System.Drawing.Size(150, 35);
            this.btnDorm.TabIndex = 67;
            this.btnDorm.Text = "Dormitories";
            this.btnDorm.UseVisualStyleBackColor = false;
            this.btnDorm.Click += new System.EventHandler(this.btnDorm_Click);
            // 
            // btnResProf
            // 
            this.btnResProf.BackColor = System.Drawing.Color.Indigo;
            this.btnResProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResProf.ForeColor = System.Drawing.Color.White;
            this.btnResProf.Location = new System.Drawing.Point(55, 301);
            this.btnResProf.Name = "btnResProf";
            this.btnResProf.Size = new System.Drawing.Size(150, 35);
            this.btnResProf.TabIndex = 66;
            this.btnResProf.Text = "Resident Profile";
            this.btnResProf.UseVisualStyleBackColor = false;
            this.btnResProf.Click += new System.EventHandler(this.btnResProf_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Indigo;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Location = new System.Drawing.Point(55, 201);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(150, 35);
            this.btnDash.TabIndex = 65;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(77, 943);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 47);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInputBooking
            // 
            this.btnInputBooking.BackColor = System.Drawing.Color.Indigo;
            this.btnInputBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputBooking.ForeColor = System.Drawing.Color.White;
            this.btnInputBooking.Location = new System.Drawing.Point(997, 973);
            this.btnInputBooking.Name = "btnInputBooking";
            this.btnInputBooking.Size = new System.Drawing.Size(327, 56);
            this.btnInputBooking.TabIndex = 70;
            this.btnInputBooking.Text = "Pilih Jenis Asrama Crystal";
            this.btnInputBooking.UseVisualStyleBackColor = false;
            this.btnInputBooking.Click += new System.EventHandler(this.btnInputBooking_Click);
            // 
            // FormDormCrystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnInputBooking);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.btnDorm);
            this.Controls.Add(this.btnResProf);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDormCrystal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDormCrystal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDormCrystal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnDorm;
        private System.Windows.Forms.Button btnResProf;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInputBooking;
    }
}