using System;


namespace Clocks.Objects
{
  public class Clock
  {

    public int _hour;

    public Clock(int hour)
    {
      _hour = hour;
    }

    public int AngleReturn(int hour)
    {
      if ((hour == 1) || (hour == 2) || (hour == 3) || (hour == 4) || (hour == 5) || (hour == 6))
      {
        return (hour * 30);
      }
      else
      {
        return 22;
      }
    }
  }
}
