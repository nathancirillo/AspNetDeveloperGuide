namespace EFCoreCrud;
class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            //Console.Clear();
            Console.WriteLine("1 - Novo produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Editar produto");
            Console.WriteLine("4 - Excluir produto");
            Console.WriteLine("5 - Pesquisar produto");
            Console.WriteLine("0 - Sair");

            var opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1": CriarProduto(); break;
                case "2": ListarProdutos(); break;
                case "3": EditarProduto(); break;
                // case "4": ExcluirProduto(); break;
                // case "5": PesquisarProdutos(); break;
                case "0": return;
            }
        }
    }

    static void CriarProduto()
    {
        var product = new Product();
        Console.Write("Nome: ");
        product.Name = Console.ReadLine();
        Console.Write("Preço: ");
        product.Price = decimal.Parse(Console.ReadLine());
        new ProductService().Create(product);
    }

    static void EditarProduto(){   
        try
        {
            Console.Write("ID do produto: ");
            int idProduto = int.Parse(Console.ReadLine());
            Console.Write("Novo nome:");
            string novoNome = Console.ReadLine();
            Console.Write("Novo preço:");
            decimal novoPreco = decimal.Parse(Console.ReadLine());
            Product product = new Product()
            {
                Id = idProduto,
                Name = novoNome,
                Price = novoPreco
            };

            new ProductService().Update(product);
        }   
        catch(Exception ex)
        {

        } 
        
    }

    static void ListarProdutos()
    {
        var products = new ProductService().GetAll();
        foreach(var product in products)
        {
            Console.WriteLine($"{product.Name}");
        }
        Console.ReadKey();
    }
}
