using InternalAPI;

namespace Implementation;

public class Example: IExample {
	public ExampleReturnRecord GetExampleReturnRecord(string argument)
	{
		Console.WriteLine("QWE");
		return new ExampleReturnRecord("QWE",5);
	} 
}