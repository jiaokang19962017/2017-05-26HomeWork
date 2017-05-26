using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PhoneBook
    {
        ArrayList list = new ArrayList();//声明变量

        /// <summary>
        /// 添加联系人的方法
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="phone">电话号</param>
        public void Insert(string name,string phone)
        {
           
                list.Add(name);
                list.Add(phone);
            
        }

        public void Show()
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString()+"姓名:");
            }
        }
    }
}
