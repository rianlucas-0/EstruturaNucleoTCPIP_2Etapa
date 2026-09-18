using System;
using System.Collections.Generic;
using System.Text;

public class Rede
{
    public void Pack(PduTransporte pduT, string ipDestino)
    {
        PduRede pduRede = new PduRede("ipTeste", "portaTeste", pduT);
    }
    public void UnPack(PduRede pduR, Computador comp)
    {

    }
}
