namespace InternalAPI;

public record ExampleReturnRecord(string content)
{
}

public interface IExample
{
	ExampleReturnRecord GetExampleReturnRecord(string argument);
}