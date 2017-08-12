namespace _01.Logger.Contracts
{
    public interface ILogger
    {

        void Error(string timeStamp, string message);

        void Info(string timeStamp, string message);

        void Fatal(string timeStamp, string message);

        void Critical(string timeStamp, string message);

        void Warn(string timeStamp, string message);


    }
}
