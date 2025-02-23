Console.WriteLine("0. Iniciou a execução do programa;");

//todo: verifique o resultado das diferenças de chamada:

//usando da forma abaixo a thread é liberada
// await CallMethodAsync();

// CallMethodAsync();

//usando da forma abaixo a thread é bloqueada (perigoso)
// CallMethodAsync().Wait();

Console.WriteLine("3. Finalizou a execução do programa.");



static async Task CallMethodAsync(){
  Console.WriteLine("1. Iniciou a execução do método;");
  await Task.Delay(4000);
  Console.WriteLine("2. Finalizou a execução do método;");
}