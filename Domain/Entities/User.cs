using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Enum;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Column(TypeName = "binary(32)")]
        [Required]
        public byte[] Password { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Lastname { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string DNI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [Column("Role", TypeName = "nvarchar(25)")]
        public string UserType { get; set; }

        // Nueva propiedad para tipo de documento
        public TipoDocumento TipoDNI { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

