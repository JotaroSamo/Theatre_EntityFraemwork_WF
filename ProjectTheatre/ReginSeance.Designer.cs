
namespace ProjectTheatre
{
    partial class ReginSeance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReginSeance));
            this.nomer = new System.Windows.Forms.MaskedTextBox();
            this.countplease = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.AddT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomer
            // 
            this.nomer.Location = new System.Drawing.Point(62, 101);
            this.nomer.Mask = "+37500-000-0000";
            this.nomer.Name = "nomer";
            this.nomer.Size = new System.Drawing.Size(185, 20);
            this.nomer.TabIndex = 0;
            this.nomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countplease
            // 
            this.countplease.Location = new System.Drawing.Point(65, 212);
            this.countplease.Mask = "00000";
            this.countplease.Name = "countplease";
            this.countplease.Size = new System.Drawing.Size(185, 20);
            this.countplease.TabIndex = 1;
            this.countplease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countplease.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(75, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(168, 296);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddT
            // 
            this.AddT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddT.Location = new System.Drawing.Point(62, 296);
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(73, 23);
            this.AddT.TabIndex = 15;
            this.AddT.Text = "Add";
            this.AddT.UseVisualStyleBackColor = true;
            this.AddT.Click += new System.EventHandler(this.AddT_Click);
            // 
            // ADDNumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTheatre.Properties.Resources.cd77a8_berserk_manga_panel;
            this.ClientSize = new System.Drawing.Size(314, 353);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countplease);
            this.Controls.Add(this.nomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADDNumb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theatre";
            this.Load += new System.EventHandler(this.ADDNumb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox nomer;
        private System.Windows.Forms.MaskedTextBox countplease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AddT;
    }
}