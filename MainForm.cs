using ContactListManager;
using System.Xml.Linq;

namespace activity1
{
    public partial class MainForm : Form
    {
        List<Contact> contacts = new List<Contact>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadContactsFromCSV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void LoadContactsFromCSV()
        {
            if (!File.Exists("contacts.csv"))
            {
                File.WriteAllText("contacts.csv", "Name,Email,PhoneNumber");
            }

            string[] lines = File.ReadAllLines("contacts.csv");
            contacts.Clear();

            foreach (string line in lines.Skip(1)) // Skip header
            {
                var parts = line.Split(',');

                contacts.Add(new Contact
                {
                    Name = parts[0],
                    Email = parts[1],
                    PhoneNumber = parts[2]
                });
            }

            UpdateContactGrid();
        }

        private void UpdateContactGrid()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = contacts;
        }
        private void SaveContactsToCSV()
        {

            var lines = new List<string> { "Name,Email,PhoneNumber" };

            foreach (var contact in contacts)
            {
                lines.Add($"{contact.Name},{contact.Email},{contact.PhoneNumber}");
            }

            File.WriteAllLines("contacts.csv", lines);
            MessageBox.Show("Contacts saved successfully!");
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            ContactPopup popup = new ContactPopup();
            
            if (popup.ShowDialog() == DialogResult.OK)
            {
                string contactName = popup.contactName;
                string contactEmail = popup.contactEmail;
                string contactPhone = popup.contactPhone;
                Contact contactObject = new Contact()
                {
                    Name = contactName,
                    Email = contactEmail,
                    PhoneNumber = contactPhone
                };
                contacts.Add(contactObject);
                SaveContactsToCSV();
                LoadContactsFromCSV();
            }
        }
    }
}
