using System;
using System.Collections.Generic;
using System.Text;

public class Transporte
{
    public PduTransporte Pack(PduAplicacao pduA, string portaOrigem, string portaDestino)
    {
        return new PduTransporte(portaOrigem, portaDestino, pduA);
    }
    public void UnPack(PduTransporte pduT, string portaDestino)
    {

    }
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Transporte: Enviando Segmento de Dados");
    }
}
