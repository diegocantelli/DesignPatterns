namespace DesignPatterns.Interpreter
{
    public class Separador : IExpression
    {
        public void Avaliar(Context context)
        {
            var expressao = context.Expressao;
            context.Expressao = expressao.Replace(" ", "-");
        }
    }
}
