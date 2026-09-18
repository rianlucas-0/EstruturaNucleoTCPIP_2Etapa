using System;
using System.Collections.Generic;
using System.Text;

public class PduRede
{
    public string IpOrigem = "";
    public string IpDestino = "";
    public PduTransporte Dados;
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Rede: Enviando Pacote de Dados");
    }
    public PduRede(string ipOrigem, string ipDestino, PduTransporte dados)
    {
        IpOrigem = ipOrigem;
        IpDestino = ipDestino;
        Dados = dados;
    }
}
