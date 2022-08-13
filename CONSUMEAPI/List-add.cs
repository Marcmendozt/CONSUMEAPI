using CONSUMEAPI;

using System.Text.Json;

var url = "https://dummy.restapiexample.com/api/v1/employees";
var urlAPI = "http://localhost:36072/api/employee";


//LISTADO//
JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
using (var httpClient = new HttpClient())
{
    var response = await httpClient.GetAsync(url);

    if (response.IsSuccessStatusCode)
    {
        var Contenido = await response.Content.ReadAsStringAsync();

         var Empleados = JsonSerializer.Deserialize<Response>(Contenido, jsonSerializerOptions);
        foreach (var TB in Empleados.Data)
        {
           Console.WriteLine($"{TB.id} {TB.employee_name}{TB.employee_salary}{TB.employee_age}{TB.profile_image}");
       }

        
    } else
        Console.WriteLine("ERROR");
}


Console.WriteLine("-------------AGREGAR NUEVO EMPLEADO-------------");

//-----------ID---------------//
int id = 0;
Console.WriteLine("Ingrese el ID : ");
id = Convert.ToInt32(Console.ReadLine());
//-----------Nombre---------------//
string name = "";
Console.WriteLine("Ingrese el nombre del empleado : ");
name = Console.ReadLine();
//-----------Numero de documento---------------//
string document_number = "";
Console.WriteLine("Ingrese el N° de documento : ");
document_number = Console.ReadLine();
//-----------Salario---------------//
decimal salary = 0;
Console.WriteLine("Ingrese el salario: ");
salary = Convert.ToDecimal(Console.ReadLine());
//-----------Edad---------------//
int age = 0;
Console.WriteLine("Ingrese la edad: ");
age = Convert.ToInt32(Console.ReadLine());
//-----------Perfil---------------//
string profile = "";
Console.WriteLine("Ingrese el Perfil : ");
profile = Console.ReadLine();
//-----------Correo---------------//
string email = "";
Console.WriteLine("Ingrese el correo : ");
email = Console.ReadLine();
//-----------Dirección---------------//
string address = "";
Console.WriteLine("Ingrese la dirección : ");
address = Console.ReadLine();



using (var httpClient = new HttpClient())
{
        var response = await httpClient.PostAsJsonAsync(urlAPI, new employee
        {
            id = id,
            name = name,
            document_number = document_number,
            salary = salary,
            age = age,
            profile = profile,
            email = email,
            address = address
        });

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Se agrego un nuevo empleado");
        } else
        {
        Console.WriteLine("Ocurrió un error, vuela a intentarlo");
    }
        
    Console.ReadKey();
}





