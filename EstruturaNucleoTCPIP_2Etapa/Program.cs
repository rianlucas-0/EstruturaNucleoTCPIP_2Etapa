Console.WriteLine("==========================================");
Console.WriteLine("       NÚCLEO TCP/IP EM EXECUÇÃO");
Console.WriteLine("             GRUPO 1 | 2026/2");
Console.WriteLine("==========================================");

Computador pc1 = new Computador("PC-01", "192.168.0.1", "02:4A:7F:B3:91:C8");
Computador pc2 = new Computador("PC-02", "192.168.0.2", "02:D6:3E:85:AC:17");

pc1.Ligar();
pc2.Ligar();

Console.WriteLine("\nModelo TCP/IP: Execução encerrada com sucesso!");

Console.ReadKey();

public class Computador
{
    public string Nome = "";
    public string Ip = "";
    public string Mac = "";
    public void Ligar()
    {
        Console.WriteLine($"Ligando o Computador: {Nome}");
    }
    public Computador( string nome, string ip, string mac)
    {
        Nome = nome;
        Ip = ip;
        Mac = mac;
    }
}

public class PduAplicacao
{
    public string Dados = "";
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Aplicação: Enviando Dados");
    }
    public PduAplicacao(string dados)
    {
        Dados = dados;
    }
}

public class PduTransporte
{
    public string PortaOrigem = "";
    public string PortaDestino = "";
    public PduAplicacao Dados;
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Transporte: Enviando Segmento de Dados");
    }
    public PduTransporte(string portaOrigem, string portaDestino, PduAplicacao dados)
    {
        PortaOrigem = portaOrigem;
        PortaDestino = portaDestino;
        Dados = dados;
    }
}

public class Transporte
{
    public void Pack(PduAplicacao pduA, string ipDestino, string portaDestino)
    {
        PduTransporte pduTransporte = new PduTransporte("portaTeste", "portaTeste", pduA);
    }
    public void UnPack(PduTransporte pduT, string portaDestino)
    {

    }
}

public class PduRede
{
    public string IpOrigem = "";
    public string IpDestino = "";
    public PduTransporte Dados;
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Rede: Enviando Pacote de Dados");
    }
    public PduRede(string ipOrigem, string ipDestino, PduTransporte dados)
    {
        IpOrigem = ipOrigem;
        IpDestino = ipDestino;
        Dados = dados;
    }
}

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

public class PduInterface
{
    public string MacOrigem = "";
    public string MacDestino = "";
    public PduRede Dados;
    public void EnviarDados()
    {
        Console.WriteLine("Camada de Interface: Enviando Quadro de Dados");
    }
    public PduInterface(string macOrigem, string macDestino, PduRede dados)
    {
        MacOrigem = macOrigem;
        MacDestino = macDestino;
        Dados = dados;
    }
}

public class Interface
{
    public void Pack(PduRede pduR, string macDestino)
    {
        PduInterface pduInterface = new PduInterface("MacTeste", "MacTeste",pduR);
    }
    public void UnPack(PduInterface pduR, Computador comp)
    {

    }
}