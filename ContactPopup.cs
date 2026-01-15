using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactListManager
{
    public partial class ContactPopup : Form
    {
        public string contactName = "";
        public string contactEmail = "";
        public string contactPhone = "";
        public ContactPopup()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            contactName = txtName.Text;
            contactEmail = txtEmail.Text;
            contactPhone = txtPhoneNumber.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }


        
    }
}
