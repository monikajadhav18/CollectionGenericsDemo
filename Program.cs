using CollectionGenericsDemo.Models;
using CollectionGenericsDemo.Utilities;

// ============================================
// 1. Create Products
// ============================================

Product product1 = new Product(
    101,
    "Laptop",
    55000,
    "Electronics"
);

Product product2 = new Product(
    102,
    "Mobile",
    25000,
    "Electronics"
);

Product product3 = new Product(
    103,
    "Desk",
    8000,
    "Furniture"
);


// ============================================
// 2. Array
// ============================================

string[] productNames =
{
    "Laptop",
    "Mobile",
    "Desk"
};

Console.WriteLine("===== ARRAY =====");

foreach (string name in productNames)
{
    Console.WriteLine(name);
}


// ============================================
// 3. List
// ============================================

List<Product> products = new List<Product>();

products.Add(product1);
products.Add(product2);
products.Add(product3);

Console.WriteLine();
Console.WriteLine("===== LIST =====");

foreach (Product product in products)
{
    Console.WriteLine(product);
}

Console.WriteLine($"Total products: {products.Count}");


// ============================================
// 4. Dictionary
// ============================================

Dictionary<int, Product> productDictionary =
    new Dictionary<int, Product>();

productDictionary.Add(product1.Id, product1);
productDictionary.Add(product2.Id, product2);
productDictionary.Add(product3.Id, product3);

Console.WriteLine();
Console.WriteLine("===== DICTIONARY =====");

if (productDictionary.TryGetValue(102, out Product? foundProduct))
{
    Console.WriteLine(foundProduct);
}
else
{
    Console.WriteLine("Product not found.");
}


// ============================================
// 5. HashSet
// ============================================

HashSet<string> categories = new HashSet<string>();

categories.Add("Electronics");
categories.Add("Furniture");
categories.Add("Electronics");
categories.Add("Clothing");
categories.Add("Furniture");

Console.WriteLine();
Console.WriteLine("===== HASHSET =====");

foreach (string category in categories)
{
    Console.WriteLine(category);
}


// ============================================
// 6. Queue
// ============================================

Queue<Product> productQueue = new Queue<Product>();

productQueue.Enqueue(product1);
productQueue.Enqueue(product2);
productQueue.Enqueue(product3);

Console.WriteLine();
Console.WriteLine("===== QUEUE =====");

Product nextProduct = productQueue.Peek();

Console.WriteLine($"Next product: {nextProduct}");

Product processedProduct = productQueue.Dequeue();

Console.WriteLine($"Processed: {processedProduct}");


// ============================================
// 7. Stack
// ============================================

Stack<Product> recentProducts = new Stack<Product>();

recentProducts.Push(product1);
recentProducts.Push(product2);
recentProducts.Push(product3);

Console.WriteLine();
Console.WriteLine("===== STACK =====");

Product topProduct = recentProducts.Peek();

Console.WriteLine($"Top product: {topProduct}");

Product lastViewedProduct = recentProducts.Pop();

Console.WriteLine($"Removed: {lastViewedProduct}");


// ============================================
// 8. Generic Method
// ============================================

Console.WriteLine();
Console.WriteLine("===== GENERIC METHOD =====");

DisplayHelper.Display(100);
DisplayHelper.Display("Hello");
DisplayHelper.Display(99.99m);
DisplayHelper.Display(product1);


// ============================================
// 9. Generic Result Model
// ============================================

Result<Product> productResult = new Result<Product>
{
    Success = true,
    Message = "Product retrieved successfully.",
    Data = product1
};

Console.WriteLine();
Console.WriteLine("===== RESULT PRODUCT =====");

Console.WriteLine($"Success: {productResult.Success}");
Console.WriteLine($"Message: {productResult.Message}");
Console.WriteLine($"Data: {productResult.Data}");


// ============================================
// 10. Result<List<Product>>
// ============================================

Result<List<Product>> productsResult =
    new Result<List<Product>>
    {
        Success = true,
        Message = "Products retrieved successfully.",
        Data = products
    };

Console.WriteLine();
Console.WriteLine("===== RESULT LIST =====");

Console.WriteLine($"Success: {productsResult.Success}");
Console.WriteLine($"Message: {productsResult.Message}");

foreach (Product product in productsResult.Data!)
{
    Console.WriteLine(product);
}


// ============================================
// 11. Generic Repository
// ============================================

Repository<Product> productRepository =
    new Repository<Product>();

productRepository.Add(product1);
productRepository.Add(product2);
productRepository.Add(product3);

Console.WriteLine();
Console.WriteLine("===== GENERIC REPOSITORY =====");

List<Product> repositoryProducts =
    productRepository.GetAll();

foreach (Product product in repositoryProducts)
{
    Console.WriteLine(product);
}