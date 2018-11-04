using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * (porcentagem / 100);
        }

        

        //Sobrecarregar o método ToString para retornar uma String do meu Objeto
        public override string ToString()
        {
            return "\nDados do funcionário: "
                + nome
                + ", R$ "
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
