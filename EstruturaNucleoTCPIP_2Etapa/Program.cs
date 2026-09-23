Console.WriteLine("==================================================");
Console.WriteLine("             NÚCLEO TCP/IP EM EXECUÇÃO");
Console.WriteLine("                  GRUPO 1 | 2026/2");
Console.WriteLine("==================================================");

Computador pc1 = new Computador("PC-01", "192.168.0.1", "02:4A:7F:B3:91:C8");

Computador pc2 = new Computador("PC-02", "192.168.0.2", "02:D6:3E:85:AC:17");

PduAplicacao aplicacaoA = new PduAplicacao("Mensagem de teste");

PduAplicacao aplicacaoB = new PduAplicacao("");

Transporte transporteA = new Transporte();

Transporte transporteB = new Transporte();

Rede redeA = new Rede();

Rede redeB = new Rede();

Interface interfaceA = new Interface();

Interface interfaceB = new Interface();

pc1.Ligar();

pc2.Ligar();

Console.WriteLine("\n------------------- ENVIO -------------------");

aplicacaoA.EnviarDados();

var pduTransporte = transporteA.Pack("10", "10", aplicacaoA);

transporteA.EnviarDados();

var pduRede = redeA.Pack(pc1.Ip, pc2.Ip, pduTransporte);

redeA.EnviarDados();

var pduInterface = interfaceA.Pack(pc1.Mac, pc2.Mac, pduRede);

interfaceA.EnviarDados();

Console.WriteLine("\n---------------- RECEBIMENTO ----------------");

var pduInterfaceR = interfaceB.UnPack(pduInterface);

interfaceB.ReceberDados();

var pduRedeR = redeB.UnPack(pduInterfaceR);

redeB.ReceberDados();

var pduTransporteR = transporteB.UnPack(pduRedeR);

transporteB.ReceberDados();

aplicacaoB.Dados = pduTransporteR.Dados;
aplicacaoB.ReceberDados();

Console.WriteLine("\n---------------- MENSAGEM ----------------");
Console.WriteLine($"Aplicação B recebeu: \"{aplicacaoB.Dados}\"");

Console.WriteLine("\n==================================================");
Console.WriteLine("       MODELO TCP/IP: EXECUÇÃO FINALIZADA");
Console.WriteLine("==================================================");

Console.ReadKey();