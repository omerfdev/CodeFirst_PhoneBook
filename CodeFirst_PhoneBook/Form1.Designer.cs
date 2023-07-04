namespace CodeFirst_PhoneBook
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            csmMenu = new ContextMenuStrip(components);
            update = new ToolStripMenuItem();
            delete = new ToolStripMenuItem();
            pnlSave = new Panel();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlFind = new Panel();
            btnSearch = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            btnRefresh = new Button();
            lsvContactList = new ListView();
            csmMenu.SuspendLayout();
            pnlSave.SuspendLayout();
            pnlFind.SuspendLayout();
            SuspendLayout();
            // 
            // csmMenu
            // 
            csmMenu.ImageScalingSize = new Size(20, 20);
            csmMenu.Items.AddRange(new ToolStripItem[] { update, delete });
            csmMenu.Name = "csmMenu";
            csmMenu.Size = new Size(136, 52);
            // 
            // update
            // 
            update.Name = "update";
            update.Size = new Size(135, 24);
            update.Text = "Güncelle";
            update.Click += TsmClick;
            // 
            // delete
            // 
            delete.Name = "delete";
            delete.Size = new Size(135, 24);
            delete.Text = "Sil";
            delete.Click += TsmClick;
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
            pnlSave.Location = new Point(12, 12);
            pnlSave.Name = "pnlSave";
            pnlSave.Size = new Size(293, 219);
            pnlSave.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(96, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "REHBERE EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnClick;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(96, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(185, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(96, 70);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(96, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 27);
            txtFirstName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 115);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 0;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Soyadı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 39);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 0;
            label2.Text = "Adı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Yeni Oluştur";
            // 
            // pnlFind
            // 
            pnlFind.Controls.Add(btnSearch);
            pnlFind.Controls.Add(btnUpdate);
            pnlFind.Controls.Add(txtSearch);
            pnlFind.Controls.Add(label7);
            pnlFind.Controls.Add(label8);
            pnlFind.Location = new Point(320, 12);
            pnlFind.Name = "pnlFind";
            pnlFind.Size = new Size(426, 219);
            pnlFind.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(308, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(92, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "KİŞİ ARA";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(3, 160);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(185, 37);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(13, 89);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(289, 27);
            txtSearch.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 59);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 0;
            label7.Text = "Adı veya Soyadı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 0;
            label8.Text = "Bul";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 245);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 0;
            label6.Text = "REHBER";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(561, 237);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(185, 37);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "YENİLE";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnClick;
            // 
            // lsvContactList
            // 
            lsvContactList.Location = new Point(12, 282);
            lsvContactList.Name = "lsvContactList";
            lsvContactList.Size = new Size(734, 156);
            lsvContactList.TabIndex = 3;
            lsvContactList.UseCompatibleStateImageBehavior = false;
            lsvContactList.MouseClick += lsvContactList_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(lsvContactList);
            Controls.Add(btnRefresh);
            Controls.Add(pnlFind);
            Controls.Add(pnlSave);
            Controls.Add(label6);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "PhoneBookDB";
            Load += Form1_Load;
            csmMenu.ResumeLayout(false);
            pnlSave.ResumeLayout(false);
            pnlSave.PerformLayout();
            pnlFind.ResumeLayout(false);
            pnlFind.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip csmMenu;
        //       private ToolStripMenuItem tsmUpdate;
        //       private ToolStripMenuItem tsmDelete;
        private Panel pnlSave;
        private Button btnAdd;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel pnlFind;
        private Button btnSearch;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Label label7;
        private Label label8;
        private Label label6;
        private Button btnRefresh;
        private ListView lsvContactList;
        private ToolStripMenuItem update;
        private ToolStripMenuItem delete;
    }
}