# Notes : Inheritance

namespace WebappAPI.docs;

public class Indications : Entity
{
    // public Guid Id { get; set; }
    public string Name { get; private set; }
    public string Code { get; set; }
    public string? RegionImageUrl { get; set; }
    public Indications()
    {
        Id = Guid.NewGuid();
    }

    public Indications(Guid id)
    {
        Id = id;
    }


    public void ChangeInfo(string name, string? code = null)
    {
        Name = name;
        Code = code ?? Code;
    }
}


public abstract class Entity
{
    public Guid Id { get; set; }
}

public class Generic
{
    public void S()
    {

        Indications a = new();
        a.ChangeInfo("s");
    }
}

/* Concepts:
 * 
 * 1)
    -   Polymorphism, 
    -   Inheritance,
    -   Abstract class

    2)
    -   Public, private,... keywords

    3)
    - Document Swagger api writing a comment that shows in the front-end


    ----  ---- ---- ----
 
# SQL tables , views, fetches from  the frontend

Contract {
	public int Id (get; set;)
	public string Name (get; set;)

	public int StatusId(get;set;) -- fk

	public Status Status (get;set;) -- navigator into Status table
}


Status {
	public int Id (get;set;) 
	public string name (get; set;)

	public ICollection <Contract> Contracts (get;set;)
	
}


protected override void onModelCreating (ModelBuilder modelbuilder)
{
	modelBuilder.Entity <Contract>()
	.HasOne(c => c.Status) 			-- navigator into Status table = 1 to 1 = 1 Contract : 1 Status
	.WithMany(s => s.Contracts) 		-- a status can be shared among many contracts = 1 to Many = 1 Status : Many Contracts
	.HasForeignKey (c => c.StatusId);	-- take the StatusId from the Contract table, and attach a foreign keys towards the Status table (Id) to it = StatusId -> Status.Id property
}



Insert into Contract ( Name, StatusId )
values ("ACME Group", 3)

Insert into Status (Name)
values ("Draft", "Pending approval", "Active", "Pending renewal", "Expired")


-- -- -- --
## LOGIC FLOW WITH THE VIEW

View:
SQL SERVER MANAGER
create view View_Contract_Status as
	select Contract.Name as Contract title,
	Contract.Id as Contract id from Contract,
	Status.Name as Status

ENTITY FRAMEWORK:
	public class ContractStatusView
	
	-> then for the contract list in the frontend do:
	SELECT * FROM View_Contract_Status

		expected output : 
			{
    				"ContractId": 1,
    				"ContractTitle": "Contract with ACME",
    				"StatusName": "Active"
 			},
			{
    				"ContractId": 2,
    				"ContractTitle": "Contract with Geo Terme",
    				"StatusName": "Active"
 		 	}
	-> Then, when user clicks / taps on Contract where Id = 1,
	
	get /api/contracts/${id}
	navigate to dynamic page Single-Contract: 
		this is the routing indication: <Route path='/view-single-contract/:id' element={<ViewSingleContract/>}/> {/** ROUTE TO DISPLAY THE SINGLE-CONTRACT PAGE DYNAMICALLY */}
		or something similar, even performed by the backend, I'll discover
	
	SELECT * FROM Contract WHERE Id = @id; to retrieve the data from the sql server table and make them updatable through the put method



