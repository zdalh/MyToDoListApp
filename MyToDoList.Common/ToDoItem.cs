/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 10:27:55
 *  Description: Description of MyToDoList.Common.ToDoItem.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyToDoList.Common
{
    ///<summary>
    /// Summary of MyToDoList.Common.ToDoItem.
    ///</summary>
    [Serializable]
    public class ToDoItem : ICloneable<ToDoItem>
    {
        #region Fields

        #endregion

        #region Properties

        public Guid Key { get; set; }
        public string Information { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsImportant { get; set; }

        #endregion

        #region Constructor

        public ToDoItem() { }

        public ToDoItem(string information, bool isUrgent = false, bool isImportant = false)
        {
            this.Key = Guid.NewGuid();
            this.Information = information;
            this.IsUrgent = isUrgent;
            this.IsImportant = isImportant;
        }

        public ToDoItem(string information, bool isUrgent, bool isImportant)
        {
            this.Key = Guid.NewGuid();
            this.Information = information;
            this.IsUrgent = isUrgent;
            this.IsImportant = isImportant;
        }

        #endregion

        #region Methods

        #endregion

        public ToDoItem Clone()
        {
            return this.MemberwiseClone() as ToDoItem;
        }
    }
}
