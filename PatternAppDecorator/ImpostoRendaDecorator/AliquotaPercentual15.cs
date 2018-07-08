namespace PatternAppDecorator.ImpostoRendaDecorator
{
    public class AliquotaPercentual15 : DecoratorImpostoRenda
    {
        public AliquotaPercentual15() : base() { }
        public AliquotaPercentual15(DecoratorImpostoRenda decoratorImpostoRenda) : base(decoratorImpostoRenda) { }

        public override decimal CalculaImposto(Salario salario) => 354.80M + CalculaImpostoDecorator(salario);
    }
}
