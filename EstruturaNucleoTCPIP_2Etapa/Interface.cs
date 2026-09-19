using System;
using System.Collections.Generic;
using System.Text;

public class Interface
{
    public PduInterface Pack(PduRede pduR, string macOrigem ,string macDestino)
    {
        return new PduInterface(macOrigem, macDestino, pduR);
    }
    public void UnPack(PduInterface pduR, Computador comp)
    {

    }
        public void EnviarDados()
    {
        Console.WriteLine("Camada de Interface: Enviando Quadro de Dados");
    }
}