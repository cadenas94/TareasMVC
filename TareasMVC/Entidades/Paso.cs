namespace TareasMVC.Entidades
{
    public class Paso
    {
        public Guid Id { get; set; }
        public int TareaId { get; set; } //Al usar la combinacion de la clase Tarea + Id, usa una convencion de EF para definir la foreign key
        public Tarea Tarea { get; set; } //Permite cargar la data relacionada del paso 
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
        public int Orden { get; set; }
        
    }
}
