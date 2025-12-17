namespace CustomerDbWinForms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private Label lblFirstName;
    private TextBox txtFirstName;
    private Label lblLastName;
    private TextBox txtLastName;
    private Label lblEmail;
    private TextBox txtEmail;
    private Button btnAdd;
    private Button btnList;
    private Label lblUpdateId;
    private TextBox txtUpdateId;
    private Label lblNewEmail;
    private TextBox txtNewEmail;
    private Button btnUpdate;
    private Label lblDeleteId;
    private TextBox txtDeleteId;
    private Button btnDelete;
    private ListBox lstCustomers;
    private StatusStrip statusStrip1;
    private ToolStripLabel lblStatus;

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
        lblFirstName = new Label();
        txtFirstName = new TextBox();
        lblLastName = new Label();
        txtLastName = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        btnAdd = new Button();
        btnList = new Button();
        lblUpdateId = new Label();
        txtUpdateId = new TextBox();
        lblNewEmail = new Label();
        txtNewEmail = new TextBox();
        btnUpdate = new Button();
        lblDeleteId = new Label();
        txtDeleteId = new TextBox();
        btnDelete = new Button();
        lstCustomers = new ListBox();
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripLabel();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        //
        // lblFirstName
        //
        lblFirstName.AutoSize = true;
        lblFirstName.Location = new Point(12, 15);
        lblFirstName.Name = "lblFirstName";
        lblFirstName.Size = new Size(58, 15);
        lblFirstName.TabIndex = 0;
        lblFirstName.Text = "First Name";
        //
        // txtFirstName
        //
        txtFirstName.Location = new Point(12, 33);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(100, 23);
        txtFirstName.TabIndex = 1;
        //
        // lblLastName
        //
        lblLastName.AutoSize = true;
        lblLastName.Location = new Point(118, 15);
        lblLastName.Name = "lblLastName";
        lblLastName.Size = new Size(57, 15);
        lblLastName.TabIndex = 2;
        lblLastName.Text = "Last Name";
        //
        // txtLastName
        //
        txtLastName.Location = new Point(118, 33);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(100, 23);
        txtLastName.TabIndex = 3;
        //
        // lblEmail
        //
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(224, 15);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(32, 15);
        lblEmail.TabIndex = 4;
        lblEmail.Text = "Email";
        //
        // txtEmail
        //
        txtEmail.Location = new Point(224, 33);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(150, 23);
        txtEmail.TabIndex = 5;
        //
        // btnAdd
        //
        btnAdd.Location = new Point(380, 33);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        //
        // btnList
        //
        btnList.Location = new Point(461, 33);
        btnList.Name = "btnList";
        btnList.Size = new Size(75, 23);
        btnList.TabIndex = 7;
        btnList.Text = "List";
        btnList.UseVisualStyleBackColor = true;
        btnList.Click += btnList_Click;
        //
        // lblUpdateId
        //
        lblUpdateId.AutoSize = true;
        lblUpdateId.Location = new Point(12, 75);
        lblUpdateId.Name = "lblUpdateId";
        lblUpdateId.Size = new Size(17, 15);
        lblUpdateId.TabIndex = 8;
        lblUpdateId.Text = "ID";
        //
        // txtUpdateId
        //
        txtUpdateId.Location = new Point(12, 93);
        txtUpdateId.Name = "txtUpdateId";
        txtUpdateId.Size = new Size(50, 23);
        txtUpdateId.TabIndex = 9;
        //
        // lblNewEmail
        //
        lblNewEmail.AutoSize = true;
        lblNewEmail.Location = new Point(68, 75);
        lblNewEmail.Name = "lblNewEmail";
        lblNewEmail.Size = new Size(54, 15);
        lblNewEmail.TabIndex = 10;
        lblNewEmail.Text = "New Email";
        //
        // txtNewEmail
        //
        txtNewEmail.Location = new Point(68, 93);
        txtNewEmail.Name = "txtNewEmail";
        txtNewEmail.Size = new Size(150, 23);
        txtNewEmail.TabIndex = 11;
        //
        // btnUpdate
        //
        btnUpdate.Location = new Point(224, 93);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 12;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        //
        // lblDeleteId
        //
        lblDeleteId.AutoSize = true;
        lblDeleteId.Location = new Point(12, 135);
        lblDeleteId.Name = "lblDeleteId";
        lblDeleteId.Size = new Size(17, 15);
        lblDeleteId.TabIndex = 13;
        lblDeleteId.Text = "ID";
        //
        // txtDeleteId
        //
        txtDeleteId.Location = new Point(12, 153);
        txtDeleteId.Name = "txtDeleteId";
        txtDeleteId.Size = new Size(50, 23);
        txtDeleteId.TabIndex = 14;
        //
        // btnDelete
        //
        btnDelete.Location = new Point(68, 153);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(75, 23);
        btnDelete.TabIndex = 15;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        //
        // lstCustomers
        //
        lstCustomers.FormattingEnabled = true;
        lstCustomers.ItemHeight = 15;
        lstCustomers.Location = new Point(12, 195);
        lstCustomers.Name = "lstCustomers";
        lstCustomers.Size = new Size(760, 200);
        lstCustomers.TabIndex = 16;
        //
        // statusStrip1
        //
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
        statusStrip1.Location = new Point(0, 397);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(800, 22);
        statusStrip1.TabIndex = 17;
        statusStrip1.Text = "statusStrip1";
        //
        // lblStatus
        //
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(39, 17);
        lblStatus.Text = "Ready";
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 419);
        Controls.Add(statusStrip1);
        Controls.Add(lstCustomers);
        Controls.Add(btnDelete);
        Controls.Add(txtDeleteId);
        Controls.Add(lblDeleteId);
        Controls.Add(btnUpdate);
        Controls.Add(txtNewEmail);
        Controls.Add(lblNewEmail);
        Controls.Add(txtUpdateId);
        Controls.Add(lblUpdateId);
        Controls.Add(btnList);
        Controls.Add(btnAdd);
        Controls.Add(txtEmail);
        Controls.Add(lblEmail);
        Controls.Add(txtLastName);
        Controls.Add(lblLastName);
        Controls.Add(txtFirstName);
        Controls.Add(lblFirstName);
        Name = "Form1";
        Text = "Customer Database Management";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
