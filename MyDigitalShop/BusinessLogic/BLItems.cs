using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLItems
    {
        public DataTable GetItems()
        {
            DAItems daItems = new DAItems();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daItems.GetItems();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public DataTable GetItemNameById(int itemId)
        {
            DAItems daItems = new DAItems();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daItems.GetItemNameById(itemId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
    }
}
