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
      if ((hour >= 1) && (hour <=6))
      {
        return (hour * 30);
      } else if ((hour >= 7) && (hour <=12))
      {
        return (360 - (hour * 30));
      }
      else
      {
        return 400;
      }
    }
  }
}


// (hour == 7) || (hour == 8) || (hour == 9) || (hour == 10) || (hour == 11) || (hour == 12)
