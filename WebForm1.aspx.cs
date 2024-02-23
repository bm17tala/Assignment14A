using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_14A {
    public partial class WebForm1 : System.Web.UI.Page {

        private List<int> prices;
        
        protected void Page_Load(object sender, EventArgs e) {
            //used when calculating cost of items
            prices = new List<int> {
                12,
                13,
                14,
                14,
                15,
                16
            };
        }

        //clear out order text box when clear button is pressed
        protected void btnClearItems_Click(object sender, EventArgs e) {
            txtOrderList.Text= string.Empty;
        }

        //Display instructions in order text box when help is clicked
        protected void btnHelp_Click(object sender, EventArgs e) {
            txtOrderList.Text = "Please select one or more shirt sizes, enter a quantity \n"
                + "in the \"Quantity\" text box, and click \"Review Order\" to \n"
                + "add the order(s) to your shopping cart. If you make a\n"
                + "mistake and need to clear your orders, press the \n"
                + "\"Clear Items\" button.\n\n"
                + "Author - Brenden Talasco";
        }

        protected void btnReviewOrder_Click(object sender, EventArgs e) {
            //clear out the order list text box of any text before adding the new order.
            txtOrderList.Text = string.Empty;
            
            //get list of selected items, quantity for each, then list out each item and the same quantity for each in the text box below.
            int quantity;

            //selectedItems - the items on the check box list that are selected
            //selectedIndex - the index value of each selected item, top list item is 0, bottom is 6
            ListItemCollection selectedItems = new ListItemCollection();
            List<int> selectedIndex = new List<int>();

            //if content of quantity text box is not an integer or less thaan 1, alert the user
            if (!Int32.TryParse(txtQuantityValue.Text, out quantity)) {
                txtOrderList.Text = "Incorrect quantity type entered!";
                return;
            }

            if(quantity <= 0) {
                txtOrderList.Text = "Quantity must be at least 1!";
                return;
            }

            //iterate through each item on the menu
            for(int i = 0; i < chkSizeList.Items.Count; i++) {
                //on the items that are selected
                if (chkSizeList.Items[i].Selected) {
                    //add them to the selectedItems list
                    selectedItems.Add(chkSizeList.Items[i]);

                    //and add their corresponding index to the selectedIndex array
                    selectedIndex.Add(chkSizeList.Items.IndexOf(chkSizeList.Items[i]));

                }
            }

            //alert user if no shirt sizes were selected
            if (selectedItems.Count == 0) {
                txtOrderList.Text += "No Shirt Sizes selected!";
                return;
            }

            int total = 0;
            //then print each selected size and their prices for the quantity of them requested
            //also add the price of each size up for the total
            for (int i = 0; i < selectedItems.Count; i++) {
                txtOrderList.Text += selectedItems[i].Text + " - $" + prices[selectedIndex[i]] * quantity + "\n";
                total += prices[selectedIndex[i]] * quantity;
            }
            //write the total price
            txtOrderList.Text += "\nTotal Price: - $" + total;
        }
    }
}