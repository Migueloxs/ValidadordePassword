using Xunit;
using ValidadorDeContraseñas.Core;

namespace ValidadorDeContraseñas.Core;

public class ValidadorDeContraseñasTests
{
    // Método que provee datos dinámicos de prueba
    public static IEnumerable<object[]> ObtenerDatosDePrueba()
    {
        return new List<object[]>
        {
            new object[] { "Valida@123", true, "La contraseña es válida." }, // Contraseña válida
            new object[] { "corta", false, "La contraseña debe tener al menos 8 caracteres." }, // Muy corta
            new object[] { "SinNumero@", false, "La contraseña debe contener al menos un número." }, // Sin número
            new object[] { "SinEspecial123", false, "La contraseña debe contener al menos un carácter especial." }, // Sin carácter especial
            new object[] { "SoloEspacios   ", false, "La contraseña no puede estar vacía." }, // Contraseña con espacios
            new object[] { "12345678", false, "La contraseña debe contener al menos una letra mayúscula." }, // Solo números
            new object[] { "TodoMinusculas123@", true, "La contraseña es válida." }, // Contraseña válida con mayúsculas
            new object[] { "Emoji😊123@", false, "La contraseña contiene caracteres inválidos." }, // No emojis
            new object[] { new string('a', 21), false, "La contraseña supera el límite máximo de 20 caracteres." } // Contraseña muy larga (más de 16)
        };
    }

    [Theory]
    [MemberData(nameof(ObtenerDatosDePrueba))]
    public void ValidarContraseña_ValidaCorrectamente(string contraseña, bool esperadoValido, string esperadoMensaje)
    {
        // Arrange
        var validador = new ValidadorDeContraseñas();

        // Act
        var (esValida, mensaje) = validador.ValidarContraseña(contraseña);

        // Assert
        Assert.Equal(esperadoValido, esValida);
        Assert.Equal(esperadoMensaje, mensaje);
    }
}


