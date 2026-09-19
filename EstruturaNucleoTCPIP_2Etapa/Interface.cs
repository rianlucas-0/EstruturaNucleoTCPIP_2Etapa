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
        Console.WriteLine("Camada de Interface: Enviando Quadro de Dados");
    }
       public void ReceberDados()
    {
        Console.WriteLine("Camada de Interface: Recebendo Quadro de Dados");
    }
}