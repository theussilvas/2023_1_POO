using System;

class Program{
  static void Main(String[]args){
    Console.WriteLine(" Digite a primeira nota:");
    int N1 = int.Parse (Console.ReadLine());
    Console.WriteLine("Digite a segunda nota:");
    int N2 = int.Parse (Console.ReadLine());
    int med =((N1*2)+(N2*3))/5;
    string x = med.ToString();
    Console.WriteLine("A media bimestral é: "+ x);
    
  }
}
