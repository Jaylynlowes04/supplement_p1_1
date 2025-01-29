namespace Supplement_p1_1.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldCalculateAreaOfRectangleWithDifferentLengthAndWidth()
    {
        Assert.True(50.0 == Supplement_p1_1.AreaOfRectangle(5.0,10.0));
    }
}
