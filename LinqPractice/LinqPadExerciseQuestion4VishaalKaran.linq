<Query Kind="Expression">
  <Connection>
    <ID>bd264a3d-7d04-48fa-98b8-17cda44012e3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//4.Print out all product items on a requested order (use Order #33). Group by Category 
//and order by Product Description. You do not need to format money as this would be done 
//at the presentation level. Use the QtyPicked in your calculations.
//Hint: You will need to using type casting (decimal). Use of the ternary operator will help.

from x in OrderLists
where x.OrderID.Equals("33")
group x by x.Product.Category into catTable //you can group by with nav property
orderby catTable.Key.Description
select new
{	

	Category = catTable.Key.Description,		   
	
	//OrderProducts = x.Product 		   
			   
	OrderProducts = from xx in OrderLists
					where xx.OrderID.Equals("33")
					select new
					{
						Product = xx.Product.Description,
						Price = xx.Product.Price,
						PickedQtY = 1,
						Discount = xx.Product.Discount,
						Subtotal = 1,
						Tax = xx.Product.Price * 0,
						ExtendedProce = 1
					}

}