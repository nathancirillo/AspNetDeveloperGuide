public class ProductService 
{
    private readonly ProductRepository _repository = new();
    public void Create(Product product)
    {
        Validate(product);
        _repository.Add(product);
    }

    public void Update(Product product)
    {
      Validate(product);
      
      var productExists = _repository.GetById(product.Id);
      if(productExists == null)
        throw new InvalidOperationException("Produto não encontrado!");
      
      _repository.Update(product);
    }

    public IEnumerable<Product> GetAll()
    {
      return _repository.GetAll();
    }

    private void Validate(Product product)
    {
        if(string.IsNullOrWhiteSpace(product.Name))
          throw new ArgumentException("Nome do produto é obrigatório!");

        if(product.Price <= 0)
          throw new ArgumentException("Preço deve ser maior que zero!");
    }
}