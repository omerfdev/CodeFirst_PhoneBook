namespace CodeFirst_PhoneBook
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lsvContactList = new ListView();
            btnRefresh = new Button();
            pnlFind = new Panel();
            btnSearch = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            pnlSave = new Panel();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            csmMenu = new ContextMenuStrip(components);
            update = new ToolStripMenuItem();
            delete = new ToolStripMenuItem();
            pnlFind.SuspendLayout();
            pnlSave.SuspendLayout();
            csmMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lsvContactList
            // 
            lsvContactList.Location = new Point(79, 268);
            lsvContactList.Margin = new Padding(3, 2, 3, 2);
            lsvContactList.Name = "lsvContactList";
            lsvContactList.Size = new Size(643, 118);
            lsvContactList.TabIndex = 8;
            lsvContactList.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(560, 234);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(162, 28);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "YENİLE";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // pnlFind
            // 
            pnlFind.Controls.Add(btnSearch);
            pnlFind.Controls.Add(btnUpdate);
            pnlFind.Controls.Add(txtSearch);
            pnlFind.Controls.Add(label7);
            pnlFind.Controls.Add(label8);
            pnlFind.Location = new Point(349, 65);
            pnlFind.Margin = new Padding(3, 2, 3, 2);
            pnlFind.Name = "pnlFind";
            pnlFind.Size = new Size(373, 164);
            pnlFind.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(270, 67);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 22);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "KİŞİ ARA";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(3, 120);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 28);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(11, 67);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(253, 23);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 44);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 0;
            label7.Text = "Adı veya Soyadı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 8);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 0;
            label8.Text = "Bul";
            // 
            // pnlSave
            // 
            pnlSave.Controls.Add(btnAdd);
            pnlSave.Controls.Add(txtPhone);
            pnlSave.Controls.Add(txtLastName);
            pnlSave.Controls.Add(txtFirstName);
            pnlSave.Controls.Add(label4);
            pnlSave.Controls.Add(label3);
            pnlSave.Controls.Add(label2);
            pnlSave.Controls.Add(label1);
            pnlSave.Location = new Point(79, 65);
            pnlSave.Margin = new Padding(3, 2, 3, 2);
            pnlSave.Name = "pnlSave";
            pnlSave.Size = new Size(256, 164);
            pnlSave.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(84, 120);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 28);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "REHBERE EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(84, 84);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(162, 23);
            txtPhone.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(84, 52);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(162, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(84, 27);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(162, 23);
            txtFirstName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 86);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyadı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Adı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Yeni Oluştur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(81, 240);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 4;
            label6.Text = "REHBER";
            // 
            // csmMenu
            // 
            csmMenu.ImageScalingSize = new Size(20, 20);
            csmMenu.Items.AddRange(new ToolStripItem[] { update, delete });
            csmMenu.Name = "csmMenu";
            csmMenu.Size = new Size(121, 48);
            // 
            // update
            // 
            update.Name = "update";
            update.Size = new Size(120, 22);
            update.Text = "Güncelle";
            // 
            // delete
            // 
            delete.Name = "delete";
            delete.Size = new Size(120, 22);
            delete.Text = "Sil";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lsvContactList);
            Controls.Add(btnRefresh);
            Controls.Add(pnlFind);
            Controls.Add(pnlSave);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "PhoneBook";
            pnlFind.ResumeLayout(false);
            pnlFind.PerformLayout();
            pnlSave.ResumeLayout(false);
            pnlSave.PerformLayout();
            csmMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvContactList;
        private Button btnRefresh;
        private Panel pnlFind;
        private Button btnSearch;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label label7;
        private Label label8;
        private Panel pnlSave;
        private Button btnAdd;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private ContextMenuStrip csmMenu;
        private ToolStripMenuItem update;
        private ToolStripMenuItem delete;
    }
}