using InternalAPI;

namespace Implementation;

public class Example: IExample {
	public ExampleReturnRecord GetExampleReturnRecord()
	{
		Console.WriteLine("QWE");
		return new ExampleReturnRecord("QWE", "qwe");
	} 
}