namespace IgePreventiveReminder
{
    partial class HomeAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdminForm));
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userButton = new System.Windows.Forms.Button();
            this.uMButton = new System.Windows.Forms.Button();
            this.accueilButton = new System.Windows.Forms.Button();
            this.uniteMButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
            this.logOutButton.Location = new System.Drawing.Point(710, 0);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(47, 38);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.logOutButton);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 38);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Accueil";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Controls.Add(this.uMButton);
            this.panel1.Controls.Add(this.accueilButton);
            this.panel1.Location = new System.Drawing.Point(-5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 538);
            this.panel1.TabIndex = 2;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.userButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.Color.Black;
            this.userButton.Image = ((System.Drawing.Image)(resources.GetObject("userButton.Image")));
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.Location = new System.Drawing.Point(3, 251);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(203, 37);
            this.userButton.TabIndex = 2;
            this.userButton.Text = "Utilisateurs";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // uMButton
            // 
            this.uMButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uMButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uMButton.ForeColor = System.Drawing.Color.Black;
            this.uMButton.Image = ((System.Drawing.Image)(resources.GetObject("uMButton.Image")));
            this.uMButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uMButton.Location = new System.Drawing.Point(3, 203);
            this.uMButton.Name = "uMButton";
            this.uMButton.Size = new System.Drawing.Size(203, 37);
            this.uMButton.TabIndex = 1;
            this.uMButton.Text = "Unité medical";
            this.uMButton.UseVisualStyleBackColor = false;
            this.uMButton.Click += new System.EventHandler(this.uMButton_Click);
            // 
            // accueilButton
            // 
            this.accueilButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.accueilButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueilButton.ForeColor = System.Drawing.Color.Black;
            this.accueilButton.Image = ((System.Drawing.Image)(resources.GetObject("accueilButton.Image")));
            this.accueilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accueilButton.Location = new System.Drawing.Point(3, 156);
            this.accueilButton.Name = "accueilButton";
            this.accueilButton.Size = new System.Drawing.Size(203, 37);
            this.accueilButton.TabIndex = 0;
            this.accueilButton.Text = "Accueil";
            this.accueilButton.UseVisualStyleBackColor = false;
            this.accueilButton.Click += new System.EventHandler(this.accueilButton_Click);
            // 
            // uniteMButton
            // 
            this.uniteMButton.Image = ((System.Drawing.Image)(resources.GetObject("uniteMButton.Image")));
            this.uniteMButton.Location = new System.Drawing.Point(273, 49);
            this.uniteMButton.Name = "uniteMButton";
            this.uniteMButton.Size = new System.Drawing.Size(400, 240);
            this.uniteMButton.TabIndex = 16;
            this.uniteMButton.UseVisualStyleBackColor = true;
            this.uniteMButton.Click += new System.EventHandler(this.uniteMButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Image = ((System.Drawing.Image)(resources.GetObject("usersButton.Image")));
            this.usersButton.Location = new System.Drawing.Point(273, 300);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(400, 240);
            this.usersButton.TabIndex = 17;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // HomeAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.uniteMButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdminForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button accueilButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button uMButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uniteMButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}