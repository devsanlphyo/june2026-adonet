using June2026.EFCoreAssignmentDB.AppDbContextModels;

AppDbContext db = new AppDbContext();
// CRUD => Read (Table1.Book)
var books = db.TblTb1Books.ToList();
foreach (var book in books)
{
    Console.WriteLine($"{book.Id}. {book.Name} {book.Author}");
}

Console.WriteLine("==============================================");

// CRUD => Read (Table2.Food)
var foods = db.TblTb2Foods.ToList();
foreach (var food in foods)
{
    Console.WriteLine($"{food.Id}. {food.Name}, {food.Price}");
}

Console.WriteLine("==============================================");

// CRUD => Read (Table3.Todo)
var todos = db.TblTb3Todos.ToList();
foreach(var todo in todos)
{
    Console.WriteLine($"{todo.Id}. {todo.Content}");
}