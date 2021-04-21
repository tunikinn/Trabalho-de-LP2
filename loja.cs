using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Loja 
{
  public List<Item> lista = new List <Item> ();

  public void estoque(Item item) {
    lista.Add(item);
  }
}