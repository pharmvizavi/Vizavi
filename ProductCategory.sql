USE [Test]
GO

SELECT product
	  ,category
  FROM Products p
  left join CategoryProduct cp on p.Id=cp.ProductId
  left join Categories c on cp.CategoryId=c.Id


GO