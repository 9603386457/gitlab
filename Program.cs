/*using System;
using System.Collections.Generic;

namespace storedata
{
    class Program
    {
	string Name=new string[i];
	int Id=new int[i];
	int Contact=new int[i];
        static void Main(string[] args)
        {
		Data();
		FileWriteLine();
		FileRead();
	}
public static void Data(){
	 //Console.WriteLine("Enter data you want to store");
       //  int a=Int32.Parse(Console.ReadLine());
		for(int i=0;i<5;i++){
		Console.WriteLine(Name=" ");
		Name[i]=Console.ReadLine();
		Console.WriteLine(Id=" ",Contact=" "); 
		Id[i]=Console.ReadLine();
		Contact[i]=Console.ReadLine();
	    }

      private static void FileWriteLine()
       {
         StreamWriter F = new StreamWriter(@"D:\data");
         for (int i = 1; i <= 20; i++) {
            F.WriteLine("This is an example");
         }
         F.Close();
       }

 
        private static void FileRead()
       {
         StreamReader F = new StreamReader(@"D:\data");
         String a_line;
         a_line = F.ReadLine();
         Console.WriteLine("\n Printing Line by Line \n");
        while (a_line != null) 
        {
            Console.WriteLine(a_line);
            a_line = F.ReadLine();
        }
        F.Close();
         Console.ReadKey();
       }

	}
}
}*/

/*using System;
 
class dbzero
{
    static void Main()
    {
    try
    {
        int value = 1 / int.Parse("0"); 
        Console.WriteLine(value);
            Console.WriteLine(5);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
       Console.WriteLine("hello");
    }
}*/

/*using System;
class Program
{
    static void Main()
    {
        int[] arr={1,2,3,4};
        try{
            for(int i=0;i<arr.Length;i++){
                Console.WriteLine(arr[i]/arr[i+1]);
                }
            }
        catch(IndexOutOfRange a ){
            Console.WriteLine("An exception has occured:{0}",a.Message);
        }
        catch(DivideByZeroException a){
            Console.WriteLine("An ecxception occured:{0}",a.Message);
        }
        }
    }*/
    /*using System;
    class dbzero
{
    static void Main()
    {
    try
    {
        //short v = 10000;
        int value = 1 / int.Parse("0"); 
        String str;
        Console.WriteLine(value);
            Console.WriteLine(5);
        Console.WriteLine(str.Length);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("DivideByZero: " + ex.Message);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("OverflowException: " + ex.Message);
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine("Arithmetic : " + ex.Message);
    }
    /*
    catch (Exception ex)
    {
        Console.WriteLine("Exception : " + ex.Message);
    }
    */
    //   Console.WriteLine("hello");



using System;  
using System.Threading;  
 
public class MyThread  
{  
    public static void Thread1(String str)  
    {  
        for (int i = 0; i < 5; i++)  
        {  
            Console.WriteLine(str + " =>  " + i.ToString());  
        }  
    }  

    public void Thread2(String str)  
    {  
        for (int i = 0; i < 5; i++)  
        {  
            Console.WriteLine(str + " =>  " + i.ToString());  
        }  
    }  
 
}  
 
public class ThreadExample  
{  
    public static void Main()  
    {  
        //Thread th_1 = new Thread(new ThreadStart(MyThread.Thread1));  
        //Thread th_2 = new Thread(new ThreadStart(MyThread.Thread1));  
 
    Thread th_1 = new Thread(() => MyThread.Thread1("th_1"));
    Thread th_2 = new Thread(() => MyThread.Thread1("th_2"));
 
        th_1.Start();  
        th_2.Start();  
 

    MyThread objMyThread = new MyThread();
        //Thread th_3 = new Thread(new ThreadStart(objMyThread.Thread2));  
        //Thread th_4 = new Thread(new ThreadStart(objMyThread.Thread2));  
 
    Thread th_3 = new Thread(() => objMyThread.Thread2("th_3"));
    Thread th_4 = new Thread(() => objMyThread.Thread2("th_4"));
 
        th_3.Start();  
        th_4.Start();  
 
    }  
}  