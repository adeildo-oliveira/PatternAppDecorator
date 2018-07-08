namespace PatternAppDecorator.ImpostoRendaDecorator
{
    public class AliquotaPercentual22 : DecoratorImpostoRenda
    {
        public AliquotaPercentual22() : base() { }
        public AliquotaPercentual22(DecoratorImpostoRenda decoratorImpostoRenda) : base(decoratorImpostoRenda) { }

        public override decimal CalculaImposto(Salario salario) => 636.13M + CalculaImpostoDecorator(salario);
    }
}
