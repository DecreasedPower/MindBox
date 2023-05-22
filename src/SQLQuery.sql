SELECT p.Name AS ProductName, c.Name AS CategoryName FROM Products p
LEFT JOIN ProductsCategories pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON c.Id = pc.CategoryId
