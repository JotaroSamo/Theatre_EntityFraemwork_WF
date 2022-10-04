
namespace ProjectTheatre
{
    partial class ForUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForUser));
            this.TableT = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTheatreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPleaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theatreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableR = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TableT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theatreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TableT
            // 
            this.TableT.AllowUserToAddRows = false;
            this.TableT.AutoGenerateColumns = false;
            this.TableT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TableT.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.TableT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameTheatreDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.countPleaseDataGridViewTextBoxColumn});
            this.TableT.DataSource = this.theatreBindingSource;
            this.TableT.GridColor = System.Drawing.SystemColors.Control;
            this.TableT.Location = new System.Drawing.Point(12, 12);
            this.TableT.Name = "TableT";
            this.TableT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableT.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TableT.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TableT.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.TableT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableT.Size = new System.Drawing.Size(469, 339);
            this.TableT.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameTheatreDataGridViewTextBoxColumn
            // 
            this.nameTheatreDataGridViewTextBoxColumn.DataPropertyName = "NameTheatre";
            this.nameTheatreDataGridViewTextBoxColumn.HeaderText = "Seance";
            this.nameTheatreDataGridViewTextBoxColumn.Name = "nameTheatreDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // countPleaseDataGridViewTextBoxColumn
            // 
            this.countPleaseDataGridViewTextBoxColumn.DataPropertyName = "CountPlease";
            this.countPleaseDataGridViewTextBoxColumn.HeaderText = "Please";
            this.countPleaseDataGridViewTextBoxColumn.Name = "countPleaseDataGridViewTextBoxColumn";
            // 
            // theatreBindingSource
            // 
            this.theatreBindingSource.DataSource = typeof(ProjectTheatre.Theatre);
            // 
            // TableR
            // 
            this.TableR.AllowUserToAddRows = false;
            this.TableR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableR.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.TableR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TableR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.FIO,
            this.Role});
            this.TableR.GridColor = System.Drawing.SystemColors.Control;
            this.TableR.Location = new System.Drawing.Point(515, 12);
            this.TableR.Name = "TableR";
            this.TableR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableR.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TableR.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TableR.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TableR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableR.Size = new System.Drawing.Size(328, 324);
            this.TableR.TabIndex = 16;
            // 
            // num
            // 
            this.num.HeaderText = "Id";
            this.num.Name = "num";
            // 
            // FIO
            // 
            this.FIO.HeaderText = "Name";
            this.FIO.Name = "FIO";
            // 
            // Role
            // 
            this.Role.HeaderText = "Roled";
            this.Role.Name = "Role";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 367);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(469, 23);
            this.Add.TabIndex = 17;
            this.Add.Text = "Register";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.ADDRGE);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Artist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SrarchReg);
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataSource = typeof(ProjectTheatre.Admins);
            // 
            // ForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectTheatre.Properties.Resources.cd77a8_berserk_manga_panel;
            this.ClientSize = new System.Drawing.Size(865, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TableR);
            this.Controls.Add(this.TableT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theatre";
            ((System.ComponentModel.ISupportInitialize)(this.TableT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theatreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableT;
        private System.Windows.Forms.DataGridView TableR;
        private System.Windows.Forms.BindingSource theatreBindingSource;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTheatreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPleaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}