namespace mtechTest.Windows
{
    partial class mainForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label rFCLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.employeeBS = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDGView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bClear = new System.Windows.Forms.Button();
            this.bFilter = new System.Windows.Forms.Button();
            this.filterName = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.eBornDate = new System.Windows.Forms.DateTimePicker();
            this.eStatus = new System.Windows.Forms.ComboBox();
            this.eRFC = new System.Windows.Forms.TextBox();
            this.eLastName = new System.Windows.Forms.TextBox();
            this.eName = new System.Windows.Forms.TextBox();
            this.eID = new System.Windows.Forms.NumericUpDown();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bornDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            rFCLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eID)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(7, 9);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 19);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(131, 9);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(48, 19);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(385, 9);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(77, 19);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // rFCLabel
            // 
            rFCLabel.AutoSize = true;
            rFCLabel.Location = new System.Drawing.Point(8, 57);
            rFCLabel.Name = "rFCLabel";
            rFCLabel.Size = new System.Drawing.Size(36, 19);
            rFCLabel.TabIndex = 7;
            rFCLabel.Text = "RFC:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(289, 57);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(50, 19);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(133, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 19);
            label1.TabIndex = 12;
            label1.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(254, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 19);
            label2.TabIndex = 20;
            label2.Text = "Filter by Name:";
            // 
            // employeeBS
            // 
            this.employeeBS.DataSource = typeof(mtechTest.Employee);
            this.employeeBS.Sort = "BornDate";
            this.employeeBS.CurrentChanged += new System.EventHandler(this.employeeBS_CurrentChanged);
            // 
            // employeeDGView
            // 
            this.employeeDGView.AllowUserToAddRows = false;
            this.employeeDGView.AllowUserToDeleteRows = false;
            this.employeeDGView.AllowUserToResizeRows = false;
            this.employeeDGView.AutoGenerateColumns = false;
            this.employeeDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.rFCDataGridViewTextBoxColumn,
            this.bornDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.employeeDGView.DataSource = this.employeeBS;
            this.employeeDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDGView.Location = new System.Drawing.Point(0, 163);
            this.employeeDGView.Margin = new System.Windows.Forms.Padding(2);
            this.employeeDGView.Name = "employeeDGView";
            this.employeeDGView.ReadOnly = true;
            this.employeeDGView.RowHeadersVisible = false;
            this.employeeDGView.RowHeadersWidth = 51;
            this.employeeDGView.RowTemplate.Height = 24;
            this.employeeDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDGView.Size = new System.Drawing.Size(765, 408);
            this.employeeDGView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bClear);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.bFilter);
            this.panel1.Controls.Add(this.filterName);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.eBornDate);
            this.panel1.Controls.Add(statusLabel);
            this.panel1.Controls.Add(this.eStatus);
            this.panel1.Controls.Add(rFCLabel);
            this.panel1.Controls.Add(this.eRFC);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.eLastName);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.eName);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.eID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 163);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(678, 110);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 45);
            this.bClear.TabIndex = 21;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bFilter
            // 
            this.bFilter.Location = new System.Drawing.Point(597, 110);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(75, 45);
            this.bFilter.TabIndex = 19;
            this.bFilter.Text = "Filter";
            this.bFilter.UseVisualStyleBackColor = true;
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // filterName
            // 
            this.filterName.Location = new System.Drawing.Point(360, 121);
            this.filterName.Margin = new System.Windows.Forms.Padding(2);
            this.filterName.MinimumSize = new System.Drawing.Size(4, 25);
            this.filterName.Name = "filterName";
            this.filterName.Size = new System.Drawing.Size(232, 25);
            this.filterName.TabIndex = 18;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(173, 110);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 45);
            this.bDelete.TabIndex = 17;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(92, 110);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 45);
            this.bEdit.TabIndex = 16;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(11, 110);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 45);
            this.bNew.TabIndex = 15;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(483, 60);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 45);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(564, 60);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 45);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // eBornDate
            // 
            this.eBornDate.CustomFormat = "";
            this.eBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eBornDate.Location = new System.Drawing.Point(137, 79);
            this.eBornDate.Name = "eBornDate";
            this.eBornDate.Size = new System.Drawing.Size(150, 25);
            this.eBornDate.TabIndex = 10;
            // 
            // eStatus
            // 
            this.eStatus.FormattingEnabled = true;
            this.eStatus.Items.AddRange(new object[] {
            "Not Set",
            "Active",
            "Inactive"});
            this.eStatus.Location = new System.Drawing.Point(293, 79);
            this.eStatus.Name = "eStatus";
            this.eStatus.Size = new System.Drawing.Size(120, 25);
            this.eStatus.TabIndex = 11;
            this.eStatus.SelectedIndexChanged += new System.EventHandler(this.eStatus_SelectedIndexChanged);
            // 
            // eRFC
            // 
            this.eRFC.Location = new System.Drawing.Point(12, 79);
            this.eRFC.MinimumSize = new System.Drawing.Size(4, 25);
            this.eRFC.Name = "eRFC";
            this.eRFC.Size = new System.Drawing.Size(119, 25);
            this.eRFC.TabIndex = 8;
            this.eRFC.Text = "MMMM8888MMM";
            // 
            // eLastName
            // 
            this.eLastName.Location = new System.Drawing.Point(389, 30);
            this.eLastName.Margin = new System.Windows.Forms.Padding(2);
            this.eLastName.MinimumSize = new System.Drawing.Size(4, 25);
            this.eLastName.Name = "eLastName";
            this.eLastName.Size = new System.Drawing.Size(250, 25);
            this.eLastName.TabIndex = 6;
            // 
            // eName
            // 
            this.eName.Location = new System.Drawing.Point(135, 30);
            this.eName.Margin = new System.Windows.Forms.Padding(2);
            this.eName.MinimumSize = new System.Drawing.Size(4, 25);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(250, 25);
            this.eName.TabIndex = 4;
            // 
            // eID
            // 
            this.eID.Location = new System.Drawing.Point(11, 30);
            this.eID.Margin = new System.Windows.Forms.Padding(2);
            this.eID.Name = "eID";
            this.eID.Size = new System.Drawing.Size(120, 25);
            this.eID.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            this.rFCDataGridViewTextBoxColumn.ReadOnly = true;
            this.rFCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rFCDataGridViewTextBoxColumn.Width = 120;
            // 
            // bornDateDataGridViewTextBoxColumn
            // 
            this.bornDateDataGridViewTextBoxColumn.DataPropertyName = "BornDate";
            this.bornDateDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.bornDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bornDateDataGridViewTextBoxColumn.Name = "bornDateDataGridViewTextBoxColumn";
            this.bornDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bornDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 571);
            this.Controls.Add(this.employeeDGView);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBS;
        private System.Windows.Forms.DataGridView employeeDGView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox eName;
        private System.Windows.Forms.NumericUpDown eID;
        private System.Windows.Forms.TextBox eLastName;
        private System.Windows.Forms.ComboBox eStatus;
        private System.Windows.Forms.TextBox eRFC;
        private System.Windows.Forms.DateTimePicker eBornDate;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bFilter;
        private System.Windows.Forms.TextBox filterName;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bornDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}