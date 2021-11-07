using DesignPatterns.Command.Receiver;
using DesignPatterns.Commands;

namespace DesignPatterns.Command.ConcreteCommand
{
    public class Pedido : PedidoCommand
    {
        private Chef Chef { get; set; }
        private string Acao { get; set; }

        public Pedido(Chef chef, string acao)
        {
            Chef = chef;
            Acao = acao;
        }
        public override void Execute()
        {
            if (Acao.Equals("prato"))
            {
                Chef.PreparandoPrato();
            }
            else
            {
                Chef.PreparandoSobremesa();
            }
        }
    }
}
