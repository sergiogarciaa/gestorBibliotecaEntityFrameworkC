using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace gestorBiblioteca.Models
{

    /// <summary>
    ///  Tabla Acceso, modelo virtual
    /// </summary>
    [Table("gbp_acceso", Schema = "gbp_operacional")]
    public class Acceso
    {
        // ATRIBUTOS

        [Key] // PK
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autoincrementar
        [Column("id_acceso", TypeName = "bigint")] // Configura el nombre de la columna y su tipo de datos
        public long id_acceso { get; set; }

        [Required] // El valor no puede ser nulo
        [Column("codigo_acceso", TypeName = "text")]
        public string codigo_acceso { get; set; }

        [Column("descripcion_acceso", TypeName = "text")]
        public string descripcion_acceso { get; set; }

        [InverseProperty("Acceso")] // Configura la relación inversa con Usuarios
        public List<Usuarios> UsuariosConAcceso { get; set; }

        // CONSTRUCTORES

        public Acceso()
        {
            // Constructor vacío
        }

        public Acceso(string codigo_acceso, string descripcion_acceso)
        {
            this.codigo_acceso = codigo_acceso;
            this.descripcion_acceso = descripcion_acceso;
        }
    }
}
