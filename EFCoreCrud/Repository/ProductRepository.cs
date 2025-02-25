using Microsoft.EntityFrameworkCore;

public class ProductRepository
{
    public void Add(Product product)
    {
       using var context = new AppContext();
       context.Products.Add(product);
       context.SaveChanges();
    }

    public void Update(Product product)
    {
        using var context = new AppContext();
        context.Products.Update(product);
        context.SaveChanges();
    }

    public bool Remove(int id)
    {
      using var context = new AppContext();
      var product = context.Products.Find(id);
      if (product == null) return false; 

      context.Products.Remove(product);
      return context.SaveChanges() > 0;
    }

    public Product? GetById(int id)
    {
      using var context = new AppContext();
      return context.Products
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Product> GetByName(string name)
    {
      using var context = new AppContext();
      var products = context.Products
                    .Where(x => x.Name.Contains(name) && x.Active)
                    .OrderBy(x => x.Name)
                    .AsNoTracking()
                    .ToList();
      return products;
    }

    public IEnumerable<Product> GetAll(){
      using var context = new AppContext();
      var products = context.Products.ToList();
      return products;
    }

}