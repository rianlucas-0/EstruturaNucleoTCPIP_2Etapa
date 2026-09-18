using System;
using System.Collections.Generic;
using System.Text;

public class PduAplicacao
{
    public string Dados = "";
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Aplicação: Enviando Dados");
    }
    public PduAplicacao(string dados)
    {
        Dados = dados;
    }
}
