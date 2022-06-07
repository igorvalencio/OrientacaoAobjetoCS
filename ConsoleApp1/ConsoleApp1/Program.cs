using ByteBank;

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Igor Neves";
conta1.conta = "251336 - x";
conta1.saldo = 105.98;
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número da agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da agência: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("Saldo pré-saque: " + conta1.saldo);
conta1.sacar(-50);
Console.WriteLine("Saldo pós-saque: " + conta1.saldo);


Console.ReadKey();

