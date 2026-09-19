using System;
using System.Collections.Generic;
using System.Text;

public class PduInterface
{
    public string MacOrigem = "";
    public string MacDestino = "";
    public PduRede Dados;
    public PduInterface(string macOrigem, string macDestino, PduRede dados)
    {
        MacOrigem = macOrigem;
        MacDestino = macDestino;
        Dados = dados;
    }
}
