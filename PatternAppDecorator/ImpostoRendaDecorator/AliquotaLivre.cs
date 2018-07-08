namespace PatternAppDecorator.ImpostoRendaDecorator
{
    public class AliquotaLivre : DecoratorImpostoRenda
    {
        public AliquotaLivre() : base() { }
        public AliquotaLivre(DecoratorImpostoRenda decoratorImpostoRenda) : base(decoratorImpostoRenda) { }

        public override decimal CalculaImposto(Salario salario) => 0 + CalculaImpostoDecorator(salario);
    }
}
