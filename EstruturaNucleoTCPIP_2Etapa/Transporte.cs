using System;
using System.Collections.Generic;
using System.Text;

public class Transporte
{
    public PduTransporte Pack(string portaOrigem, string portaDestino, PduAplicacao pduA)
    {
        return new PduTransporte(portaOrigem, portaDestino, pduA);
    }
    public void UnPack(string portaDestino, PduTransporte pduT)
    {

    }
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Transporte: Enviando Segmento de Dados");
    }
}
