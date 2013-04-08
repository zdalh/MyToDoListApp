/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 10:44:40
 *  Description: Description of MyToDoList.Common.ToDoList.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyToDoList.Common
{
    ///<summary>
    /// Summary of MyToDoList.Common.ToDoList.
    ///</summary>
    public class ToDoList : IEnumerable<ToDoItem>, IDisposable
    {
        #region Fields

        #endregion

        #region Properties

        protected List<ToDoItem> DataStorge { get; set; }

        #endregion

        #region Constructor

        public ToDoList()
        {
            DataStorge = new List<ToDoItem>();
        }

        #endregion

        #region Methods

        public IEnumerator<ToDoItem> GetEnumerator()
        {
            return DataStorge.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return DataStorge.GetEnumerator();
        }

        public void Dispose()
        {
            DataStorge = null;
        }

        #endregion
    }
}
