namespace autoShowroom;

class Program
  {
    static void Main()
      {
        CarFactory sedanFactory = new SedanFactory();
        Client sedanClient = new Client(sedanFactory);
        sedanClient.Run();

        CarFactory suvFactory = new SUVFactory();
        Client suvClient = new Client(suvFactory);
        suvClient.Run();
      }
  }