namespace RedisCRUD
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblManufacturer = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.txtManufacturer = new MetroFramework.Controls.MetroTextBox();
            this.txtModel = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(111, 83);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(44, 113);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(91, 19);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(85, 144);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 19);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "ID", true));
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(141, 79);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(114, 23);
            this.txtID.TabIndex = 0;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtManufacturer
            // 
            // 
            // 
            // 
            this.txtManufacturer.CustomButton.Image = null;
            this.txtManufacturer.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtManufacturer.CustomButton.Name = "";
            this.txtManufacturer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManufacturer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManufacturer.CustomButton.TabIndex = 1;
            this.txtManufacturer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManufacturer.CustomButton.UseSelectable = true;
            this.txtManufacturer.CustomButton.Visible = false;
            this.txtManufacturer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "Manufacturer", true));
            this.txtManufacturer.Lines = new string[0];
            this.txtManufacturer.Location = new System.Drawing.Point(141, 109);
            this.txtManufacturer.MaxLength = 32767;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.PasswordChar = '\0';
            this.txtManufacturer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManufacturer.SelectedText = "";
            this.txtManufacturer.SelectionLength = 0;
            this.txtManufacturer.SelectionStart = 0;
            this.txtManufacturer.ShortcutsEnabled = true;
            this.txtManufacturer.Size = new System.Drawing.Size(218, 23);
            this.txtManufacturer.TabIndex = 1;
            this.txtManufacturer.UseSelectable = true;
            this.txtManufacturer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManufacturer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.CustomButton.Image = null;
            this.txtModel.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtModel.CustomButton.Name = "";
            this.txtModel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModel.CustomButton.TabIndex = 1;
            this.txtModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModel.CustomButton.UseSelectable = true;
            this.txtModel.CustomButton.Visible = false;
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "Model", true));
            this.txtModel.Lines = new string[0];
            this.txtModel.Location = new System.Drawing.Point(141, 140);
            this.txtModel.MaxLength = 32767;
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModel.SelectedText = "";
            this.txtModel.SelectionLength = 0;
            this.txtModel.SelectionStart = 0;
            this.txtModel.ShortcutsEnabled = true;
            this.txtModel.Size = new System.Drawing.Size(218, 23);
            this.txtModel.TabIndex = 2;
            this.txtModel.UseSelectable = true;
            this.txtModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.phoneBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(44, 181);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(570, 182);
            this.metroGrid1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 399);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(296, 399);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(377, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 200;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataSource = typeof(RedisCRUD.Phone);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Redis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel lblManufacturer;
        private MetroFramework.Controls.MetroLabel lblModel;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroTextBox txtManufacturer;
        private MetroFramework.Controls.MetroTextBox txtModel;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}

