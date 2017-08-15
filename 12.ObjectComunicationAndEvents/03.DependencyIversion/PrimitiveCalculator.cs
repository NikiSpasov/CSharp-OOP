public class PrimitiveCalculator
{
    private IStrategi strategi;
    

    public PrimitiveCalculator()
    {
        this.strategi = new AdditionStrategy();
    }

    public void changeStrategy(char @operator)
    {
        switch (@operator)
        {
            case '+':
                this.strategi = new AdditionStrategy();
                break;
            case '-':
                this.strategi = new SubtractionStrategy();
                break;
            case '*':
                this.strategi = new MultuplyStrategy();
                break;
            case '/':
                this.strategi = new DivideStrategy();
                break;
        }
    }

    public int performCalculation(int firstOperand, int secondOperand)
    {
        return this.strategi.Calculate(firstOperand, secondOperand);
    }
}

