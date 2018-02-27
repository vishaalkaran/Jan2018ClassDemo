<Query Kind="Expression">
  <Connection>
    <ID>560894c0-8e7d-4db3-a192-f8f3c7995b58</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//6. List all the products a customer (use Customer #1) has purchased and the number of times 
//the product was purchased. Order by number of times purchased then description

from x in Customers
select new
{
	Customer = x.LastName + ", " + x.FirstName,
	OrdersCount = x.Orders.OrderLists.Count()


}