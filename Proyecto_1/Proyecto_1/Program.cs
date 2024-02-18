
// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Curso:Estructura de Datos");
Console.WriteLine("Integrantes:");
Console.WriteLine("Priscilla Gutierrez");
Console.WriteLine("Mailyn Rojas");

// Variables
float MenuPrincipal = 0;
string Menuname = "";
//string Dato = "";
float Submenu_Reportes = 0;
float Submenu_Modificador = 0;
int Indice = 0;
///// variable n importante pasa modificar el numero de entradas del programa
int n = 10;
//Arreglos
int[] Numero_de_Pago = new int[10];
DateOnly[] Fecha = new DateOnly[10];
TimeOnly[] Hora = new TimeOnly[10];
string[] Cedula = new string[10];
string[] Nombre = new string[10];
string[] Primer_Apellido = new string[10];
string[] Segundo_Apellido = new string[10];
int[] Numero_de_Caja = new int[10];
int[] Tipo_de_Servicio = new int[10];
int[] Numero_de_Factura = new int[10];
double[] Monto_a_Pagar = new double[10];
double[] Monto_Comision = new double[10];
double[] Monto_Deducido = new double[10];
double[] Monto_Paga_Cliente = new double[10];
double[] Vuelto = new double[10];

//////////// Menu Principal ////////////

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nSistema Pago de Servicios Publicos ");
    Console.WriteLine("\nTienda la Favorita ");
    Console.WriteLine("\nOpciones disponibles en el menu:  " +
    "\n1. Inicializar Vectores" +
    "\n2. Realizar Pagos" +
    "\n3. Consultar Pagos" +
    "\n4. Modificar Pagos" +
    "\n5. Eliminar Pagos" +
    "\n6. Sub menu Reporte" +
    "\n7. Salir" +
    "\n8. Imprime todos\n");
    Console.WriteLine("\nDigite un numero, para elegir la opcion que desea: ");

    Menuname = Console.ReadLine();
    MenuPrincipal = float.Parse(Menuname);
    Console.Clear();
    switch (MenuPrincipal)
    {
        ///////////////////////////////////////////////////////////////////////////////////opcion 1
        case 1:
            Console.WriteLine("Inicializar Vectores");
            Numero_de_Pago = Enumerable.Repeat(0, 10).ToArray<int>();
            Cedula = Enumerable.Repeat("", 10).ToArray<string>();
            Nombre = Enumerable.Repeat("", 10).ToArray<string>();
            Primer_Apellido = Enumerable.Repeat("", 10).ToArray<string>();
            Segundo_Apellido = Enumerable.Repeat("", 10).ToArray<string>();
            Numero_de_Caja = Enumerable.Repeat(0, 10).ToArray<int>();
            Tipo_de_Servicio = Enumerable.Repeat(0, 10).ToArray<int>();
            Numero_de_Factura = Enumerable.Repeat(0, 10).ToArray<int>();
            Monto_a_Pagar = Enumerable.Repeat(0.0, 10).ToArray<double>();
            Monto_Comision = Enumerable.Repeat(0.0, 10).ToArray<double>();
            Monto_Deducido = Enumerable.Repeat(0.0, 10).ToArray<double>();
            Monto_Paga_Cliente = Enumerable.Repeat(0.0, 10).ToArray<double>();
            Vuelto = Enumerable.Repeat(0.0, 10).ToArray<double>();
            for (int i = 0; i < n; i++)
            {
                Fecha[i] = DateOnly.MinValue;
                Hora[i] = TimeOnly.MinValue;
            }

            Console.WriteLine("Los Vectores se encuentran limpios");
            break;

        ///////////////////////////////////////////////////////////////////////////////opcion 2

        case 2:
            if (Indice >= n)
            {
                Console.WriteLine("Vectores llenos, usar la opcion 1 para inicializarlos");
                break;
            }
            Console.WriteLine("Realizar el pagos");
            Console.WriteLine("Ingrese los datos para realizar el pago");

            Numero_de_Pago[Indice] = Indice + 1;

            Console.WriteLine("Ingrese la fecha, con el siguiente formato DD/MM/AAAA): ");
            Fecha[Indice] = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

            Console.WriteLine("Ingrese la hora formato hh:mm: ");
            Hora[Indice] = TimeOnly.ParseExact(Console.ReadLine(), "HH:mm", null);

            Console.WriteLine("Digite su numero de cedula: ");
            Cedula[Indice] = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre: ");
            Nombre[Indice] = Console.ReadLine();

            Console.WriteLine("Ingrese su primer apellido: ");
            Primer_Apellido[Indice] = Console.ReadLine();

            Console.WriteLine("Ingrese su segundo apellido: ");
            Segundo_Apellido[Indice] = Console.ReadLine();

            Random Aleatorio_Caja = new Random();
            Numero_de_Caja[Indice] = Aleatorio_Caja.Next(1, 3);

            Random Aleatorio_Factura = new Random();
            Numero_de_Factura[Indice] = Aleatorio_Factura.Next(1000, 9999);

            Console.WriteLine("Ingrese Monto a Pagar: ");
            Monto_a_Pagar[Indice] = Convert.ToInt32(Console.ReadLine());


            do
            {
                Console.WriteLine("\nIngrese el tipo de servicio " +
               "\n1. Recibo de Luz" +
               "\n2. Recibo Telefono" +
               "\n3. Recibo Agua\n");
                Tipo_de_Servicio[Indice] = Convert.ToInt32(Console.ReadLine());

                if (Tipo_de_Servicio[Indice] == 1)
                {
                    Monto_Comision[Indice] = Monto_a_Pagar[Indice] * 0.04;
                    break;
                }
                else if (Tipo_de_Servicio[Indice] == 2)
                {
                    Monto_Comision[Indice] = Monto_a_Pagar[Indice] * 0.055;
                    break;
                }
                else if (Tipo_de_Servicio[Indice] == 3)
                {
                    Monto_Comision[Indice] = Monto_a_Pagar[Indice] * 0.065;
                    break;
                }
                else
                {
                    Console.WriteLine("Tipo de servicio no valido ");
                    Console.WriteLine("Vuelva a intentarlo ");
                }

            } while (Tipo_de_Servicio[Indice] != 1 || Tipo_de_Servicio[Indice] != 2 || Tipo_de_Servicio[Indice] != 3);

            Monto_Deducido[Indice] = Monto_a_Pagar[Indice] - Monto_Comision[Indice];


            do
            {
                Console.WriteLine("Ingrese Monto que va a Cancelar el cliente: ");
                Monto_Paga_Cliente[Indice] = Convert.ToInt32(Console.ReadLine());
                if (Monto_Paga_Cliente[Indice] >= Monto_a_Pagar[Indice])
                {
                    Vuelto[Indice] = Monto_Paga_Cliente[Indice] - Monto_a_Pagar[Indice];
                    break;
                }
                else
                {
                    Console.WriteLine("Cantidad es menor a monto a pagar ");
                    Console.WriteLine("Vuelva a intentarlo ");
                }

            } while ((Monto_Paga_Cliente[Indice] < Monto_a_Pagar[Indice]));


            Indice = Indice + 1;

            break;


        /////////////////////////////////////////////////////////////////////////////////opcion 3



        case 3:
            int Buscar;
            Console.WriteLine("Consultar Pagos");
            do
            {
                Console.WriteLine("Ingrese el Numero de Pago a consultar: ");
                Buscar = Convert.ToInt32(Console.ReadLine());

                if (Buscar <= n)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sistema Pago de Servicios Publicos");
                    Console.WriteLine("Tienda la Favorita ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Modulo de datos CONSULTA");
                    Buscar = Buscar - 1;/// or que el arreglo empieza en indice = 0

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("**Informacion de Pago de Cliente**");
                    Console.WriteLine("Dato Encontrado Posicion Vector: " + Buscar);
                    Console.WriteLine("Numero de Pago: " + Numero_de_Pago[Buscar]);
                    Console.WriteLine("Fecha: " + Fecha[Buscar]);
                    Console.WriteLine("Hora: " + Hora[Buscar]);
                    Console.WriteLine("Cedula: " + Cedula[Buscar]);
                    Console.WriteLine("Nombre: " + Nombre[Buscar]);
                    Console.WriteLine("Apellido 1: " + Primer_Apellido[Buscar]);
                    Console.WriteLine("Apellido 2: " + Segundo_Apellido[Buscar]);
                    Console.WriteLine("Numero de Caja: " + Numero_de_Caja[Buscar]);
                    Console.WriteLine("Tipo de servicio: " + Tipo_de_Servicio[Buscar]);
                    Console.WriteLine("Numero de factura: " + Numero_de_Factura[Buscar]);
                    Console.WriteLine("Monto a Pagar: " + Monto_a_Pagar[Buscar]);
                    Console.WriteLine("Monto comicion: " + Monto_Comision[Buscar]);
                    Console.WriteLine("Monto deducido: " + Monto_Deducido[Buscar]);
                    Console.WriteLine("Monto que paga el cliente: " + Monto_Paga_Cliente[Buscar]);
                    Console.WriteLine("Vuelto: " + Vuelto[Buscar]);

                    break;
                }
                else
                {
                    Console.WriteLine("No se encontro ningun Numero de Pago con el # " + Buscar + " en el registro.");

                }

            } while (Buscar > n);

            break;


        /////////////////////////////////////////////////////////////////////////////////opcion 4
        case 4:
            Console.WriteLine("Modificar Pagos");

            int Modificar;
            do
            {
                Console.WriteLine("Ingrese el Numero de Pago a Modificar: ");
                Modificar = Convert.ToInt32(Console.ReadLine());

                if (Modificar <= n)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sistema Pago de Servicios Publicos");
                    Console.WriteLine("Tienda la Favorita ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Modulode Datos PRE MODIFICACION");

                    Modificar = Modificar - 1;/// por que el arreglo empieza en indice = 0
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("**Informacion de Pago de Cliente**");
                    Console.WriteLine("Dato Encontrado Posicion Vector: " + Modificar);
                    Console.WriteLine("Numero de Pago: " + Numero_de_Pago[Modificar]);
                    Console.WriteLine("Fecha: " + Fecha[Modificar]);
                    Console.WriteLine("Hora: " + Hora[Modificar]);
                    Console.WriteLine("Cedula: " + Cedula[Modificar]);
                    Console.WriteLine("Nombre: " + Nombre[Modificar]);
                    Console.WriteLine("Apellido 1: " + Primer_Apellido[Modificar]);
                    Console.WriteLine("Apellido 2: " + Segundo_Apellido[Modificar]);
                    Console.WriteLine("Numero de Caja: " + Numero_de_Caja[Modificar]);
                    Console.WriteLine("Tipo de servicio: " + Tipo_de_Servicio[Modificar]);
                    Console.WriteLine("Numero de factura: " + Numero_de_Factura[Modificar]);
                    Console.WriteLine("Monto a Pagar: " + Monto_a_Pagar[Modificar]);
                    Console.WriteLine("Monto comicion: " + Monto_Comision[Modificar]);
                    Console.WriteLine("Monto deducido: " + Monto_Deducido[Modificar]);
                    Console.WriteLine("Monto que paga el cliente: " + Monto_Paga_Cliente[Modificar]);
                    Console.WriteLine("Vuelto: " + Vuelto[Modificar]);

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nIngrese la Opcion a Modificar:   " +
                        "\n1. Cambio de Fecha" +
                        "\n2. Cambio de Hora" +
                        "\n3. Cambio de Cedula" +
                        "\n4. Cambio de Nombre" +
                        "\n5. Cambio de Primer Apellido" +
                        "\n6. Cambio de Segundo Apellido" +
                        "\n7. Cambio de Numero de Factura" +
                        "\n8. Monto a Pagar" +
                        "\n9. Cambio de Tipo de Servicio" +
                        "\n10. Cambiar Pago con" +
                        "\n0. Salir de menu Modificador\n");

                        Menuname = Console.ReadLine();
                        Submenu_Modificador = float.Parse(Menuname);
                        Console.Clear();
                        switch (Submenu_Modificador)
                        {

                            case 1:
                                Console.WriteLine("Ingrese la NUEVA fecha, con el siguiente formato DD/MM/AAAA): ");
                                Fecha[Modificar] = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

                                break;
                            case 2:
                                Console.WriteLine("Ingrese la NUEVA hora formato hh:mm: ");
                                Hora[Modificar] = TimeOnly.ParseExact(Console.ReadLine(), "HH:mm", null);

                                break;
                            case 3:
                                Console.WriteLine("Digite el NUEVO numero de cedula: ");
                                Cedula[Modificar] = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Ingrese el NUEVO nombre: ");
                                Nombre[Modificar] = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Ingrese el NUEVO primer apellido: ");
                                Primer_Apellido[Modificar] = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Ingrese el NUEVO segundo apellido: ");
                                Segundo_Apellido[Modificar] = Console.ReadLine();
                                break;
                            case 7:
                                Random Aleatorio_Factura_Cambio = new Random();
                                Numero_de_Factura[Modificar] = Aleatorio_Factura_Cambio.Next(1000, 9999);
                                Console.WriteLine("Se Asigno un Nuevo Numero de Factura");
                                break;
                            case 8:
                                Console.WriteLine("Ingrese el NUEVO Monto a Pagar: ");
                                Monto_a_Pagar[Modificar] = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 9:
                                do
                                {
                                    Console.WriteLine("\nIngrese el NUEVO tipo de servicio " +
                                   "\n1. Recibo de Luz" +
                                   "\n2. Recibo Telefono" +
                                   "\n3. Recibo Agua\n");
                                    Tipo_de_Servicio[Modificar] = Convert.ToInt32(Console.ReadLine());

                                    if (Tipo_de_Servicio[Modificar] == 1)
                                    {
                                        Monto_Comision[Modificar] = Monto_a_Pagar[Modificar] * 0.04;
                                        break;
                                    }
                                    else if (Tipo_de_Servicio[Modificar] == 2)
                                    {
                                        Monto_Comision[Modificar] = Monto_a_Pagar[Modificar] * 0.055;
                                        break;
                                    }
                                    else if (Tipo_de_Servicio[Modificar] == 3)
                                    {
                                        Monto_Comision[Modificar] = Monto_a_Pagar[Modificar] * 0.065;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Tipo de sercicio no valido ");
                                        Console.WriteLine("Vuelva a intentarlo ");
                                    }

                                } while (Tipo_de_Servicio[Modificar] != 1 || Tipo_de_Servicio[Modificar] != 2 || Tipo_de_Servicio[Modificar] != 3);

                                Monto_Deducido[Modificar] = Monto_a_Pagar[Modificar] - Monto_Comision[Modificar];
                                break;
                            case 10:
                                do
                                {
                                    Console.WriteLine("Ingrese Monto que va a Cancelar el cliente: ");
                                    Monto_Paga_Cliente[Modificar] = Convert.ToInt32(Console.ReadLine());
                                    if (Monto_Paga_Cliente[Modificar] >= Monto_a_Pagar[Modificar])
                                    {
                                        Vuelto[Modificar] = Monto_Paga_Cliente[Modificar] - Monto_a_Pagar[Modificar];
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Cantidad es menor a monto a pagar ");
                                        Console.WriteLine("Vuelva a intentarlo ");
                                    }

                                } while ((Monto_Paga_Cliente[Modificar] < Monto_a_Pagar[Modificar]));
                                break;
                            case 0:
                                Console.WriteLine("Escogio salir. Presione una tecla para salir del programa");

                                break;


                        }


                    } while (Submenu_Modificador != 0);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sistema Pago de Servicios Publicos");
                    Console.WriteLine("Tienda la Favorita ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Modulo de Datos POS MODIFICACION");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("**Informacion de Pago de Cliente**");
                    Console.WriteLine("Dato Encontrado Posicion Vector: " + Modificar);
                    Console.WriteLine("Numero de Pago: " + Numero_de_Pago[Modificar]);
                    Console.WriteLine("Fecha: " + Fecha[Modificar]);
                    Console.WriteLine("Hora: " + Hora[Modificar]);
                    Console.WriteLine("Cedula: " + Cedula[Modificar]);
                    Console.WriteLine("Nombre: " + Nombre[Modificar]);
                    Console.WriteLine("Apellido 1: " + Primer_Apellido[Modificar]);
                    Console.WriteLine("Apellido 2: " + Segundo_Apellido[Modificar]);
                    Console.WriteLine("Numero de Caja: " + Numero_de_Caja[Modificar]);
                    Console.WriteLine("Tipo de servicio: " + Tipo_de_Servicio[Modificar]);
                    Console.WriteLine("Numero de factura: " + Numero_de_Factura[Modificar]);
                    Console.WriteLine("Monto a Pagar: " + Monto_a_Pagar[Modificar]);
                    Console.WriteLine("Monto comicion: " + Monto_Comision[Modificar]);
                    Console.WriteLine("Monto deducido: " + Monto_Deducido[Modificar]);
                    Console.WriteLine("Monto que paga el cliente: " + Monto_Paga_Cliente[Modificar]);
                    Console.WriteLine("Vuelto: " + Vuelto[Modificar]);

                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("El pago con el numero  # " + Modificar + " no se encuentra registrado.");

                }

            } while (Modificar > n);



            break;




            break;


        /////////////////////////////////////////////////////////////////////////////////opcion 5
        case 5:
            Console.WriteLine("Eliminar Pagos");

            int Eliminar;
            do
            {
                Console.WriteLine("Ingrese el Numero de Pago a Eliminar: ");
                Eliminar = Convert.ToInt32(Console.ReadLine());

                if (Eliminar <= n)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sistema Pago de Servicios Publicos");
                    Console.WriteLine("Tienda la Favorita ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Modulode Datos PRE ELIMINAR");

                    Eliminar = Eliminar - 1;/// or que el arreglo empieza en indice = 0
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("**Informacion de Pago de Cliente**");
                    Console.WriteLine("Dato Encontrado Posicion Vector: " + Eliminar);
                    Console.WriteLine("Numero de Pago: " + Numero_de_Pago[Eliminar]);
                    Console.WriteLine("Fecha: " + Fecha[Eliminar]);
                    Console.WriteLine("Hora: " + Hora[Eliminar]);
                    Console.WriteLine("Cedula: " + Cedula[Eliminar]);
                    Console.WriteLine("Nombre: " + Nombre[Eliminar]);
                    Console.WriteLine("Apellido 1: " + Primer_Apellido[Eliminar]);
                    Console.WriteLine("Apellido 2: " + Segundo_Apellido[Eliminar]);
                    Console.WriteLine("Numero de Caja: " + Numero_de_Caja[Eliminar]);
                    Console.WriteLine("Tipo de servicio: " + Tipo_de_Servicio[Eliminar]);
                    Console.WriteLine("Numero de factura: " + Numero_de_Factura[Eliminar]);
                    Console.WriteLine("Monto a Pagar: " + Monto_a_Pagar[Eliminar]);
                    Console.WriteLine("Monto comicion: " + Monto_Comision[Eliminar]);
                    Console.WriteLine("Monto deducido: " + Monto_Deducido[Eliminar]);
                    Console.WriteLine("Monto que paga el cliente: " + Monto_Paga_Cliente[Eliminar]);
                    Console.WriteLine("Vuelto: " + Vuelto[Eliminar]);

                    int Respuesta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Esta seguro de elimar el dato NUMERO DE PAGO ? ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" SI = 1/ NO = 0 ? : ");
                    Respuesta = Convert.ToInt32(Console.ReadLine());
                    if (Respuesta == 1)
                    {
                        Numero_de_Pago[Eliminar] = 0;
                        Cedula[Eliminar] = "";
                        Nombre[Eliminar] = ""; ;
                        Primer_Apellido[Eliminar] = "";
                        Segundo_Apellido[Eliminar] = "";
                        Numero_de_Caja[Eliminar] = 0;
                        Tipo_de_Servicio[Eliminar] = 0;
                        Numero_de_Factura[Eliminar] = 0;
                        Monto_a_Pagar[Eliminar] = 0.0;
                        Monto_Comision[Eliminar] = 0.0;
                        Monto_Deducido[Eliminar] = 0.0;
                        Monto_Paga_Cliente[Eliminar] = 0.0;
                        Vuelto[Eliminar] = 0.0;
                        Fecha[Respuesta] = DateOnly.MinValue;
                        Hora[Respuesta] = TimeOnly.MinValue;

                        Console.WriteLine("La informacion fue eliminada con exito");
                        break;
                    }
                    else if (Respuesta == 0)
                    {
                        Console.WriteLine("La informacion NO fue eliminada con exito");
                        break;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("El pago con el numero  # " + Eliminar + " no se encuentra registrado.");

                }

            } while (Eliminar > n);

            break;

            break;



        ////////////////////////////////////////////////////////////////////////////////// Opcion 6 y Submenu

        case 6:

            Console.WriteLine("Submenu Reportes");
            do
            {

                Console.WriteLine("Digite el numero de la opcion que quiere elegir: " +
                 "\n1. Ver todos los pagos" +
                 "\n2. Ver pagos por tipo de servicios" +
                 "\n3. Ver pagos por codigo de caja" +
                 "\n4. Ver dinero comisionado" +
                 "\n5. Regresar al menu principal\n");
                Menuname = Console.ReadLine();
                Submenu_Reportes = float.Parse(Menuname);

                Console.Clear();

                switch (Submenu_Reportes)
                {
                    /// opcion 6.1
                    case 1:
                        Console.WriteLine("Ver todos los pagos");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Sistema Pago de Servicios Publicos");
                        Console.WriteLine("Tienda la Favorita ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Reporte de Todos los pagos");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("-------------------------------------------------------------------");
                        int reg_total = 0;
                        double mon_total = 0;
                        //int[,] Todos_Pagos = new[n,8]; 
                        for (int i = 0; i < n; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i]);
                            reg_total = reg_total + 1;
                            mon_total = mon_total + Monto_a_Pagar[i];
                        }
                        Console.WriteLine("Total de Registros : " + reg_total);
                        Console.WriteLine("Monto total : " + mon_total);
                        Console.WriteLine("*************");
                        break;

                    /// opcion 6.2
                    case 2:
                        Console.WriteLine("Ver pagos por tipo de servicio");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Sistema Pago de Servicios Publicos");
                        Console.WriteLine("Tienda la Favorita ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Reporte de Todos los pagos por servicios");

                        int reporte_servicio;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Seleccione codigo de servcio" +
                            "\n [1] Electricidad " +
                            "\n [2] Telefono " +
                            "\n [3] Agua ");
                            reporte_servicio = Convert.ToInt32(Console.ReadLine());
                            if (Tipo_de_Servicio[reporte_servicio - 1] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sistema Pago de Servicios Publicos");
                                Console.WriteLine("Tienda la Favorita ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" Reporte de Todos los pagos por servicios de Electicidad");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("-------------------------------------------------------------------");
                                int reg_total_elec = 0;
                                double mon_total_elec = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    if (Tipo_de_Servicio[i] == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i]);
                                        reg_total_elec = reg_total_elec + 1;
                                        mon_total_elec = mon_total_elec + Monto_a_Pagar[i];

                                    }

                                }
                                Console.WriteLine("Total de Registros : " + reg_total_elec);
                                Console.WriteLine("Monto total : " + mon_total_elec);
                                Console.WriteLine("*************");
                                break;
                            }
                            else if (Tipo_de_Servicio[reporte_servicio - 1] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sistema Pago de Servicios Publicos");
                                Console.WriteLine("Tienda la Favorita ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" Reporte de Todos los pagos por servicios de Telefono");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("-------------------------------------------------------------------");
                                int reg_total_telef = 0;
                                double mon_total_telef = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    if (Tipo_de_Servicio[i] == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i]);
                                        reg_total_telef = reg_total_telef + 1;
                                        mon_total_telef = mon_total_telef + Monto_a_Pagar[i];

                                    }

                                }
                                Console.WriteLine("Total de Registros : " + reg_total_telef);
                                Console.WriteLine("Monto total : " + mon_total_telef);
                                Console.WriteLine("*************");

                                break;
                            }
                            else if (Tipo_de_Servicio[reporte_servicio - 1] == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sistema Pago de Servicios Publicos");
                                Console.WriteLine("Tienda la Favorita ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" Reporte de Todos los pagos por servicios de Agua");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("-------------------------------------------------------------------");
                                int reg_total_agua = 0;
                                double mon_total_agua = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    if (Tipo_de_Servicio[i] == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i]);
                                        reg_total_agua = reg_total_agua + 1;
                                        mon_total_agua = mon_total_agua + Monto_a_Pagar[i];

                                    }

                                }
                                Console.WriteLine("Total de Registros : " + reg_total_agua);
                                Console.WriteLine("Monto total : " + mon_total_agua);
                                Console.WriteLine("*************");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tipo de servicio no valido ");
                                Console.WriteLine("Vuelva a intentarlo ");
                            }



                        } while (Tipo_de_Servicio[reporte_servicio] != 1 || Tipo_de_Servicio[reporte_servicio] != 2 || Tipo_de_Servicio[reporte_servicio] != 3);
                        break;


                        break;

                    /// opcion 6.3
                    case 3:
                        Console.WriteLine("Ver pagos por codigo de caja");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Sistema Pago de Servicios Publicos");
                        Console.WriteLine("Tienda la Favorita ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Reporte de Todos los pagos por # de caja");

                        int reporte_cajas;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" Seleccione el numero de caja" +
                            "\n [1] Caja #1 " +
                            "\n [2] Caja #2 " +
                            "\n [3] Caja #3 ");
                            reporte_cajas = Convert.ToInt32(Console.ReadLine());
                            if (Numero_de_Caja[reporte_cajas - 1] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sistema Pago de Servicios Publicos");
                                Console.WriteLine("Tienda la Favorita ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" Reporte de Todos los pagos por servicios de Caja #1");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("-------------------------------------------------------------------");
                                int reg_total_caja1 = 0;
                                double mon_total_caja1 = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    if (Numero_de_Caja[i] == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i] + " " + Numero_de_Caja[i]);
                                        reg_total_caja1 = reg_total_caja1 + 1;
                                        mon_total_caja1 = mon_total_caja1 + Monto_a_Pagar[i];

                                    }

                                }
                                Console.WriteLine("Total de Registros : " + reg_total_caja1);
                                Console.WriteLine("Monto total : " + mon_total_caja1);
                                Console.WriteLine("*************");
                                break;
                            }
                            else if (Numero_de_Caja[reporte_cajas - 1] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sistema Pago de Servicios Publicos");
                                Console.WriteLine("Tienda la Favorita ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" Reporte de Todos los pagos por servicios de Caja #2");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("-------------------------------------------------------------------");
                                int reg_total_caja2 = 0;
                                double mon_total_caja2 = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    if (Numero_de_Caja[i] == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i] + " " + Numero_de_Caja[i]);
                                        reg_total_caja2 = reg_total_caja2 + 1;
                                        mon_total_caja2 = mon_total_caja2 + Monto_a_Pagar[i];

                                    }

                                }
                                Console.WriteLine("Total de Registros : " + reg_total_caja2);
                                Console.WriteLine("Monto total : " + mon_total_caja2);
                                Console.WriteLine("*************");

                                break;
                            }
                            else if (Numero_de_Caja[reporte_cajas - 1] == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Sistema Pago de Servicios Publicos");
                                Console.WriteLine("Tienda la Favorita ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" Reporte de Todos los pagos por servicios de Caja #3");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("# Pago" + " " + "Fecha" + " " + "Hora" + " " + "Pago" + " " + "Cedula" + " " + "Nombre" + " " + "Apellido 1" + " " + "Apellido 2" + " " + "Monto");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("-------------------------------------------------------------------");
                                int reg_total_caja3 = 0;
                                double mon_total_caja3 = 0;
                                for (int i = 0; i < n; i++)
                                {
                                    if (Numero_de_Caja[i] == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine(+Numero_de_Pago[i] + " " + Fecha[i] + " " + Hora[i] + " " + Cedula[i] + " " + Nombre[i] + " " + Primer_Apellido[i] + " " + Segundo_Apellido[i] + " " + Monto_a_Pagar[i] + " " + Numero_de_Caja[i]);
                                        reg_total_caja3 = reg_total_caja3 + 1;
                                        mon_total_caja3 = mon_total_caja3 + Monto_a_Pagar[i];

                                    }

                                }
                                Console.WriteLine("Total de Registros : " + reg_total_caja3);
                                Console.WriteLine("Monto total : " + mon_total_caja3);
                                Console.WriteLine("*************");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tipo de servicio no valido ");
                                Console.WriteLine("Vuelva a intentarlo ");
                            }



                        } while (Numero_de_Caja[reporte_cajas] != 1 || Numero_de_Caja[reporte_cajas] != 2 || Numero_de_Caja[reporte_cajas] != 3);
                        break;
                        break;


                    /// opcion 6.4
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Ver dinero comisionado por servicios ");
                        Console.WriteLine("Reporte Dinero Comisionado ");
                        Console.WriteLine("Desglose por tipo de servicio ");
                        Console.WriteLine("Ver dinero comisionado por servicios ");
                        Console.WriteLine("# Item" + " " + "Cantidad Transacciones" + " " + "Total Comisionado");
                        int reg_total_Comision_elect = 0;
                        double mon_total_Comision_elect = 0;
                        int reg_total_Comision_telef = 0;
                        double mon_total_Comision_telef = 0;
                        int reg_total_Comision_agua = 0;
                        double mon_total_Comision_agua = 0;
                        for (int i = 0; i < n; i++)
                        {
                            if (Tipo_de_Servicio[i] == 1)
                            {

                                reg_total_Comision_elect = reg_total_Comision_elect + 1;
                                mon_total_Comision_elect = mon_total_Comision_elect + Monto_Comision[i];
                            }
                            else if (Tipo_de_Servicio[i] == 2)
                            {

                                reg_total_Comision_telef = reg_total_Comision_telef + 1;
                                mon_total_Comision_telef = mon_total_Comision_telef + Monto_Comision[i];
                            }
                            else if (Tipo_de_Servicio[i] == 3)
                            {

                                reg_total_Comision_agua = reg_total_Comision_agua + 1;
                                mon_total_Comision_agua = mon_total_Comision_agua + Monto_Comision[i];
                            }

                        }
                        int total_transacciones;
                        double total_comision;
                        total_transacciones = reg_total_Comision_elect + reg_total_Comision_telef + reg_total_Comision_agua;
                        total_comision = mon_total_Comision_elect + mon_total_Comision_telef + mon_total_Comision_agua;
                        Console.WriteLine("[1. Electricidad] : " + reg_total_Comision_elect + " " + mon_total_Comision_elect);
                        Console.WriteLine("[2. Telefono] : " + reg_total_Comision_telef + " " + mon_total_Comision_telef);
                        Console.WriteLine("[3. Agua] : " + reg_total_Comision_agua + " " + mon_total_Comision_agua);
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("Total : " + total_transacciones + " " + total_comision);

                        Console.WriteLine("*************");
                        break;


                        break;



                    /// opcion 6.5
                    case 5:
                        Console.WriteLine("Regresar al menu principal");
                        break;

                }




            } while (Submenu_Reportes != 5);

            break;


        ///////////////////////////////////////////////////////////////////////////opcion 7 salir 
        case 7:
            Console.WriteLine("Escogio salir. Presione una tecla para salir del programa");
            Console.ReadKey();
            Environment.Exit(0);
            break;
        case 8:

            ////// Imptiit todo

            for (int imprime = 0; imprime < n; imprime++)
            {
                Console.WriteLine("******CLIENTE NUMERO****: " + imprime);
                Console.WriteLine("Numero de Pago: " + Numero_de_Pago[imprime]);
                Console.WriteLine("Fecha: " + Fecha[imprime]);
                Console.WriteLine("Hora: " + Hora[imprime]);
                Console.WriteLine("Cedula: " + Cedula[imprime]);
                Console.WriteLine("Nombre: " + Nombre[imprime]);
                Console.WriteLine("Apellido 1: " + Primer_Apellido[imprime]);
                Console.WriteLine("Apellido 2: " + Segundo_Apellido[imprime]);
                Console.WriteLine("Numero de Caja: " + Numero_de_Caja[imprime]);
                Console.WriteLine("Tipo de servicio: " + Tipo_de_Servicio[imprime]);
                Console.WriteLine("Numero de factura: " + Numero_de_Factura[imprime]);
                Console.WriteLine("Monto a Pagar: " + Monto_a_Pagar[imprime]);
                Console.WriteLine("Monto comicion: " + Monto_Comision[imprime]);
                Console.WriteLine("Monto deducido: " + Monto_Deducido[imprime]);
                Console.WriteLine("Monto que paga el cliente: " + Monto_Paga_Cliente[imprime]);
                Console.WriteLine("Vuelto: " + Vuelto[imprime]);
            }


            break;






    }
} while (true);