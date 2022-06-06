using ByteBank;

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Igor Neves";
conta1.conta = "251336 - x";
conta1.saldo = 105.98;
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";

ContaCorrente conta2 = new ContaCorrente();

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Número da agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome da agência: " + conta2.nome_agencia);
Console.WriteLine("Saldo: " + conta2.saldo);

double saldo = 100;
double saldo2 = conta1.saldo;
Console.WriteLine(saldo == conta1.saldo);
Console.WriteLine(saldo != saldo2);

Console.ReadKey();

