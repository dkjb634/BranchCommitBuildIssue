namespace InternalAPI;

public record ExampleReturnRecord(string content, int arg2, int arg3)
{
}

public interface IExample
{
	ExampleReturnRecord GetExampleReturnRecord(string argument);
}