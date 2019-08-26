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
        public int exception { get; set; } = 0;
        public int limit { get; set; } = 0;

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            UseRepeater();

        }

        protected void TODOs_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int index = int.Parse((string)e.CommandArgument);
            PopulateList(exception)[index].Done = true;
        }

        public void UseRepeater()
        {
            TODOsRepeater.DataSource = PopulateList(exception);
            TODOsRepeater.DataBind();

        }

        public List<ToDoItem> PopulateList(int exception)
        {
            if (exception > 0)
            {
                List<ToDoItem> exceptionList = new List<ToDoItem>();
                foreach (var item in ToDoItemData.GetToDoItems())
                {
                    if (item.Priority == exception)
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