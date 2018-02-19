<Query Kind="Expression">
  <Connection>
    <ID>0459a962-575d-42ef-886c-d4b2fe047e98</ID>
    <Server>DESKTOP-IMH8G8I\SQL</Server>
    <Database>GroceryList</Database>
    <IncludeSystemObjects>true</IncludeSystemObjects>
  </Connection>
</Query>

//2. We want a mailing list for a Valued Customers flyer that is being sent out. List the 
//customer addresses for customers who have shopped at each store. List by the store. 
//Include the store location as well as the customer's address. Do NOT include 
//the customer name in the results.

//list by stores with the andressess of customers who shop there + no name!
from x in Stores
orderby x.Location ascending 
select new
{
	Location = x.Location,
	Clients =   ((from xx in Orders
				where xx.StoreID.Equals(x.StoreID) //cust for each store
				orderby xx.Customer.CustomerID ascending //ordered like in demo 
				select new
				{
					address = xx.Customer.Address,
					city = xx.Customer.City,
					province = xx.Customer.Province
				}).Distinct()).AsEnumerable() //.AsEnumerable() like in demo 


}

