
using System.Globalization;

Console.Write("Ingrese la cantidad de Universidades: ");
int valor = Convert.ToInt32(Console.ReadLine());
List<Universidad> universidades = new List<Universidad>();
for(int i = 1; i<=valor; i++){
    Console.Write("Ingrese el nombre de la universidad " + i + ": ");
    string nombre = Console.ReadLine();
    Universidad creando = new Universidad(nombre);
    universidades.Add(creando);
}
string voto;
for(int i = 0;i<universidades.Count(); i++){
    do
    {
        Console.Write("Ingrese el voto para la universidad " + universidades[i].Nombre + ": ");
        voto = Console.ReadLine();
        universidades[i].votos.Add(voto);
    } while (voto.ToLower() != "x".ToLower());
}
MostrarInfo();

void MostrarInfo(){
    int aceptan = 0;
    int rechazan = 0;
    int empatan = 0;
    Console.WriteLine("----------------------------------------------------------");
    for(int i = 0; i< universidades.Count();i++){
        int A = 0;
        int R = 0;
        int B = 0;
        int N = 0;
        Console.WriteLine("universidad: " + universidades[i].Nombre);
        for(int j = 0;j<universidades[i].votos.Count();j++){
            Console.WriteLine("Voto: " + universidades[i].votos[j]);
            switch(universidades[i].votos[j]){
                case "A":
                    A += 1;
                    break;
                case "R":
                    R += 1;
                    break;
                case "B":
                    B += 1;
                    break;
                case "N":
                    N += 1;
                    break;    
                default:
                    break;
            }
        }
        Console.WriteLine(universidades[i].Nombre + ": " + A + " aceptan, " + R + " rechazan, " + B + " blancos, " + N + " nulos.");
        if(A>0 || R>0){
            if(A>R){
                aceptan +=1;
            }else if(R>A){
                rechazan +=1;
            }
            else if(R == A){
                empatan += 1;
            }
        }
    }
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("Universidades que aceptan: " + aceptan);
    Console.WriteLine("Universidades que rechazan: " + rechazan);
    Console.WriteLine("Universidades que empatan: " + empatan);


}

