using System;
using System.Collections.Generic;
using System.Text;

public class PduRede
{
    public string IpOrigem = "";
    public string IpDestino = "";
    public PduTransporte Dados;
    public PduRede(string ipOrigem, string ipDestino, PduTransporte dados)
    {
        IpOrigem = ipOrigem;
        IpDestino = ipDestino;
        Dados = dados;
    }
}
