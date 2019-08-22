using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.Models;

namespace ToDoList.Controls
{
    public partial class ToDoItemForm : System.Web.UI.UserControl
    {
        public static int counter = 0;
        const int MaxItems = 5;
        ToDoListDisplay toDoListDisplay = new ToDoListDisplay();
        protected void Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TODODescription.Text))
            {
                if (counter < MaxItems)
                {
                    ErrorMessage.Visible = false;
                    ToDoItemData.AddItem(TODODescription.Text, int.Parse(TODOPriority.SelectedValue));
                    ResetForm();
                    counter++;
                    Response.Redirect(Request.RawUrl);
                }
            }
            else
            {
                ErrorMessage.Visible = true;
            }
        }

        public void ResetForm() {
            TODODescription.Text = string.Empty;
            TODOPriority.SelectedIndex = 0;
        }
    }
}