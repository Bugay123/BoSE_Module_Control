namespace autoShowroom;

class SUVFactory : CarFactory
  {
    public Car CreateCar()
      {
        return new SUV();
      }
  }