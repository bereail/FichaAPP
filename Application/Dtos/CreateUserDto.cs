using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class CreateUserDto
    {

        [Required]
        [EmailAddress]
        [StringLength(75)]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        public byte[] Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "La contraseña y la confirmación no coinciden.")]
        [StringLength(32)]
        public byte[] ConfirmPassword { get; set; } // Nueva propiedad para confirmar la contraseña

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        [StringLength(50)]
        public string DNI { get; set; }

        // Opcional: Fecha de nacimiento
        public DateTime? FechaNacimiento { get; set; }

        // Tipo de usuario predeterminado a Customer
    }
}
