Console.WriteLine("0. Iniciou a execução do programa;");

//todo: verifique o resultado das diferenças de chamada:

//usando da forma abaixo a thread é liberada e aguarda que o método seja finalizado por completo.
// await CallMethodAsync();

//usando da forma abaixo a thread também fica liberada, porém não aguarda a finalização do método. 
// CallMethodAsync();

//já nesse caso, a thread é bloqueada (perigoso). A execução do método é aguardada, porém com a thread bloqueada.
// CallMethodAsync().Wait();

Console.WriteLine("3. Finalizou a execução do programa.");

static async Task CallMethodAsync(){
  Console.WriteLine("1. Iniciou a execução do método;");
  await Task.Delay(4000);
  Console.WriteLine("2. Finalizou a execução do método;");
}
