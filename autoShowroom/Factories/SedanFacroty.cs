namespace autoShowroom;

class SedanFactory : CarFactory
  {
    public Car CreateCar()
      {
        return new Sedan();
      }
  }