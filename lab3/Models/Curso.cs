namespace lab3.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Sigla { get; set; }
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public int CantidadEstudiantes { get; set; }

        // FK y relación con Aula
        public int AulaId { get; set; }
        public Aula? Aula { get; set; }
    }
}
