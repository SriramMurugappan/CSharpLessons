using LibraryA;

Book book = new Book();
book.Title = "To kill a Mocking Bird";
book.Author = "Harper lee";
book.Genre = "Social";
book.bookprice = 250;
book.DateofPublish = new DateTime(1995, 06, 01);
book.BookMarkPage(125);
Console.WriteLine(book.GetCurrentPage());

Calculator calculator = new Calculator();
int addResult = calculator.Add(100, 40);
Console.WriteLine(addResult);
int multiplyResult = calculator.Multiply(100, 40);
Console.WriteLine(multiplyResult);
int divideResult = calculator.Divide(100, 40);
Console.WriteLine(divideResult);
