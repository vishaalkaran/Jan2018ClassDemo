<Query Kind="Expression">
  <Connection>
    <ID>560894c0-8e7d-4db3-a192-f8f3c7995b58</ID>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//3. Create a Daily Sales per Store request for a specified month. Order stores by city by location. 
//For Sales, show order date, number of orders, total sales without GST tax and total GST tax.

//Daily sales per month
//cty, loca., actual. sales --Stores Table

//in sales
//date, #ofOrd., total_w/NO-gst, justGST --Orders Table

from x in Stores
orderby x.City ascending
select new
{
	city = x.City,
	location = x.Location,
	sales = (from xx in Orders
			where xx.StoreID.Equals(x.StoreID) //matching storeID or will retun all dates for every store
			&& xx.OrderDate.Month.Equals("12") //Inputed month(December for test) 
			
			group xx by xx.OrderDate into dateTable //groupby's key is what ever it is grouped by here
			select new
			{
				date = dateTable.Key, //*perMonth
				NumberOfOrders = dateTable.Count(),
				productsales = (from y in dateTable select y.SubTotal).Sum(),			   
				gst = (from y in dateTable select y.GST).Sum()
				
			}).AsEnumerable()
}