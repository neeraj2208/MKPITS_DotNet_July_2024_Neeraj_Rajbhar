using System;
 
namespace ThisKeyword 
{
  class Test 
{

    int num;
    Test(int num) 
    { 
      this.num = num;
    }

    static void Main(string[] args) 
{

      Test t1 = new Test(4);
      Console.WriteLine("value of num: " +t1.num);
      Console.ReadLine();
    }
  }
}