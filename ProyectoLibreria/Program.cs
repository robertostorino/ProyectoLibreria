
using LibreriaClases;       // Referencia lógica al proyecto que tiene las clases de negocio
using LibreriaClases.Enums; // Referencia lógica al proyecto que tiene la carpeta del enumerador perfil

namespace ProyectoLibreria
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Creamos varias variables tipo objeto!");
                Console.WriteLine();        // una forma de dejar línea en blanco

                // Puedo tener varios objetos del mismo tipo
                // En un instituto educativo tendré varios alumnos 

                Alumno alum = new Alumno();     // creé un objeto del tipo alumno
                                                // llamamos al constructor default o por omisión

                alum.dni = 34000000;
                alum.nombre = "Juan";
                alum.apellido = "Perez";
                alum.email = "jperez@gmail.com";
                alum.telefono = "45879000";
                alum.fechaNacimiento = Convert.ToDateTime("14/04/1990");

                Console.WriteLine(alum.mostrarDatos());

                Console.WriteLine(Environment.NewLine);     // otra forma de dejar línea en blanco

                Console.WriteLine(alum.mostrarDatos('A'));  // mostrar datos abreviado
                Console.WriteLine(alum.mostrarDatos('D'));  // mostrar datos detallado desde 2da sobrecarga

                Console.WriteLine(Environment.NewLine);

                alum.mostrarDatos("Hola!");    // llamo a la versión procedimiento


                // Crearemos otro objeto alumno pero la forma de cargarle los atributos
                // será a través de un constructor sobrecargado y la creación quedará encapsulada.
                Alumno a = new Alumno("María", "Lopez", 32888999, "mlopez@hotmail.com", "45679900", Convert.ToDateTime("02/11/2001"));

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(a.mostrarDatos());

                //Console.Write("Cargue nota promedio del alumno: ");
                //a.notaPromedio = int.Parse(Console.ReadLine());     // mejorar luego
                a.notaPromedio = 8;
                Console.WriteLine($"La nota promedio de {a.apellidoYnombre} es {a.notaPromedio}");


                // Creo un objeto profesor
                Profesor prof = new Profesor("Mariano", "Rodri", 20888999, "mrodri@hotmail.com",
                                            "43339900", Convert.ToDateTime("22/12/1990"), enumPerfil.Titular);

                Console.WriteLine(prof.mostrarDatos());

                // Otra forma de mostrar los datos del profesor vía método ToString
                Console.WriteLine(prof.ToString());

                Console.ReadKey();
            }
        }
    
}
