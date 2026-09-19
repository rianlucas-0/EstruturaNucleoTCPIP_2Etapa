using System;
using System.Collections.Generic;
using System.Text;

public class Interface
{
    public PduInterface Pack(string macOrigem ,string macDestino, PduRede pduR)
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