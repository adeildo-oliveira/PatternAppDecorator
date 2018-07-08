namespace PatternAppDecorator.ImpostoRendaDecorator
{
    public class AliquotaPercentual27 : DecoratorImpostoRenda
    {
        public AliquotaPercentual27() : base() { }
        public AliquotaPercentual27(DecoratorImpostoRenda decoratorImpostoRenda) : base(decoratorImpostoRenda) { }

        public override decimal CalculaImposto(Salario salario) => 869.36M + CalculaImpostoDecorator(salario);
    }
}
