<Query Kind="Expression">
  <Connection>
    <ID>560894c0-8e7d-4db3-a192-f8f3c7995b58</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//5. Select all orders a picker has done on a particular week (Sunday through Saturday). 
//List by picker and order by picker and date. Hint: you will need to use the join operator.

from x in Pickers
orderby x.LastName ascending
select new 
{
	picker = x.LastName + ", " + x.FirstName
	pickdates = from xx in Pickers
				orderby 
				
	


}