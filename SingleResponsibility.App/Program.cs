using SingleResponsibilityFALSE.App;

Product product = new Product();
product.Name = "test";
product.Id = 5;
product.SaveOrUpdate(product);
product.WriteToConsole();