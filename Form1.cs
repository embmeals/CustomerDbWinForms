namespace CustomerDbWinForms;

public partial class Form1 : Form
{
    private CustomerService customerService = new CustomerService();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string email = txtEmail.Text;
        int id = customerService.CreateCustomer(firstName, lastName, email);
        lblStatus.Text = $"Customer added with ID: {id}";
        RefreshList();
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        RefreshList();
        lblStatus.Text = "Loaded customers.";
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtUpdateId.Text, out int id))
        {
            string newEmail = txtNewEmail.Text;
            bool success = customerService.UpdateCustomer(id, newEmail);
            lblStatus.Text = success ? "Customer updated." : "Update failed.";
            RefreshList();
        }
        else
        {
            lblStatus.Text = "Invalid ID.";
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtDeleteId.Text, out int id))
        {
            bool success = customerService.DeleteCustomer(id);
            lblStatus.Text = success ? "Customer deleted." : "Delete failed.";
            RefreshList();
        }
        else
        {
            lblStatus.Text = "Invalid ID.";
        }
    }

    private void RefreshList()
    {
        lstCustomers.Items.Clear();
        var customers = customerService.ListCustomers();
        foreach (var customer in customers)
        {
            lstCustomers.Items.Add(customer);
        }
    }
}
