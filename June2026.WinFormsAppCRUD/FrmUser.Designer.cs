namespace June2026.WinFormsAppCRUD
{
    partial class FrmUser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtBio = new TextBox();
            label3 = new Label();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colRowNo = new DataGridViewTextBoxColumn();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            colBio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { colEdit, colDelete, colRowNo, colUserId, colUsername, colPassword, colBio });
            dgvData.Dock = DockStyle.Bottom;
            dgvData.Location = new Point(0, 300);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 53;
            dgvData.Size = new Size(800, 150);
            dgvData.TabIndex = 6;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 38);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 94);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(61, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 30);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(191, 201);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(156, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 35);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(171, 29);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 91);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 29);
            txtPassword.TabIndex = 2;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(176, 147);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(171, 29);
            txtBio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 155);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 7;
            label3.Text = "Bio";
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 7;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 7;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // colRowNo
            // 
            colRowNo.DataPropertyName = "RowNo";
            colRowNo.HeaderText = "Row No";
            colRowNo.MinimumWidth = 7;
            colRowNo.Name = "colRowNo";
            colRowNo.ReadOnly = true;
            // 
            // colUserId
            // 
            colUserId.DataPropertyName = "UserId";
            colUserId.HeaderText = "User Id";
            colUserId.MinimumWidth = 7;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Visible = false;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 7;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "password";
            colPassword.HeaderText = "Password";
            colPassword.MinimumWidth = 7;
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            // 
            // colBio
            // 
            colBio.DataPropertyName = "bio";
            colBio.HeaderText = "Bio";
            colBio.MinimumWidth = 7;
            colBio.Name = "colBio";
            colBio.ReadOnly = true;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBio);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Name = "FrmUser";
            Text = "Form1";
            Load += FrmUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtBio;
        private Label label3;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colRowNo;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn colBio;
    }
}
