using Abstraction.Interfaces.Models;
using Abstraction.Interfaces.Service;
using Domain.Models;
using Domain.Service;
using Foundation;

namespace _Forms
{
    public partial class Form1 : Form
    {

        private CustomerService customerService;
        private OrderService orderService;

        public Form1()
        {
            InitializeComponent();
            customerService = new CustomerService();
            orderService = new OrderService();
        }

        /// <summary>
        /// Saves the customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks whether or not if the Strict or Relaxed box is checked
                if (cb_Strict.Checked)
                {
                    // Initializes a new customer object
                    Customer customer = new Customer();

                    // Inputs data
                    customer.Name = tb_CustName.Text;
                    customer.Id = int.Parse(tb_Id.Text);

                    // Shows result in form of a MessageBox with CustomerService
                    MessageBox.Show(
                        customerService.SaveCustomer(customer)
                        , "Used Strict Method",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else if (cb_Relaxed.Checked)
                {
                    // Uses a relaxed function to access the method inside of SQLDB directly
                    SQLDB db = new SQLDB();

                    // Initializes a new customer object
                    Customer customer = new Customer();

                    // Inputs data
                    customer.Name = tb_CustName.Text;
                    customer.Id = int.Parse(tb_Id.Text);

                    // Shows result in form of a MessageBox
                    MessageBox.Show(
                        db.SaveCustomer(customer),
                        "Used Relaxed Method",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else
                {
                    // Tells user that no method is selected
                    MessageBox.Show(
                        "Please select a method type!",
                        "No method selected!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );
                }
            }
            catch (Exception ex)
            {
                // Throws an error, if one has occured
                MessageBox.Show(
                    ex.Message,
                    "An error occurred!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btn_SaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Initializes a new customer object
                Order order = new Order();

                if (cb_Strict.Checked)
                {
                    // Inputs data
                    order.OrderNr = int.Parse(tb_OrderId.Text);
                    order.Price = decimal.Parse(tb_OrderPrice.Text);

                    // Shows result in form of a MessageBox with orderService
                    MessageBox.Show(
                        orderService.SaveOrder(order),
                        "Used Relaxed Method",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else if (cb_Relaxed.Checked)
                {
                    // Uses a relaxed function to access the method inside of FileStreamPick directly
                    FileStreamPick file = new FileStreamPick();

                    // Inputs data
                    order.OrderNr = int.Parse(tb_OrderId.Text);
                    order.Price = decimal.Parse(tb_OrderPrice.Text);

                    // Shows result in form of a MessageBox
                    MessageBox.Show(
                        file.SaveOrder(order),
                        "Used Relaxed Method",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    // Tells user that no method is selected
                    MessageBox.Show(
                        "Please select a method type!",
                        "No method selected!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );

                }

            }
            catch (Exception ex)
            {
                // Throws an error, if one has occured
                MessageBox.Show(
                  ex.Message,
                  "An error occurred!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                  );
            }
        }

        private void cb_Strict_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Strict.Checked)
            {
                cb_Relaxed.Checked = false;
            }
        }

        private void cb_Relaxed_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Relaxed.Checked)
            {
                cb_Strict.Checked = false;
            }
        }


    }
}