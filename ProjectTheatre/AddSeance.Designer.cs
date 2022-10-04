
namespace ProjectTheatre
{
    partial class AddSeance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSeance));
            this.DataSeans = new System.Windows.Forms.MaskedTextBox();
            this.NSeans = new System.Windows.Forms.MaskedTextBox();
            this.AddT = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataSeans
            // 
            this.DataSeans.Location = new System.Drawing.Point(104, 174);
            this.DataSeans.Mask = "00/00/0000 90:00";
            this.DataSeans.Name = "DataSeans";
            this.DataSeans.Size = new System.Drawing.Size(179, 20);
            this.DataSeans.TabIndex = 10;
            this.DataSeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DataSeans.ValidatingType = typeof(System.DateTime);
            // 
            // NSeans
            // 
            this.NSeans.Location = new System.Drawing.Point(104, 73);
            this.NSeans.Name = "NSeans";
            this.NSeans.Size = new System.Drawing.Size(179, 20);
            this.NSeans.TabIndex = 9;
            this.NSeans.Text = "Name Theatre";
            this.NSeans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddT
            // 
            this.AddT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddT.Location = new System.Drawing.Point(104, 279);
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(73, 23);
            this.AddT.TabIndex = 13;
            this.AddT.Text = "Add";
            this.AddT.UseVisualStyleBackColor = true;
            this.AddT.Click += new System.EventHandler(this.AddT_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(210, 279);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(73, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTheatre.Properties.Resources.cd77a8_berserk_manga_panel;
            this.ClientSize = new System.Drawing.Size(392, 341);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddT);
            this.Controls.Add(this.DataSeans);
            this.Controls.Add(this.NSeans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSeance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theatre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.MaskedTextBox DataSeans;
        protected internal System.Windows.Forms.MaskedTextBox NSeans;
        private System.Windows.Forms.Button AddT;
        private System.Windows.Forms.Button Cancel;
    }
}