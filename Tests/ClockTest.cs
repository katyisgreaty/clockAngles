using Xunit;
using System.Collections.Generic;
using Clocks.Objects;

namespace Clocks
{
  public class ClockTest
  {
    [Fact]
    public void Degrees_angle()
    {
      Clock testClock = new Clock(5);
      int degreeTest = testClock.AngleReturn(testClock._hour);
      Assert.Equal(150, degreeTest);
    }
  }
}
