<Query Kind="Expression">
  <Connection>
    <ID>a11f155d-e4e5-4ee4-bea0-f5ab1f395084</ID>
    <Persist>true</Persist>
    <Server>W203-038</Server>
    <Database>GroceryList</Database>
    <AlphabetizeColumns>true</AlphabetizeColumns>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Core.dll</Reference>
</Query>

//1.Create a product list which indicates what products are purchased by our customers and how many 
//times that product was purchased. Order the list by most popular product by alphabetic description
//Working
from x in OrderLists
select new
{
	ProductName = x.Product.Description,
	TimesPurchased = x.Product.Count()

}









////Tests
//from x in OrderLists
//group x by x.ProductID into prodNames
//orderby prodNames.Count() descending
//select new
//{
////Dont do this, b/c this will return each productname as an individual EnumerableQ...<...>
////name = (from y in Products
////				where y.ProductID.Equals(prodNames.Key)
////				select y.Description),	 
//
////Dont do this, b/c this will return a list of the same name, prodNames.Count() long
////	name = (from y in OrderLists
////			where y.ProductID.Equals(prodNames.Key)
////			select y.Product.Description),
//	count = prodNames.Count() 		 
//}