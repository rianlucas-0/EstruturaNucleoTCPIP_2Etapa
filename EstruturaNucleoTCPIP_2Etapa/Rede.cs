using System;
using System.Collections.Generic;
using System.Text;

public class Rede
{
    public PduRede Pack(string ipOrigem, string ipDestino, PduTransporte pduT)
    {
        return new PduRede(ipOrigem, ipDestino, pduT);
    }
    public PduTransporte UnPack(PduRede pduR)
    {
        return pduR.Dados;
    }
    public void EnviarDados()
    {
        Console.WriteLine("[REDE] → Enviando Pacote");
    }

    public void ReceberDados()
    {
        Console.WriteLine("[REDE] ← Recebendo Pacote");
    }
}
