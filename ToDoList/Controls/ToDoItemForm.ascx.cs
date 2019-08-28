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

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TODODescription.Text))
            {

                ErrorMessage.Visible = false;
                ToDoItemData.AddItem(TODODescription.Text, int.Parse(TODOPriority.SelectedValue));
                ResetForm();

            }
            else
            {
                ErrorMessage.Visible = true;
            }
        }

        public void ResetForm()
        {
            TODODescription.Text = string.Empty;
            TODOPriority.SelectedIndex = 0;
        }
    }
}