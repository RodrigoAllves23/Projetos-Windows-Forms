namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Result { get; set; }
        public decimal Value { get; set; }

        private Operation OperationSelected { get; set; }

        private enum Operation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            Percentage,
            Factorial
        }

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e) => txt_Result.Text += "0";
        private void btn_1_Click(object sender, EventArgs e) => txt_Result.Text += "1";
        private void btn_2_Click(object sender, EventArgs e) => txt_Result.Text += "2";
        private void btn_3_Click(object sender, EventArgs e) => txt_Result.Text += "3";
        private void btn_4_Click(object sender, EventArgs e) => txt_Result.Text += "4";
        private void btn_5_Click(object sender, EventArgs e) => txt_Result.Text += "5";
        private void btn_6_Click(object sender, EventArgs e) => txt_Result.Text += "6";
        private void btn_7_Click(object sender, EventArgs e) => txt_Result.Text += "7";
        private void btn_8_Click(object sender, EventArgs e) => txt_Result.Text += "8";
        private void btn_9_Click(object sender, EventArgs e) => txt_Result.Text += "9";

        private void btn_Addition_Click(object sender, EventArgs e)
        {
            OperationSelected = Operation.Addition;
            Value = Convert.ToDecimal(txt_Result.Text);
            txt_Result.Text = "";
            lbl_Operation.Text = "+";
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {
            OperationSelected = Operation.Subtraction;
            Value = Convert.ToDecimal(txt_Result.Text);
            txt_Result.Text = "";
            lbl_Operation.Text = "-";
        }

        private void btn_Multiplication_Click(object sender, EventArgs e)
        {
            OperationSelected = Operation.Multiplication;
            Value = Convert.ToDecimal(txt_Result.Text);
            txt_Result.Text = "";
            lbl_Operation.Text = "X";
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            OperationSelected = Operation.Division;
            Value = Convert.ToDecimal(txt_Result.Text);
            txt_Result.Text = "";
            lbl_Operation.Text = "/";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "")
                txt_Result.Text = "0";

            try
            {
                switch (OperationSelected)
                {
                    case Operation.Addition:
                        Result = Value + Convert.ToDecimal(txt_Result.Text);
                        break;
                    case Operation.Subtraction:
                        Result = Value - Convert.ToDecimal(txt_Result.Text);
                        break;
                    case Operation.Multiplication:
                        Result = Value * Convert.ToDecimal(txt_Result.Text);
                        break;
                    case Operation.Division:
                        decimal divisor = Convert.ToDecimal(txt_Result.Text);
                        if (divisor == 0)
                            throw new DivideByZeroException("Não é possível dividir por zero.");
                        Result = Value / divisor;
                        break;
                    case Operation.Percentage:
                        try
                        {
                            double baseValue = Convert.ToDouble(Value); // Valor antes de clicar no %
                            string valorFinalTexto = txt_Result.Text.Replace("%", "");
                            double percentual = Convert.ToDouble(valorFinalTexto); // 50

                            Result = Convert.ToDecimal((baseValue * percentual) / 100); // 200 * 50 / 100 = 100
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Erro: valores inválidos para o cálculo de porcentagem.");
                            Result = 0;
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("Erro: divisão por zero.");
                            Result = 0;
                        }
                        break;

                    case Operation.Factorial:
                        if (Value < 0 || Value % 1 != 0)
                            throw new ArgumentException("Somente números inteiros positivos são válidos para fatorial.");

                        Result = 1;
                        for (int i = 2; i <= (int)Value; i++)
                        {
                            Result *= i;
                        }
                        break;

                }
                txt_Result.Text = Convert.ToString(Result);
                lbl_Operation.Text = "=";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                txt_Result.Text = "";
                lbl_Operation.Text = "";
            }
        }

        private void btn_Comma_Click(object sender, EventArgs e)
        {
            if (!txt_Result.Text.Contains(","))
                txt_Result.Text += ",";
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_Result.Text = "";
            lbl_Operation.Text = "";
        }

        private void btn_click_one_Click(object sender, EventArgs e)
        {
            if (txt_Result.TextLength > 0)
            {
                txt_Result.Text = txt_Result.Text.Remove(txt_Result.Text.Length - 1);
            }
        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            if (!txt_Result.Text.Contains("%"))
                txt_Result.Text += "%";

            OperationSelected = Operation.Percentage;
            lbl_Operation.Text = "%";
        }

        private double CalcularPorcentagem(double baseValue, double percentage, string operation = "aplicar")
        {
            switch (operation.ToLower())
            {
                case "aplicar":
                    return (baseValue * percentage) / 100.0;
                case "somar":
                    return baseValue + ((baseValue * percentage) / 100.0);
                case "subtrair":
                    return baseValue - ((baseValue * percentage) / 100.0);
                default:
                    throw new ArgumentException("Operação inválida. Use 'aplicar', 'somar' ou 'subtrair'.");
            }
        }

        private void Btn_Fatorial_Click(object sender, EventArgs e)
        {
            try
            {
                Value = Convert.ToDecimal(txt_Result.Text);
                OperationSelected = Operation.Factorial;
                lbl_Operation.Text = $"{Value}!";
                txt_Result.Text = ""; // Pode limpar ou não, depende do seu fluxo
            }
            catch
            {
                MessageBox.Show("Digite um número válido para calcular o fatorial.");
            }
        }
    }
}
