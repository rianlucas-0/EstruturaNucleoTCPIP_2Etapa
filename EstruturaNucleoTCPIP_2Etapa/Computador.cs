using System;
using System.Collections.Generic;
using System.Text;

public class Computador
{
    public string Nome = "";
    public string Ip = "";
    public string Mac = "";
    public PduAplicacao Dados;
    public void Ligar()
    {
        Console.WriteLine($"Ligando o Computador: {Nome}");
    }
    public Computador(string nome, string ip, string mac, PduAplicacao pduA)
    {
        Nome = nome;
        Ip = ip;
        Mac = mac;
        Dados = pduA;
    }
}