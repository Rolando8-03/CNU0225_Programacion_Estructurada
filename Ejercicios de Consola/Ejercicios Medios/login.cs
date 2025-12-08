using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contraseña = Console.ReadLine();

        bool inicioExitoso = VerificarCredenciales(usuario, contraseña); // Función para validar
        MostrarResultado(inicioExitoso);                                 // Función para mostrar resultado
    }

    // Función que verifica si el usuario y contraseña son correctos
    static bool VerificarCredenciales(string usuario, string contraseña)
    {
        // Credenciales predefinidas (puedes cambiarlas)
        string usuarioCorrecto = "admin";
        string contraseñaCorrecta = "1234";

        if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Función que muestra el resultado del inicio de sesión
    static void MostrarResultado(bool exito)
    {
        if (exito)
        {
            Console.WriteLine("¡Inicio de sesión exitoso!");
        }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos.");
        }
    }
}
