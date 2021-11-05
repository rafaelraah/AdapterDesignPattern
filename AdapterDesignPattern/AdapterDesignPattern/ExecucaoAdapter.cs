using System;

namespace AdapterDesignPattern
{
    public class ExecucaoAdapter
    {
        //Quando for tratado por injeção de dependencia, terá uma apresentação muito mais elegante nesta classe.
        public static void Executar()
        {
            //Usando o Logger
            var pagamentoLogPadrao = new TransacaoService(new Logger());
            pagamentoLogPadrao.RealizarTransacao();

            //Usando o LogNetMasterService
            //o lognetmasterservice irá inverter o controle por baixo dos panos
            var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
            pagamentoLogCustom.RealizarTransacao();


            //Aguardar tecla do usuário para finalizar o console
            Console.ReadKey();

        }
    }
}
