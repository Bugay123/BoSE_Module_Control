namespace autoShowroom;

class Client
  {
    private CarFactory carFactory;

    public Client(CarFactory factory)
      {
        carFactory = factory;
      }

    public void Run()
      {
        Car car = carFactory.CreateCar();
        car.DisplayInfo();
      }
  }