using System;

namespace AdapterDesignPattern
{
    //Outra interface, outro estilo de Log, faz a mesma coisa, mas de forma diferente.
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
