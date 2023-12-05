public class Universidad{
    public string Nombre;
    public List<string> votos = new List<string>();
    
    public Universidad()
    {
        
    }
    public Universidad(string Nombre, List<string> votos)
    {
        this.Nombre = Nombre;
        this.votos = votos;
    }
    public Universidad(string Nombre)
    {
        this.Nombre = Nombre;
    }
}