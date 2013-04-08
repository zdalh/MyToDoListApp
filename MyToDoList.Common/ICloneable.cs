/************************************************
 *  Complany: http://www.AdChina.com
 *  Author: alex.zhou
 *  Contact: alex.zhou@adchina.com
 *  
 *  Create CLR: 3.5
 *  Min CLR: 3.5
 *  
 *  Create Time: 2013/3/26 11:41:32
 *  Description: Description of MyToDoList.Common.ICloneable.
 ************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyToDoList.Common
{
    ///<summary>
    /// Summary of MyToDoList.Common.ICloneable.
    ///</summary>
    public interface ICloneable<T>
    {
        T Clone();
    }
}
