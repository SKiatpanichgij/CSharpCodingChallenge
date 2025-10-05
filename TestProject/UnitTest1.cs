namespace TestProject;

using System.IO.Pipelines;
using static MyNameSpace.MyMethodClass;

public class UnitTest
{
    [Theory]
    [InlineData("33#", "E")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    public void TestOldPhonePad_FromDocument(string input, string expected)
    {
        Assert.Equal(expected, OldPhonePad(input));
        Console.WriteLine($"Input: {input} => Output: {OldPhonePad(input)}");
    }

    [Fact]
    public void TestOldPhonePad_EmptyInput()
    {
        Assert.Equal(string.Empty, OldPhonePad(""));
        Console.WriteLine($"Input: {""} => Output: {OldPhonePad("")}");
    }

    [Fact]
    public void TestOldPhonePad_NoValidInput()
    {
        Assert.Equal(string.Empty, OldPhonePad("###"));
        Console.WriteLine($"Input: {"###"} => Output: {OldPhonePad("###")}");
        Assert.Equal(string.Empty, OldPhonePad("***"));
        Console.WriteLine($"Input: {"***"} => Output: {OldPhonePad("***")}");
        Assert.Equal(string.Empty, OldPhonePad("   "));
        Console.WriteLine($"Input: {"   "} => Output: {OldPhonePad("   ")}");
    }

    [Theory]
    [InlineData("2#", "A")]
    [InlineData("22#", "B")]
    [InlineData("222#", "C")]
    [InlineData("3#", "D")]
    [InlineData("33#", "E")]
    [InlineData("333#", "F")]
    [InlineData("4#", "G")]
    [InlineData("44#", "H")]
    [InlineData("444#", "I")]
    [InlineData("5#", "J")]
    [InlineData("55#", "K")]
    [InlineData("555#", "L")]
    [InlineData("6#", "M")]
    [InlineData("66#", "N")]
    [InlineData("666#", "O")]
    [InlineData("7#", "P")]
    [InlineData("77#", "Q")]
    [InlineData("777#", "R")]
    [InlineData("7777#", "S")]
    [InlineData("8#", "T")]
    [InlineData("88#", "U")]
    [InlineData("888#", "V")]
    [InlineData("9#", "W")]
    [InlineData("99#", "X")]
    [InlineData("999#", "Y")]
    [InlineData("9999#", "Z")]
    public void TestOldPhonePad_SingleCharacter(string input, string expected)
    {
        Assert.Equal(expected, OldPhonePad(input));
        Console.WriteLine($"Input: {input} => Output: {OldPhonePad(input)}");
    }

    [Theory]
    [InlineData("2222#", "A")] // Wrap around for '2'
    [InlineData("77777#", "P")] // Wrap around for '7'
    public void TestOldPhonePad_WrapAround(string input, string expected)
    {
        Assert.Equal(expected, OldPhonePad(input));
        Console.WriteLine($"Input: {input} => Output: {OldPhonePad(input)}");
    }

    [Fact]
    public void TestOldPhonePad_OnlySpaces()
    {
        Assert.Equal(string.Empty, OldPhonePad("     "));
        Console.WriteLine($"Input: {"     "} => Output: {OldPhonePad("     ")}");
    } 
}