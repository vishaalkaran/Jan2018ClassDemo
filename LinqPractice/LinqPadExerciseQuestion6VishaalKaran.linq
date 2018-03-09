<Query Kind="Expression">
  <Connection>
    <ID>560894c0-8e7d-4db3-a192-f8f3c7995b58</ID>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//6. List all the products a customer (use Customer #1) has purchased and the number of times 
//the product was purchased. Order by number of times purchased then description

from x in Customers
where x.CustomerID == 1
select new
{
	Customer = x.LastName + ", " + x.FirstName,
	OrdersCount = x.Orders.Count(),
	Items = (from xx in OrderLists 
			join xxx in Orders on xx.OrderID equals xxx.OrderID
			where x.CustomerID == xxx.CustomerID
			group xx by xx.Product into prod
			orderby prod.Key.Description ascending
			select new 
			{	
				description = prod.Key.Description,
				timesbought = prod.Count()
				
			}).AsEnumerable()


}