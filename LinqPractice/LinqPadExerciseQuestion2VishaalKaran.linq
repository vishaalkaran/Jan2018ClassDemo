<Query Kind="Expression">
  <Connection>
    <ID>cf5587d8-4074-4c07-a9fa-7fb76d589013</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>GroceryList</Database>
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