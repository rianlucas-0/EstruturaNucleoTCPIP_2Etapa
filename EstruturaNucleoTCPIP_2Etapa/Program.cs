Console.WriteLine("==========================================");
Console.WriteLine("       NÚCLEO TCP/IP EM EXECUÇÃO");
Console.WriteLine("             GRUPO 1 | 2026/2");
Console.WriteLine("==========================================");

Computador pc1 = new Computador("PC-01", "192.168.0.1", "02:4A:7F:B3:91:C8");
Computador pc2 = new Computador("PC-02", "192.168.0.2", "02:D6:3E:85:AC:17");

PduAplicacao aplicacao = new PduAplicacao("Mensagem de teste");

Transporte transporte = new Transporte();

pc1.Ligar();
pc2.Ligar();

aplicacao.EnviarDados();

transporte.Pack(aplicacao, "10", "10");
transporte.EnviarDados();

Console.WriteLine("\nModelo TCP/IP: Execução encerrada com sucesso!");

Console.ReadKey();