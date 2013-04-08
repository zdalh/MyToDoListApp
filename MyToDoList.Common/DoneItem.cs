/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 11:11:28
 *  Description: Description of MyToDoList.Common.DoneItem.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyToDoList.Common
{
    ///<summary>
    /// Summary of MyToDoList.Common.DoneItem.
    ///</summary>
    public class DoneItem : ICloneable<DoneItem>
    {
        #region Fields

        #endregion

        #region Properties

        public ToDoItem ToDoItem { get; set; }
        public DateTime DoneTime { get; set; }

        #endregion

        #region Constructor

        public DoneItem() { }

        public DoneItem(ToDoItem toDoItem, DateTime doneTime)
        {
            this.ToDoItem = toDoItem;
            this.DoneTime = doneTime;
        }

        #endregion

        #region Methods

        #endregion

        public DoneItem Clone()
        {
            return new DoneItem(this.ToDoItem.Clone(), DoneTime);
        }
    }
}
