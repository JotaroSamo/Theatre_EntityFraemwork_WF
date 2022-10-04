
namespace ProjectTheatre
{
    partial class AddActors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddActors));
            this.FIO = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(69, 87);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(133, 20);
            this.FIO.TabIndex = 0;
            this.FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Role
            // 
            this.Role.Location = new System.Drawing.Point(69, 156);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(133, 20);
            this.Role.TabIndex = 1;
            this.Role.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(153, 237);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddT
            // 
            this.AddT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddT.Location = new System.Drawing.Point(47, 237);
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(73, 23);
            this.AddT.TabIndex = 15;
            this.AddT.Text = "Add";
            this.AddT.UseVisualStyleBackColor = true;
            this.AddT.Click += new System.EventHandler(this.AddT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(108, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Roled";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTheatre.Properties.Resources.cd77a8_berserk_manga_panel;
            this.ClientSize = new System.Drawing.Size(288, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddT);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.FIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddActors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theatre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddT;
        protected internal System.Windows.Forms.TextBox FIO;
        protected internal System.Windows.Forms.TextBox Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}