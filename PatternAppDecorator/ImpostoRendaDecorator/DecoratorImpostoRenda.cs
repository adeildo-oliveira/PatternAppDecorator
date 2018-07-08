namespace PatternAppDecorator.ImpostoRendaDecorator
{
    public abstract class DecoratorImpostoRenda
    {
        private readonly DecoratorImpostoRenda _decoratorImpostoRenda;

        public DecoratorImpostoRenda() => _decoratorImpostoRenda = null;
        public DecoratorImpostoRenda(DecoratorImpostoRenda decoratorImpostoRenda) => 
            _decoratorImpostoRenda = decoratorImpostoRenda;

        protected decimal CalculaImpostoDecorator(Salario salario)
        {
            if (_decoratorImpostoRenda == null) return 0;

            return _decoratorImpostoRenda.CalculaImposto(salario);
        }

        public abstract decimal CalculaImposto(Salario salario);
    }
}
