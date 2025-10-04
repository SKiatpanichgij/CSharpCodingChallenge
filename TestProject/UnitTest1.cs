namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test()
    {
        /// Test cases for oldPhonePad 
        Console.WriteLine("Testing OldPhonePad conversion:");

        // Example test case
        Assert.Equal("E", MyNameSpace.MyMethodClass.OldPhonePad("33#")); // Output: E
        Assert.Equal("B", MyNameSpace.MyMethodClass.OldPhonePad("227*#")); // Output: B
        Assert.Equal("HELLO", MyNameSpace.MyMethodClass.OldPhonePad("4433555 555666#")); // Output: HELLO
        Assert.Equal("TURING", MyNameSpace.MyMethodClass.OldPhonePad("8 88777444666*664#")); // Output: ????

    }
}
