using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] curso = new string[3];
            curso[0] = "Calculo 2";
            curso[1] = "Fisica";
            curso[2] = "Matematica Basica";
            string[] tutor = new string[3];
            string Aceptar;
            tutor[0] = "Julio Profe";
            tutor[1] = "Monica Flores";
            tutor[2] = "Alexander Mar";
            ConsoleKeyInfo op;
            ConsoleKeyInfo op1;
            string user;
            string cont;
            string hora;
            string fecha;
           

            do{
                Console.Clear(); //Limpiar la pantalla
                Console.WriteLine("Inicio de Sesión");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Usuario: \n");
                Console.ForegroundColor = ConsoleColor.White;
                user = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Contraseña: \n");
                Console.ForegroundColor = ConsoleColor.White;
                cont = Console.ReadLine();
                Console.Write("[Iniciar sesion](I)\n");
                Console.Write("[Esc]Salir");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);//Que no muestre la tecla señalada

                //métodos son acciones, las propiedades son valores
                switch (op.Key)
                {
                    case ConsoleKey.I:
                        Console.Clear();
                        Console.WriteLine("\t\t\tGAPPSTONE\n");
                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir\n");
                        Console.Write("Selecciona el curso, tutor y\nhorario de tu preferencia y \ncomunicate con los tutores \nReserva tu tutoria ahora\n ");
                        Console.Write("[RESERVAR] [R]");
                            op1 = Console.ReadKey(true);
                        switch (op1.Key)
                        {
                            case ConsoleKey.R:
                                Console.Clear();
                                Console.WriteLine("\t\t\tGAPPSTONE");
                                Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                Console.WriteLine("Cursos:");
                                Console.WriteLine("[0] "+ curso[0]);
                                Console.WriteLine("[1] "+ curso[1]);
                                Console.WriteLine("[2] "+ curso[2]);
                                int i;
                                Console.WriteLine("Seleccione un curso [0-2]");
                                i = Convert.ToInt32(Console.ReadLine());

                                if (i == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\t\t\tGAPPSTONE");
                                    Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                    Console.WriteLine("Curso seleccionado: ", curso[i]);
                                    Console.WriteLine("Tutores disponibles:");
                                    Console.WriteLine("[0] "+ tutor[0]);
                                    Console.WriteLine("[1] "+ tutor[1]);
                                    Console.WriteLine("[2] "+ tutor[2]);
                                    int j;
                                    Console.WriteLine("Selecione tutor [0-2]");
                                    j = Convert.ToInt32(Console.ReadLine());
                                  
                                    if (j == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: "+ curso[i]);
                                        Console.WriteLine("Tutor seleccionado: "+ tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                            
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: "+ curso[i]);
                                            Console.WriteLine("Tutor seleccionado: "+ tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");
                                           
                                        }
                                    }
                                    else if (j == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                            
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                    if (j == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                          
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                }
                                if (i == 1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\t\t\tGAPPSTONE");
                                    Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                    Console.WriteLine("Curso seleccionado: ", curso[i]);
                                    Console.WriteLine("Tutores disponibles:");
                                    Console.WriteLine("[0] " + tutor[0]);
                                    Console.WriteLine("[1] " + tutor[1]);
                                    Console.WriteLine("[2] " + tutor[2]);
                                    int j;
                                    Console.WriteLine("Selecione tutor [0-2]");
                                    j = Convert.ToInt32(Console.ReadLine());

                                    if (j == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                            
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                    else if (j == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                          
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                    if (j == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                           
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                }
                                if (i == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\t\t\tGAPPSTONE");
                                    Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                    Console.WriteLine("Curso seleccionado: ", curso[i]);
                                    Console.WriteLine("Tutores disponibles:");
                                    Console.WriteLine("[0] " + tutor[0]);
                                    Console.WriteLine("[1] " + tutor[1]);
                                    Console.WriteLine("[2] " + tutor[2]);
                                    int j;
                                    Console.WriteLine("Selecione tutor [0-2]");
                                    j = Convert.ToInt32(Console.ReadLine());

                                    if (j == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                            
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                    else if (j == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                           
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                    if (j == 2)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t\t\tGAPPSTONE");
                                        Console.WriteLine("Inicio\t\t\t\t\t[Esc]Salir");
                                        Console.WriteLine("Curso seleccionado: " + curso[i]);
                                        Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                        Console.WriteLine("Escriba fecha dd/mm/aaa :");
                                        fecha = Console.ReadLine();
                                        Console.WriteLine("Escriba hora [12 - 20] :");
                                        hora = Console.ReadLine();
                                        Console.WriteLine("[A] Aceptar");
                                        Aceptar = Console.ReadLine();

                                        if (Aceptar == "a")
                                        {
                                           
                                            Console.Clear();
                                            Console.WriteLine("\t\t\tGAPPSTONE");
                                            Console.WriteLine("Verificación de Reseva");
                                            Console.WriteLine("Curso seleccionado: " + curso[i]);
                                            Console.WriteLine("Tutor seleccionado: " + tutor[j]);
                                            Console.WriteLine("Fecha: " + fecha);
                                            Console.WriteLine("Hora: " + hora);

                                            Console.WriteLine("Para salir presiones [Esc]");

                                        }
                                    }
                                }


                                break;


                        }
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Chao");

                        break;
                }
            } while (op.Key != ConsoleKey.Escape);
        }
    }
}
