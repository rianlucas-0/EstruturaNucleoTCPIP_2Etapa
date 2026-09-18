using System;
using System.Collections.Generic;
using System.Text;

public class Interface
{
    public void Pack(PduRede pduR, string macDestino)
    {
        PduInterface pduInterface = new PduInterface("MacTeste", "MacTeste", pduR);
    }
    public void UnPack(PduInterface pduR, Computador comp)
    {

    }
}