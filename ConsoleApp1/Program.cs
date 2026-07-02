//Steps
//1. Create a connection string builder
//2. Config builder information: userID, password, initialCatalog, database
//3. Create a connection string from the builder
//4. Create a query (use @ for multiline)
//5. Create a sql command from query and connection
//6. Create an adapter from cmd
//7. Create a datatable
//8. Fill the table
//9. Loop the table

using TestingNameSpace;

AdoNetService service = new AdoNetService();
//service.Read();
//service.Create();
//service.Update();
service.Delete();