class Calculadora{
    public static double Operacao (double peso1, double peso2, double peso3, double peso4, double num1, double num2, double num3, double num4){
        double resultado = double.NaN; 
        
        resultado = (num1*peso1 + num2*peso2 + num3*peso3 + num4*peso4)/(peso1 + peso2 + peso3 + peso4);

        return resultado;
    }
}

class Programa{
    static void Main(string[] args){
        bool fim = false;
        string n1="";
        string n2="";
        string n3="";
        string n4="";
        string p1="";
        string p2="";
        string p3="";
        string p4="";
        double num1=0;
        double num2=0;
        double num3=0;
        double num4=0;
        double peso1=0;
        double peso2=0;
        double peso3=0;
        double peso4=0;
        double resultado=0;
        double mediaTurma=0;
        var mediaEstudantes = new List<double>();

        Console.WriteLine("Médias dos Estudantes");
        Console.WriteLine("-----------------\n");

        Console.Write("Digite o peso da 1º nota e pressione enter: ");
            p1 = Console.ReadLine();
            
            while(!double.TryParse(p1, out peso1)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite o peso da 1º nota novamente e pressione enter: ");
                p1 = Console.ReadLine();
            }

        Console.Write("Digite o peso da 2º nota e pressione enter: ");
            p2 = Console.ReadLine();
            
            while(!double.TryParse(p2, out peso2)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite o peso da 2º nota novamente e pressione enter: ");
                p2 = Console.ReadLine();
            }

        Console.Write("Digite o peso da 3º nota e pressione enter: ");
            p3 = Console.ReadLine();
            
            while(!double.TryParse(p3, out peso3)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite o peso da 3º nota novamente e pressione enter: ");
                p3 = Console.ReadLine();
            }

        Console.Write("Digite o peso da 4º nota e pressione enter: ");
            p4 = Console.ReadLine();
            
            while(!double.TryParse(p4, out peso4)){
                Console.Write("Número Inválido. ");
                Console.Write("Digite o peso da 4º nota novamente e pressione enter: ");
                p4 = Console.ReadLine();
            }

        while(!fim){
            Console.Write("Digite a 1º nota e pressione enter: ");
            n1 = Console.ReadLine();
            
            while(!double.TryParse(n1, out num1)){
                Console.Write("Número Inválido. Digite a 1º nota novamente e pressione enter: ");
                n1 = Console.ReadLine();
            }

            Console.Write("Digite a 2º nota e pressione enter: ");
            n2 = Console.ReadLine();
            
            while(!double.TryParse(n2, out num2)){
                Console.Write("Número Inválido. Digite a 2º nota novamente e pressione enter: ");
                n2 = Console.ReadLine();
            }

            Console.Write("Digite a 3º nota e pressione enter: ");
            n3 = Console.ReadLine();
            
            while(!double.TryParse(n3, out num3)){
                Console.Write("Número Inválido. Digite a 3º nota novamente e pressione enter: ");
                n3 = Console.ReadLine();
            }

            Console.Write("Digite a 4º nota e pressione enter: ");
            n4 = Console.ReadLine();
            
            while(!double.TryParse(n4, out num4)){
                Console.Write("Número Inválido. Digite a 4º nota novamente e pressione enter: ");
                n4 = Console.ReadLine();
            }

            try{
                resultado = Calculadora.Operacao(peso1, peso2, peso3, peso4, num1, num2, num3, num4);

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
