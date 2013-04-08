/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 12:30:38
 *  Description: Description of MyToDoList.Common.DoneList.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyToDoList.Common
{
    ///<summary>
    /// Summary of MyToDoList.Common.DoneList.
    ///</summary>
    public class DoneList : IEnumerable<DoneItem>
    {
        #region Fields

        #endregion

        #region Properties

        protected List<DoneItem> DataStorge { get; set; }

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion

        public IEnumerator<DoneItem> GetEnumerator()
        {
            return DataStorge.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return DataStorge.GetEnumerator();
        }
    }
}
