using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ValidadorDeContraseñas.Core
{
    public class ValidadorDeContraseñas 
    {
        public (bool EsValida, string Mensaje) ValidarContraseña(string contraseña)
        {
            // Validar si está vacía o contiene solo espacios
            if (string.IsNullOrWhiteSpace(contraseña) || contraseña.Contains(" "))
            {
                return (false, "La contraseña no puede estar vacía.");
            }

            // Validar longitud mínima
            if (contraseña.Length < 8)
            {
                return (false, "La contraseña debe tener al menos 8 caracteres.");
            }

            // Validar longitud máxima
            if (contraseña.Length > 20)
            {
                return (false, "La contraseña supera el límite máximo de 20 caracteres.");
            }

            // Validar letra mayúscula
            if (!Regex.IsMatch(contraseña, @"[A-Z]"))
            {
                return (false, "La contraseña debe contener al menos una letra mayúscula.");
            }

            // Validar letra minúscula
            if (!Regex.IsMatch(contraseña, @"[a-z]"))
            {
                return (false, "La contraseña debe contener al menos una letra minúscula.");
            }

            // Validar que contenga al menos un número
            if (!Regex.IsMatch(contraseña, @"[0-9]"))
            {
                return (false, "La contraseña debe contener al menos un número.");
            }

            // Validar que contenga al menos un carácter especial
            if (!Regex.IsMatch(contraseña, @"[!@#$%^&*(),.?""{}|<>]"))
            {
                return (false, "La contraseña debe contener al menos un carácter especial.");
            }

            // Validar que no contenga caracteres no permitidos (como emojis)
            if (contraseña.Any(c => !Regex.IsMatch(c.ToString(), @"^[A-Za-z0-9!@#$%^&*(),.?""{}|<>]$")))
            {
                return (false, "La contraseña contiene caracteres inválidos.");
            }

            // Si pasa todas las validaciones
            return (true, "La contraseña es válida.");
        }
    }
}
