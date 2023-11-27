
namespace CRUDWinFormsMVP.Views
{
    partial class Derechoshumanos
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
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPagePetList = new TabPage();
            tabPagePetDetail = new TabPage();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label2 = new Label();
            dataGridView = new DataGridView();
            label3 = new Label();
            txtPetId = new TextBox();
            label4 = new Label();
            txtPetName = new TextBox();
            label5 = new Label();
            txtPetType = new TextBox();
            label6 = new Label();
            txtPetColour = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePetList.SuspendLayout();
            tabPagePetDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 56);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePetList);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 56);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(892, 411);
            tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            tabPagePetList.Controls.Add(dataGridView);
            tabPagePetList.Controls.Add(label2);
            tabPagePetList.Controls.Add(btnDelete);
            tabPagePetList.Controls.Add(btnEdit);
            tabPagePetList.Controls.Add(btnAddNew);
            tabPagePetList.Controls.Add(btnSearch);
            tabPagePetList.Controls.Add(txtSearch);
            tabPagePetList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPagePetList.Location = new Point(4, 29);
            tabPagePetList.Name = "tabPagePetList";
            tabPagePetList.Padding = new Padding(3);
            tabPagePetList.Size = new Size(884, 378);
            tabPagePetList.TabIndex = 0;
            tabPagePetList.Text = "Pet list";
            tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(btnCancel);
            tabPagePetDetail.Controls.Add(btnSave);
            tabPagePetDetail.Controls.Add(label6);
            tabPagePetDetail.Controls.Add(txtPetColour);
            tabPagePetDetail.Controls.Add(label5);
            tabPagePetDetail.Controls.Add(txtPetType);
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(txtPetName);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Controls.Add(txtPetId);
            tabPagePetDetail.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPagePetDetail.Location = new Point(4, 29);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(884, 378);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Pet detail";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(24, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(638, 26);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(668, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.Location = new Point(767, 62);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(99, 30);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add new";
            btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(767, 98);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(767, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 8);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Search pet:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(24, 63);
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(737, 307);
            dataGridView.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 31);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "Pet ID:";
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(63, 54);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(154, 29);
            txtPetId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 102);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 9;
            label4.Text = "Pet name:";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(63, 125);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(154, 29);
            txtPetName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(256, 102);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 11;
            label5.Text = "Pet type:";
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(260, 125);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(183, 29);
            txtPetType.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 175);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 13;
            label6.Text = "Pet colour:";
            // 
            // txtPetColour
            // 
            txtPetColour.Location = new Point(63, 198);
            txtPetColour.Name = "txtPetColour";
            txtPetColour.Size = new Size(380, 29);
            txtPetColour.TabIndex = 12;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(260, 247);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(183, 44);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(63, 247);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 44);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(851, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 30);
            btnClose.TabIndex = 8;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 467);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePetList.ResumeLayout(false);
            tabPagePetList.PerformLayout();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPagePetList;
        private Label label2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddNew;
        private Button btnSearch;
        private TextBox txtSearch;
        private TabPage tabPagePetDetail;
        private DataGridView dataGridView;
        private Button btnCancel;
        private Button btnSave;
        private Label label6;
        private TextBox txtPetColour;
        private Label label5;
        private TextBox txtPetType;
        private Label label4;
        private TextBox txtPetName;
        private Label label3;
        private TextBox txtPetId;
        private Button btnClose;
    }
}