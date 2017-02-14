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
      Clock testClock = new Clock(8);
      int degreeTest = testClock.AngleReturn(testClock._hour);
      Assert.Equal(120, degreeTest);
    }
  }
}
