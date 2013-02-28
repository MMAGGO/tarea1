using System;

namespace Application
{
	public class persona
	{
		string nombre;
		string telefono;
		string email;
		string domicilio;
		public static void Main(string[]  args){

			persona persona=new persona();

			Console.WriteLine("Dame tu nombre") ;
			persona.nombre = Console.ReadLine ();
			Console.WriteLine("Dame tu Telefono") ;
			persona.telefono = Console.ReadLine ();
			Console.WriteLine("Dame tu email") ;
			persona.email = Console.ReadLine ();
			Console.WriteLine("Dame tu domicilio") ;
			persona.domicilio = Console.ReadLine ();

			Console.WriteLine(persona.nombre);
			Console.WriteLine(persona.telefono);
			Console.WriteLine(persona.email);
			Console.WriteLine(persona.domicilio);

			Console.ReadLine();
		}


	}

}
