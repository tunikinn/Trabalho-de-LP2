using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine("\tBem vindo(a) a nossa loja mágica! Aqui você pode encontrar uma variedade incrivel de itens mágicos! \r\n");

    Console.WriteLine("Diga seu nome e sua quantidade de moedas para o vendedor!\r\n");
    Personagem Comprador = new Personagem(nome:Console.ReadLine(),moeda:Convert.ToInt32(Console.ReadLine()));

   //Junior.ComprarItem(espada);*//
    Comprador.ImprimirPersonagem();

  

    Console.WriteLine("\r\n");
    Console.WriteLine("Abaixo segue o nosso cátalgo :) \r\n");
  
    Item espada = new Item(nome:"Espada", descricao:"Espada de fogo",moeda: 50, categoria:"Arma branca");

    espada.ImprimirItem();

    Item varinha = new Item(nome:"Varinha", descricao:"Mágica",moeda: 40, categoria:"Objeto mágico");
    
    varinha.ImprimirItem();

    Item camisa = new Item(nome:"Camisa de lobo", descricao:"Feita com pele de lobo",moeda: 35, categoria:"Roupa");
    
    camisa.ImprimirItem();

    Item pergaminho = new Item(nome:"Pergaminho", descricao:"Feito para enviar mensagens",moeda: 15, categoria:"Acessório");
    
    pergaminho.ImprimirItem();

    Item livro = new Item(nome:"Livro de feitiços", descricao:"Livro para fazer feitiços",moeda: 80, categoria:"Educativo");
    
    livro.ImprimirItem();

    Item vassoura = new Item(nome:"Vassoura voadora", descricao:"Uma vassoura que pode voar",moeda: 120, categoria:"Objeto mágico");
    
    vassoura.ImprimirItem();

    Loja lojinha = new Loja();
    lojinha.estoque(espada);
    lojinha.estoque(varinha);
    lojinha.estoque(pergaminho);
    lojinha.estoque(camisa);
    lojinha.estoque(livro);

    string escolha;
    do {
    Console.WriteLine("Qual item deseja comprar?");
    string itemEscolhido = Console.ReadLine();

    Comprador.ComprarItem(itemEscolhido, lojinha.lista);
    Comprador.ImprimirPersonagem2();
    Console.WriteLine("Entre com SIM para comprar novamente");
    escolha = Console.ReadLine();
    } while (escolha == "SIM");
      
  }
}