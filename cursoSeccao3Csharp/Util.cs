namespace cursoSeccao3Csharp
{
    class Util
    {
        // Metodo Estático, ou seja, ele existe independentemente de instanciar o objeto.
        public static int menorDentreTres(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }
            else if (num2 < num3)
            {
                return num2;
            }
            else
            {
                return num3;
            }                
        }
    }
}
