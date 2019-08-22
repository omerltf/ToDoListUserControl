using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToDoList.Models;
namespace ToDoList.Controls
{
    public partial class ToDoListDisplay : System.Web.UI.UserControl
    {
        //use this variable to only display certain category(1-3) (0 to display all categories) (invalid integer inputs will display all categories) 
        int exception = 0;          
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PopulateList(exception) != null)
                {
                    UseRepeater();
                }
            }
        }

        protected void TODOs_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int index = int.Parse((string)e.CommandArgument);
            PopulateList(exception)[index].Done = true;
            ToDoItemForm.counter--;
            UseRepeater();
        }

        public void UseRepeater()
        {
            try
            {
                TODOsRepeater.DataSource = PopulateList(exception);
                TODOsRepeater.DataBind();
            }
            catch (NullReferenceException)
            {
            }
        }

        public List<ToDoItem> PopulateList(int except)
        {
            if (except > 0)
            {
                List<ToDoItem> exceptionList = new List<ToDoItem>();
                foreach (var item in ToDoItemData.GetToDoItems())
                {
                    if (item.Priority == except)
                    {
                        exceptionList.Add(item);
                    }
                }
                return exceptionList;
            }
            else
            {
                return ToDoItemData.GetToDoItems();
            }
        }
    }
}