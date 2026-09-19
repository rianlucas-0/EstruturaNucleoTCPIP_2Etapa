Console.WriteLine("==========================================");
Console.WriteLine("       NÚCLEO TCP/IP EM EXECUÇÃO");
Console.WriteLine("             GRUPO 1 | 2026/2");
Console.WriteLine("==========================================");

Computador pc1 = new Computador("PC-01", "192.168.0.1", "02:4A:7F:B3:91:C8");
Computador pc2 = new Computador("PC-02", "192.168.0.2", "02:D6:3E:85:AC:17");

PduAplicacao aplicacao = new PduAplicacao("Mensagem de teste");

Transporte transporte = new Transporte();

Rede rede = new Rede();

Interface interfacee = new Interface();

pc1.Ligar();
pc2.Ligar();

aplicacao.EnviarDados();

var pduTransporte = transporte.Pack(aplicacao, "10", "10");
transporte.EnviarDados();

var pduRede = rede.Pack(pduTransporte, pc1.Ip, pc2.Ip);
rede.EnviarDados();

var pduInterface = interfacee.Pack(pduRede, pc1.Mac, pc2.Mac);
interfacee.EnviarDados();

Console.WriteLine("\nModelo TCP/IP: Execução encerrada com sucesso!");

Console.ReadKey();