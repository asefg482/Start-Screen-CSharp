namespace Start_Screen
{
    partial class Start_Frm
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
            this.Lbl_Tbm = new System.Windows.Forms.Label();
            this.Lbl_Sofwere = new System.Windows.Forms.Label();
            this.Lbl_Loading = new System.Windows.Forms.Label();
            this.Lbl_Gruop_Name = new System.Windows.Forms.Label();
            this.Tmr_Loading = new System.Windows.Forms.Timer(this.components);
            this.Chb_Top_Most = new System.Windows.Forms.CheckBox();
            this.Tmr_Opacity = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Version = new System.Windows.Forms.Label();
            this.Lbl_Show_Morning = new System.Windows.Forms.Label();
            this.Lbl_App_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Tbm
            // 
            this.Lbl_Tbm.AutoSize = true;
            this.Lbl_Tbm.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Lbl_Tbm.Location = new System.Drawing.Point(40, 29);
            this.Lbl_Tbm.Name = "Lbl_Tbm";
            this.Lbl_Tbm.Size = new System.Drawing.Size(65, 35);
            this.Lbl_Tbm.TabIndex = 0;
            this.Lbl_Tbm.Text = "Tbm";
            this.Lbl_Tbm.Click += new System.EventHandler(this.Label1_Click);
            this.Lbl_Tbm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_Tbm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_Tbm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Lbl_Sofwere
            // 
            this.Lbl_Sofwere.AutoSize = true;
            this.Lbl_Sofwere.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl_Sofwere.Location = new System.Drawing.Point(611, 135);
            this.Lbl_Sofwere.Name = "Lbl_Sofwere";
            this.Lbl_Sofwere.Size = new System.Drawing.Size(68, 20);
            this.Lbl_Sofwere.TabIndex = 1;
            this.Lbl_Sofwere.Text = "Software";
            this.Lbl_Sofwere.Click += new System.EventHandler(this.Label2_Click);
            this.Lbl_Sofwere.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_Sofwere.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_Sofwere.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Lbl_Loading
            // 
            this.Lbl_Loading.AutoSize = true;
            this.Lbl_Loading.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Lbl_Loading.Location = new System.Drawing.Point(297, 180);
            this.Lbl_Loading.Name = "Lbl_Loading";
            this.Lbl_Loading.Size = new System.Drawing.Size(141, 35);
            this.Lbl_Loading.TabIndex = 2;
            this.Lbl_Loading.Text = "Loading . . .";
            this.Lbl_Loading.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_Loading.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_Loading.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Lbl_Gruop_Name
            // 
            this.Lbl_Gruop_Name.AutoSize = true;
            this.Lbl_Gruop_Name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Lbl_Gruop_Name.Location = new System.Drawing.Point(223, 342);
            this.Lbl_Gruop_Name.Name = "Lbl_Gruop_Name";
            this.Lbl_Gruop_Name.Size = new System.Drawing.Size(274, 28);
            this.Lbl_Gruop_Name.TabIndex = 3;
            this.Lbl_Gruop_Name.Text = "Create By Asef Qorbani Group";
            this.Lbl_Gruop_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_Gruop_Name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_Gruop_Name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Tmr_Loading
            // 
            this.Tmr_Loading.Interval = 800;
            this.Tmr_Loading.Tick += new System.EventHandler(this.Tmr_Loading_Tick);
            // 
            // Chb_Top_Most
            // 
            this.Chb_Top_Most.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Chb_Top_Most.AutoSize = true;
            this.Chb_Top_Most.ForeColor = System.Drawing.Color.White;
            this.Chb_Top_Most.Location = new System.Drawing.Point(615, 349);
            this.Chb_Top_Most.Name = "Chb_Top_Most";
            this.Chb_Top_Most.Size = new System.Drawing.Size(85, 23);
            this.Chb_Top_Most.TabIndex = 4;
            this.Chb_Top_Most.Text = "TopMost";
            this.Chb_Top_Most.UseVisualStyleBackColor = true;
            this.Chb_Top_Most.CheckedChanged += new System.EventHandler(this.Chb_Top_Most_CheckedChanged);
            // 
            // Tmr_Opacity
            // 
            this.Tmr_Opacity.Enabled = true;
            this.Tmr_Opacity.Interval = 20;
            this.Tmr_Opacity.Tick += new System.EventHandler(this.Tmr_Opacity_Tick);
            // 
            // Lbl_Version
            // 
            this.Lbl_Version.AutoSize = true;
            this.Lbl_Version.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl_Version.Location = new System.Drawing.Point(308, 219);
            this.Lbl_Version.Name = "Lbl_Version";
            this.Lbl_Version.Size = new System.Drawing.Size(91, 20);
            this.Lbl_Version.TabIndex = 5;
            this.Lbl_Version.Text = "Version 1.0.0";
            this.Lbl_Version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_Version.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_Version.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Lbl_Show_Morning
            // 
            this.Lbl_Show_Morning.AutoSize = true;
            this.Lbl_Show_Morning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Show_Morning.Location = new System.Drawing.Point(28, 324);
            this.Lbl_Show_Morning.Name = "Lbl_Show_Morning";
            this.Lbl_Show_Morning.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Show_Morning.TabIndex = 6;
            this.Lbl_Show_Morning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_Show_Morning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_Show_Morning.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Lbl_App_Name
            // 
            this.Lbl_App_Name.AutoSize = true;
            this.Lbl_App_Name.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.Lbl_App_Name.Location = new System.Drawing.Point(63, 32);
            this.Lbl_App_Name.Name = "Lbl_App_Name";
            this.Lbl_App_Name.Size = new System.Drawing.Size(592, 112);
            this.Lbl_App_Name.TabIndex = 7;
            this.Lbl_App_Name.Text = "Shop Manager";
            this.Lbl_App_Name.Click += new System.EventHandler(this.Label5_Click);
            this.Lbl_App_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Lbl_App_Name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Lbl_App_Name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-7, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 432);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-3, -7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(731, 10);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Start_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(723, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Show_Morning);
            this.Controls.Add(this.Lbl_Version);
            this.Controls.Add(this.Chb_Top_Most);
            this.Controls.Add(this.Lbl_Gruop_Name);
            this.Controls.Add(this.Lbl_Loading);
            this.Controls.Add(this.Lbl_Sofwere);
            this.Controls.Add(this.Lbl_Tbm);
            this.Controls.Add(this.Lbl_App_Name);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start_Frm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start_Frm";
            this.Load += new System.EventHandler(this.Start_Frm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Tbm;
        private System.Windows.Forms.Label Lbl_Sofwere;
        private System.Windows.Forms.Label Lbl_Loading;
        private System.Windows.Forms.Label Lbl_Gruop_Name;
        private System.Windows.Forms.Timer Tmr_Loading;
        private System.Windows.Forms.CheckBox Chb_Top_Most;
        private System.Windows.Forms.Timer Tmr_Opacity;
        private System.Windows.Forms.Label Lbl_Version;
        private System.Windows.Forms.Label Lbl_Show_Morning;
        private System.Windows.Forms.Label Lbl_App_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}