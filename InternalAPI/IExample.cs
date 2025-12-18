namespace InternalAPI;

public record ExampleReturnRecord(string content, int arg2)
{
}

public interface IExample
{
	ExampleReturnRecord GetExampleReturnRecord(string argument);
}