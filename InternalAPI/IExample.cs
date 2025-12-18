namespace InternalAPI;

public record ExampleReturnRecord(string content, string seconds)
{
}

public interface IExample
{
	ExampleReturnRecord GetExampleReturnRecord();
}