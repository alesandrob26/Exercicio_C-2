using System;

class Program {
  public static void Main (string[] args) {
  Console.Write("Informe quantos anos: ");
  int anos = int.Parse(Console.ReadLine());
  Console.Write("Informe quantos meses: ");
  int meses = int.Parse(Console.ReadLine());
  Console.Write("Informe quantos dias: ");
  int dias = int.Parse(Console.ReadLine());
  int idadeEmDias = (anos *365) + (meses * 30) + dias;
  Console.WriteLine("Idade em dias: " + idadeEmDias);
  
  
    
  }
}