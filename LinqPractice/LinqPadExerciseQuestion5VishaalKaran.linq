<Query Kind="Expression">
  <Connection>
    <ID>560894c0-8e7d-4db3-a192-f8f3c7995b58</ID>
    <Server>.</Server>
    <Database>GroceryList</Database>
  </Connection>
</Query>

//5. Select all orders a picker has done on a particular week (Sunday through Saturday). 
//List by picker and order by picker and date. Hint: you will need to use the join operator.

//For table names
//I am assuming that this result set is...  Picker name (OrderID, Date)
//I origninal thought the result set was... Picker name (PickerID, Date)

from x in Pickers
orderby x.LastName ascending
select new 
{
	picker = x.LastName + ", " + x.FirstName,
	//pickerID = x.PickerID, not by this
	pickdates = (from xx in Pickers
				join xxx in Stores on xx.StoreID equals xxx.StoreID
				join xxxx in Orders on xxx.StoreID equals xxxx.StoreID
			
				where xxxx.PickerID == x.PickerID
				//Must convert to datetime to extract Day, Month, Year 
				&& ((DateTime)xxxx.PickedDate).Date.Month == 12 
				&& ((DateTime)xxxx.PickedDate).Date.Year == 2017
  				&& ((DateTime)xxxx.PickedDate).Date.Day <= 23 //upper limit
				&& ((DateTime)xxxx.PickedDate).Date.Day >= 18 //lower limit
				
				orderby xxxx.PickedDate descending //*****THIS LINE HAS NO EFFECT COMMENTED OR NOT??!??
				 
				select new
				{
					//ID = xxxx.PickerID, not this apprently 
					ID = xxxx.OrderID,
					Date = xxxx.PickedDate
				}).AsEnumerable().Distinct()
}