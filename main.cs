using System;
using System.Collections.Generic;

class Example {
  static void Main() {
       string name;

       Console.WriteLine("Enter salesperson name");
        
      name = Console.ReadLine();
       Console.WriteLine("Enter sales amount");
      
      double amount=Convert.ToInt32(Console.ReadLine());
      
      double com=200+(0.09*amount);
       Console.WriteLine("sales commission for "+name+" is $"+com);
       
       if(amount>=0 & amount<=2999)
       Console.WriteLine("Perfomance is poor");
       else if(amount>=3000 & amount<=4999)
       Console.WriteLine("Perfomance is average");
        else if(amount>=5000 & amount<=9999)
       Console.WriteLine("Perfomance is good");
        else if(amount>=10000 & amount<=14999)
       Console.WriteLine("Perfomance is excellent");
       else
       Console.WriteLine("Perfomance is outstanding");
         }
}