namespace PatternAppDecorator.ImpostoRendaDecorator
{
    public class AliquotaPercentual7 : DecoratorImpostoRenda
    {
        public AliquotaPercentual7() : base() { }
        public AliquotaPercentual7(DecoratorImpostoRenda decoratorImpostoRenda) : base(decoratorImpostoRenda) { }

        public override decimal CalculaImposto(Salario salario) => 142.80M + CalculaImpostoDecorator(salario);
    }
}
