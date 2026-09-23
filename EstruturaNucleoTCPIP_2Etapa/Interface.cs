using System;
using System.Collections.Generic;
using System.Text;

public class Interface
{
    public PduInterface Pack(string macOrigem ,string macDestino, PduRede pduR)
    {
        return new PduInterface(macOrigem, macDestino, pduR);
    }
    public PduRede UnPack(PduInterface pduI)
    {
        return pduI.Dados;
    }
    public void EnviarDados()
    {
        Console.WriteLine("[INTERFACE] → Enviando Quadro");
    }

    public void ReceberDados()
    {
        Console.WriteLine("[INTERFACE] ← Recebendo Quadro");
    }
}