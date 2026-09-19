using System;
using System.Collections.Generic;
using System.Text;

public class Rede
{
    public PduRede Pack(PduTransporte pduT, string ipDestino, string ipOrigem)
    {
        return new PduRede(ipOrigem, ipDestino, pduT);
    }
    public void UnPack(PduRede pduR, Computador comp)
    {

    }
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Rede: Enviando Pacote de Dados");
    }
}
