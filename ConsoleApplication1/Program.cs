using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-18
            //string str = "";
            //1.提取邮箱的用户名（如:zhangsan@163.com）
            /*  str = "zhangsan@193.com";
               Console.WriteLine(str.Substring(0, 8));
             //2. 将“x.y.txt”文件名的扩展名改为.dat。
               str = "x.y.txt";
               string nstr = str.Remove(4);
               Console.WriteLine(nstr.Insert(4, "dat"));*/
            //3.输入一个字符串，输出每个单词，重新用下划线连接输出
            /* string str3 = Console.ReadLine();
             string[] array = str3.Split(' ');
             string str1 = string.Join("_", array);
             Console.WriteLine(str1);*/
            //4.使用格式化字符串输出姓名、出生年 月、血型、星座、最喜欢的食物
            /*string name = "焦康";
            char bloodType = 'B';
            string starType = "处女座";
            string foot = "香蕉";
            Console.WriteLine("姓名是:{0}",name);
            Console.WriteLine("{0:yyyy年MM月dd日}",DateTime.Now);*/

            /*输出当前系统时间格式为现在是{0}年{1}月{2}日{3}时{4}分{5}秒，
             * 并且使用if else判断输出早上好(<12)、下午好（>=12）、晚上好(>=18)。*/
            /* Console.WriteLine("{0:yyyy年MM月dd日hh时mm分ss秒}",DateTime.Now);
             DateTime dt = DateTime.Now;
             int house = dt.Hour;
             if (house < (12))
             {
                 Console.WriteLine("早上好");
             }
             else if (house >= 12)
             {
                 Console.WriteLine("下午好");

             }
             else if (house >= 18)
             {
                 Console.WriteLine("晚上好");
             }*/

            /*6. 产生0-9之间的随机数作为中奖号，从控制台输入你猜测的中奖号，3次内若有一次猜对，
             * 打印输出“恭喜您，中奖啦”，退出游戏，若3次内都没猜对打印”谢谢参与”，也退出游戏。*/
            /* Random rd = new Random();
             int resuls = rd.Next(0, 9);



             for (int i = 0; i < 3; i++)
             {
                 int num = int.Parse(Console.ReadLine());
                 if (resuls != num)
                 {
                     Console.WriteLine("错误");

                 }
                 else if (resuls == num)
                 {
                     Console.WriteLine("中奖啦");
                     Console.WriteLine(resuls);
                     break;
                 }

             }*/

            //7.使用字符串格式化函数将123.5678格式化为货币形式和浮点数类型。
            /* string str7 = "1235678";
             int num = Convert.ToInt32(Convert.ToDouble(str7));
             Console.WriteLine(num);
             Console.WriteLine(string.Format("{0:C}",num));*/

            //9.将字符串(one、two、three、four、five)通过静态方法Concat、静态方法Join和实例方法StringBuilder.Append连接成字符串。
            /*   string str9 = "one,two,three,four,five";
               string[] array9 = str9.Split(',');
               string strnew = string.Concat(array9);
               Console.WriteLine(strnew);*/


            //10.将字符串“-index0-index1-index2-”截头去尾。
            /*   string str10 = "-index0-index1-index2-";
               Console.WriteLine(str10.Trim('-'));*/

            //12.将“Hello world”转化为大写，然后将world替换为china。
            /* string str12 = "Hello World";
             Console.WriteLine(str12.ToUpper());
             Console.WriteLine(str12.Replace("World","china"));*/

            //13.将字符串welcome to jining 转为字符数组
            /*string str13 = "welcome to jining";
            string[] arr13 = str13.Split(',');
            foreach (string item in arr13)
            {
                Console.Write(item);
            }*/

            //14.将9879.2675，保留两位小数，并实现四舍五入
            /*  double d14 = 9879.2675;
              Console.WriteLine(Math.Round(d14,2));*/

            //15.已知圆的半径为3.5求圆的面积和周长。并保留两位小数。
            /* double d15 = 3.5;//圆的半径;
             Console.WriteLine("圆的周长为:{0}",Math.Round( 2*Math.PI*d15,2));
             Console.WriteLine("圆的面积是:{0}",Math.Round(Math.PI*(d15*d15),2) );*/

            //16.将字符串“2017-02-14”转化为日期类型
            /* string str16 = "2017-02-14";
             Console.WriteLine(Convert.ToDateTime(str16));*/

            //17.已知 一个整数123，和一个字符串“123”，比较并输出结果
            /*      int num = 123;
                  string str17 = "123";
                  Console.WriteLine(str17.Equals(num)); */

            //18.使用Array类对一个整数数组排序（从大到小、从小到大），并求最大最小值。
            /* int[] arr = new int[] { 1, 3, 2, 9, 6 };
             Array.Sort(arr);
             foreach (int item in arr)
             {
                 Console.WriteLine(item);
             }
             Array.Reverse(arr);
             foreach (int item in arr)
             {
                 Console.WriteLine(item);
             }*/
            #endregion

            PhoneBook p = new PhoneBook();
            Console.WriteLine("欢迎使用简易电话本系统");
            Console.WriteLine("操作方式:a--添加联系人,s--查看联系人,q--退出系统");
            while (true) { 
            string flag = Console.ReadLine();
            switch (flag)
            {
                case "a":
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("请输入姓名:");
                        string name = Console.ReadLine();
                        Console.Write("请输入电话:");
                        string phone = Console.ReadLine();
                        p.Insert(name, phone);
                      
                    }
                    break;
                case "s":
                    p.Show();
                    continue;
                    case "q":
                    return;
            }
            }


        }
    }
}

