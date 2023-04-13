class Calculadora{
    public static double Operacao (double num1, double num2, double num3){
        double resultado = double.NaN; 
        
        resultado = (num1 + num2 + num3)/3;

        return resultado;
    }
}

class Programa{
    static void Main(string[] args){
        bool fim = false;
        string n1="";
        string n2="";
        string n3="";
        double num1=0;
        double num2=0;
        double num3=0;
        double resultado=0;
        double mediaTurma=0;
        var mediaEstudantes = new List<double>();

        Console.WriteLine("Médias dos Estudantes");
        Console.WriteLine("-----------------\n");

        while(!fim){
            Console.Write("Digite a 1º nota e pressione enter: ");
            n1 = Console.ReadLine();
            
            while(!double.TryParse(n1, out num1)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite a 1º nota novamente e pressione enter: ");
                n1 = Console.ReadLine();
            }

            Console.Write("Digite a 2º nota e pressione enter: ");
            n2 = Console.ReadLine();
            
            while(!double.TryParse(n2, out num2)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite a 2º nota novamente e pressione enter: ");
                n2 = Console.ReadLine();
            }

            Console.Write("Digite a 3º nota e pressione enter: ");
            n3 = Console.ReadLine();
            
            while(!double.TryParse(n3, out num3)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite a 3º nota novamente e pressione enter: ");
                n3 = Console.ReadLine();
            }

            try{
                resultado = Calculadora.Operacao(num1, num2, num3);

                if (double.IsNaN(resultado)){
                    Console.WriteLine("Esta operação resultará em um erro matemático\n");
                }else{
                    Console.WriteLine("Seu resultado é: {0:0.##}", resultado);
                    mediaEstudantes.Add(resultado);
                }
            }catch (Exception e){
                Console.WriteLine("Ocorreu uma exceção.\n-Detalhes: " + e.Message);
            }

            Console.Write("\nDigite 'n' para fechar a aplicação ou qualquer tecla para continuar: ");
            if (Console.ReadLine() == "n"){
                fim=true;
            }
        }
        for(var i=0; i<mediaEstudantes.Count; i++){
            mediaTurma = mediaTurma + mediaEstudantes[i];
        }
        Console.WriteLine("Média da Turma: {0:0.##}\n", mediaTurma/mediaEstudantes.Count);

        return;
    }
}
