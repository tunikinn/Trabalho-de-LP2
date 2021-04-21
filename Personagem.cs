using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Personagem 
  {
    public string Nome; 
    public int Moeda;
    public List<Item> Inventario;

    public Personagem (string nome, int moeda)
    {
      this.Nome = nome;
      this.Moeda = moeda;
      this.Inventario = new List<Item>();
    }

    public void ImprimirPersonagem()
    {
      Console.WriteLine("Bem vindo!\t{0}", this.Nome);
    }

    public void ImprimirPersonagem2()
    {
      Console.WriteLine("Até mais\t{0}", this.Nome);
      Console.WriteLine("Moedas restantes:\t\t{0}", this.Moeda);
      Console.Write("Inventário:\t{");
      foreach (var item in Inventario)
      {
        Console.Write("{0}", item.Nome);
      }
      Console.Write("}\r\n");
    }

    public void ComprarItem(string item, List<Item> estoque)
    {
      foreach (Item i in estoque) {

        if (i.Nome == item) {

          if (this.Moeda > i.Moeda)
      {
      this.Moeda = this.Moeda - i.Moeda;
      this.Inventario.Add(i);
      }else
      Console.WriteLine("você não possui moedas suficientes!\r\n"); 

        }

      }
    }
  }