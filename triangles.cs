using System;
using System.Collections.Generic;

class Triangle
  {
    private int _sideOne;
    private int _sideTwo;
    private int _sideThree;

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      _sideOne = sideOne;
      _sideTwo = sideTwo;
      _sideThree = sideThree;
    }

    public void SetSideOne(int newSideOne)
    {
      _sideOne = newSideOne;
    }
    public int GetSideOne()
    {
      return _sideOne;
    }

    public void SetSideTwo(int newSideTwo)
    {
      _sideTwo = newSideTwo;
    }
    public int GetSideTwo()
    {
      return _sideTwo;
    }

    public void SetSideThree(int newSideThree)
    {
      _sideThree = newSideThree;
    }
    public int GetSideThree()
    {
      return _sideThree;
    }

    public void TriangleFinder()
    {
      if ((GetSideOne() + GetSideTwo()) < GetSideThree() || (GetSideThree() + GetSideOne()) < GetSideTwo() || (GetSideTwo() + GetSideThree()) < GetSideOne())
      {
        Console.WriteLine("Not a Triangle");
      }
        else if (GetSideOne() == GetSideTwo() && GetSideTwo() == GetSideThree())
        {
          Console.WriteLine("Equilateral");
        }
        else if (GetSideOne() == GetSideTwo() || GetSideTwo() == GetSideThree() || GetSideOne() == GetSideThree())
        {
          Console.WriteLine("Isosceles");
        }
        else if (GetSideOne() != GetSideTwo() && GetSideTwo() != GetSideThree())
        {
          Console.WriteLine("Scalene");
        }
    }
  }

  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Enter a length: ");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);
      // newTriangle.SetSideOne(sideOne);

      Console.WriteLine("Enter a length: ");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);
      // newTriangle.SetSideTwo(sideTwo);

      Console.WriteLine("Enter a length: ");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);
      // newTriangle.SetSideThree(sideThree);

      Triangle newTriangle = new Triangle(sideOne, sideTwo, sideThree);
      newTriangle.TriangleFinder();


      // newTriangle.TraingleFinder();
      //   .SetSideOne(sideOne);
      //   .SetSideTwo(sideTwo);
      //   .SetSideThree(sideThree);
    }
  }
