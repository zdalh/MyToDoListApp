/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 15:04:20
 *  Description: Description of MyToDoList.Core.FileDataStore.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyToDoList.Core
{
    ///<summary>
    /// Summary of MyToDoList.Core.FileDataStore.
    ///</summary>
    public class FileDataStore : IDataStore
    {
        #region Fields

        private static readonly string BaseDir = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string ResourceDir = @"resource";
        private static readonly string ToDoFile = @"todo.csv";
        private static readonly string LastDoneFile = @"done.csv";
        private static readonly string DonePath = @"done-{1}.csv";

        private static string _toDoPath = string.Format(@"{0}\\{1}\\{2}", BaseDir, ResourceDir, ToDoFile);

        private static string _lastDonePath = string.Format(@"{0}\\{1}\\{2}", BaseDir, ResourceDir, LastDoneFile);

        #endregion

        #region Properties



        #endregion

        #region Constructor

        #endregion

        #region Methods

        public Common.ToDoList GetMyToDoList()
        {
            
        }

        public Common.DoneList GetMyDoneList()
        {
            throw new NotImplementedException();
        }

        public void AddToDoItem(Common.ToDoItem item)
        {
            throw new NotImplementedException();
        }

        public void RemoveToDoItem(Common.ToDoItem item)
        {
            throw new NotImplementedException();
        }

        public void AddToDoneList(Common.DoneItem doneItem)
        {
            throw new NotImplementedException();
        }

        public void SaveToDoList(Common.ToDoList list)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
