namespace activity1
{
    partial class MainForm
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
            dgvContacts = new DataGridView();
            btnAddContact = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(166, 22);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowHeadersWidth = 62;
            dgvContacts.Size = new Size(771, 420);
            dgvContacts.TabIndex = 0;
            dgvContacts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(98, 496);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(219, 34);
            btnAddContact.TabIndex = 1;
            btnAddContact.Text = "Add Contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 617);
            Controls.Add(btnAddContact);
            Controls.Add(dgvContacts);
            Name = "MainForm";
            Text = "Contact List Manager.";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvContacts;
        private Button btnAddContact;
    }
}
