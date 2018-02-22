<Query Kind="Expression">
  <Connection>
    <ID>cf5587d8-4074-4c07-a9fa-7fb76d589013</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Core.dll</Reference>
</Query>

//1.Create a product list which indicates what products are purchased by our customers and how many 
//times that product was purchased. Order the list by most popular product by alphabetic description

//ToBeMarked
from x in Products
orderby x.OrderLists.Count() descending //this stops dupilcates by grouping by count
select new
{
	Product = x.Description,
	TimesPurchased = x.OrderLists.Count() 
}

//Vincent's notes
/////////////////
//from x in OrderLists
//group x.Product.ProductID
//select new
//{
//	ProductName = x.Product.Description, //Proof navigation property works
//	TimesPurchased = x.Product.OrderLists.Count() 
//}

//.Count() when used on Navigation Properties Must be a collection to returned 
//use them over joins

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