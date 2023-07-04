using CodeFirst_PhoneBook.Context;
using CodeFirst_PhoneBook.Entities;

namespace CodeFirst_PhoneBook
{
    public partial class Form1 : Form
    {
        PhoneDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new PhoneDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewEdit();
            ListFill(db.Contacts.ToList());
            btnSearch.Enabled = db.Contacts.Count() > 0;
            btnUpdate.Enabled = false;
        }
        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string name = btn.Name;
            switch (name)
            {
                case "btnAdd": Create(); break;
                case "btnUpdate": BtnUpdate(); break;
                case "btnSearch": Search(); break;
                case "btnRefresh": BtnRefresh(); break;
            }
        }

        /// <summary>
        /// Yenileme butonu metodu
        /// </summary>
        private void BtnRefresh()
        {
            ListFill(db.Contacts.ToList());
        }

        /// <summary>
        /// Arama butonu metodu
        /// </summary>
        private void Search()
        {
            string filter = txtSearch.Text.Trim();
            List<Contact> filterContacts = db.Contacts.Where(x => x.FirstName.Contains(filter) || x.LastName.Contains(filter)).ToList();
            ListFill(filterContacts);
            ClearPanelItem(pnlFind);
        }

        /// <summary>
        /// Güncelleme butonu metodu
        /// </summary>
        private void BtnUpdate()
        {
            string firstname = txtFirstName.Text.Trim(),
                lastname = txtLastName.Text.Trim(),
                phoneNumber = txtPhone.Text.Trim();
            bool isEmpty = string.IsNullOrEmpty(firstname)
                        || string.IsNullOrEmpty(lastname)
                        || string.IsNullOrEmpty(phoneNumber);
            try
            {
                if (isEmpty)
                {
                    MessageBox.Show("Lütfen boş alanları doldurun!");
                    return;
                }
                else
                {
                    selectedContact.FirstName = firstname;
                    selectedContact.LastName = lastname;
                    selectedContact.Phone = phoneNumber;
                    db.SaveChanges();
                    MessageBox.Show("Güncelleme Başarılı");
                    ListFill(db.Contacts.ToList());
                    ClearPanelItem(pnlSave);
                    selectedContact = null;
                    btnAdd.Enabled = btnSearch.Enabled = true;
                    btnUpdate.Enabled = false;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi başarısız");
            }

        }

        /// <summary>
        /// Ekleme metodu
        /// </summary>
        private void Create()
        {
            string firstname = txtFirstName.Text.Trim(),
                lastname = txtLastName.Text.Trim(),
                phoneNumber = txtPhone.Text.Trim();
            bool isEmpty = string.IsNullOrEmpty(firstname)
                || string.IsNullOrEmpty(lastname)
                || string.IsNullOrEmpty(phoneNumber);
            try
            {
                if (isEmpty)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!");
                    return;
                }
                Contact contact = new Contact()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Phone = phoneNumber
                };
                db.Contacts.Add(contact);
                db.SaveChanges();
                MessageBox.Show("Ekleme Başarılı");
                ListFill(db.Contacts.ToList());
                btnSearch.Enabled = true;
                ClearPanelItem(pnlSave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ekleme işlemi başarısız");
            }
        }

        private void ClearPanelItem(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// ListView içerisini database içerisindeki verilerle dolduran metot
        /// </summary>
        /// <param name="contacts"></param>
        private void ListFill(List<Contact> contacts)
        {
            lsvContactList.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = contacts[i].ID.ToString();
                item.SubItems.Add(contacts[i].FirstName);
                item.SubItems.Add(contacts[i].LastName);
                item.SubItems.Add(contacts[i].Phone);
                item.Tag = contacts[i];
                lsvContactList.Items.Add(item);
            }
        }

        /// <summary>
        /// ListView özelliklerini form başlangıcında ayarlayan metot
        /// </summary>
        private void ListViewEdit()
        {
            int width = lsvContactList.Width / 4;
            lsvContactList.View = View.Details;
            ColumnHeader[] headers =
            {
                new ColumnHeader {Name="ID", Text="ID", Width= lsvContactList.Width- 3*width, TextAlign=HorizontalAlignment.Center },
                new ColumnHeader {Name="FirstName", Text="isim", Width=width, TextAlign=HorizontalAlignment.Center },
                new ColumnHeader {Name="LastName", Text="Soyisim", Width=width, TextAlign=HorizontalAlignment.Center },
                new ColumnHeader {Name="PhoneNumber", Text="Telefon Numarası", Width=width, TextAlign=HorizontalAlignment.Center },
            };
            lsvContactList.Columns.AddRange(headers);
            lsvContactList.FullRowSelect = true;
        }

        private void lsvContactList_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button != MouseButtons.Right) { return; }
            ListViewItem focused = lsvContactList.FocusedItem;
            bool isBound = focused.Bounds.Contains(e.Location);
            if (focused == null || !isBound) { return; }
            csmMenu.Show(Cursor.Position);

        }
        private void TsmClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            string name = menuItem.Name;
            switch (name)
            {
                case "update": tsmUpdate(); break;
                case "delete": tsmDelete(); break;
            }
        }

        /// <summary>
        /// ContextMenuToolStripItem silme metodu
        /// </summary>
        private void tsmDelete()
        {
            selectedContact = lsvContactList.SelectedItems[0].Tag as Contact;
            db.Contacts.Remove(selectedContact);
            db.SaveChanges();
            MessageBox.Show("Kayıt silindi");
            ListFill(db.Contacts.ToList());
        }

        Contact selectedContact;

        /// <summary>
        /// ContextMenuToolStripItem güncelleme metodu
        /// </summary>
        private void tsmUpdate()
        {
            int count = lsvContactList.SelectedItems.Count;
            if (count <= 0) { return; }
            selectedContact = lsvContactList.SelectedItems[0].Tag as Contact;
            txtFirstName.Text = selectedContact.FirstName;
            txtLastName.Text = selectedContact.LastName;
            txtPhone.Text = selectedContact.Phone;
            btnUpdate.Enabled = true;
            btnAdd.Enabled = btnSearch.Enabled = false;
        }
    }
}