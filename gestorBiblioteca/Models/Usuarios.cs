using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gestorBiblioteca.Models
{
    /// <summary>
    ///  Tabla Usuarios, modelo virtual
    /// </summary>
    [Table("gbp_usuarios", Schema = "gbp_operacional")] // Especifica el nombre de la tabla y el esquema
    public class Usuarios
    {
        // ATRIBUTOS

        [Key] // PK
        [Column("id_usuario", TypeName = "bigint")] // Configura el nombre de la columna y su tipo de datos
        public long id_usuario { get; set; }

        [Required] // El valor no puede ser nulo
        [Column("dni_usuario", TypeName = "text")]
        public string dni_usuario { get; set; }

        [Column("nombre_usuario", TypeName = "text")]
        public string nombre_usuario { get; set; }

        [Column("apellidos_usuario", TypeName = "text")]
        public string apellidos_usuario { get; set; }

        [Column("tlf_usuario", TypeName = "text")]
        public string tlf_usuario { get; set; }

        [Column("email_usuario", TypeName = "text")]
        public string email_usuario { get; set; }

        [Column("clave_usuario", TypeName = "text")]
        public string clave_usuario { get; set; }

        [ForeignKey("Acceso")]
        [Column("id_acceso")] // Especifica la clave foránea (FK)
        public long id_acceso { get; set; }

        [Column("estaBloqueado_usuario")]
        public bool estaBloqueado_usuario { get; set; }

        [Column("fch_fin_bloqueo_usuario")]
        public DateTime? fch_fin_bloqueo_usuario { get; set; }

        [Column("fch_alta_usuario")]
        public DateTime? fch_alta_usuario { get; set; }

        [Column("fch_baja_usuario")]
        public DateTime? fch_baja_usuario { get; set; }

        // Relación con Acceso
        public Acceso Acceso { get; set; }

        // CONSTRUCTORES

        public Usuarios()
        {
            // Constructor vacío
        }

        public Usuarios(long idUsuario, string dniUsuario, string nombreUsuario, string apellidosUsuario, string tlfUsuario, string emailUsuario, string claveUsuario, long idAcceso, bool estaBloqueadoUsuario, DateTime? fchFinBloqueoUsuario, DateTime? fchAltaUsuario, DateTime? fchBajaUsuario)
        {
            id_usuario = id_usuario;
            dni_usuario = dni_usuario;
            nombre_usuario = nombre_usuario;
            apellidos_usuario = apellidos_usuario;
            tlf_usuario = tlf_usuario;
            email_usuario = email_usuario;
            clave_usuario = clave_usuario;
            id_acceso = id_acceso;
            estaBloqueado_usuario = estaBloqueado_usuario;
            fch_fin_bloqueo_usuario = fch_fin_bloqueo_usuario;
            fch_alta_usuario = fch_alta_usuario;
            fch_baja_usuario = fch_baja_usuario;
        }
    }
}
