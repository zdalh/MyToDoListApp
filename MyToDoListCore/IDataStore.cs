/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 10:25:59
 *  Description: Description of MyToDoListCore.IDataStore.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyToDoList.Common;


namespace MyToDoList.Core
{
    ///<summary>
    /// Summary of MyToDoListCore.IDataStore.
    ///</summary>
    public interface IDataStore
    {
        ToDoList GetMyToDoList();

        DoneList GetMyDoneList();

        void AddToDoItem(ToDoItem item);

        void RemoveToDoItem(ToDoItem item);

        void AddToDoneList(DoneItem doneItem);

        void SaveToDoList(ToDoList list);

    }
}
