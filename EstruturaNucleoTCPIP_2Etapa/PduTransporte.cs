using System;
using System.Collections.Generic;
using System.Text;

public class PduTransporte
{
    public string PortaOrigem = "";
    public string PortaDestino = "";
    public PduAplicacao Dados;
    public PduTransporte(string portaOrigem, string portaDestino, PduAplicacao dados)
    {
        PortaOrigem = portaOrigem;
        PortaDestino = portaDestino;
        Dados = dados;
    }
}
