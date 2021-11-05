using System;

namespace AdapterDesignPattern
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}
