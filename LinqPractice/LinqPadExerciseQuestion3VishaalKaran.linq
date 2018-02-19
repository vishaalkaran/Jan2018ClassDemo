<Query Kind="Expression">
  <Connection>
    <ID>0459a962-575d-42ef-886c-d4b2fe047e98</ID>
    <Server>DESKTOP-IMH8G8I\SQL</Server>
    <Database>GroceryList</Database>
    <IncludeSystemObjects>true</IncludeSystemObjects>
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
	sales = from xx in Orders
			orderby xx.OrderDate ascending
			select new
			{
				date = xx.OrderDate, //*perMonth
				NumberOfOrders = 9,
				SubTotal = xx.SubTotal,
				GST = xx.GST
			
			
			}
			
	


}