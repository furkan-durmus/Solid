using SingleResponsibilityTRUE.App;


Product product = new Product {Name = "Kalem", Id = 1 };
Product product2 = new Product {Name = "Kalem", Id = 2 };
ProductRepository repository = new ProductRepository();
ProductPresenter presenter = new ProductPresenter();
repository.SaveOrUpdate(product);
repository.SaveOrUpdate(product2);
presenter.WriteToConsole(repository.GetProducts);
