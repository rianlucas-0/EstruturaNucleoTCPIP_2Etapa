using System;
using System.Collections.Generic;
using System.Text;

public class Transporte
{
    public PduTransporte Pack(string portaOrigem, string portaDestino, PduAplicacao pduA)
    {
        return new PduTransporte(portaOrigem, portaDestino, pduA);
    }
    public PduTransporte UnPack(PduRede pduR)
    {
        return pduR.Dados;
    }
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Transporte: Enviando Segmento de Dados");
    }
    public void ReceberDados()
    {
        Console.WriteLine("Camada de Transporte: Recebendo Segmento de Dados");
    }
}
