
  public interface IObservable
  {
      void Register(IObserver observer);

      void NotifyObservers();
  }

