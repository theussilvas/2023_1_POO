using System;

class Mainclass{
  public static void Main (String[]args){
    double b, h, a;
    Console.WriteLine("Digite a base do Triangulo");
    b= double.Parse(Console.Readline());
    Console.WriteLine("Digite a altura do triângulo");
    h= double.Parse(Console.Readline());
    a= b*h/2;
    Console.WriteLine($"Área = {a:0.00}");
  }
}
