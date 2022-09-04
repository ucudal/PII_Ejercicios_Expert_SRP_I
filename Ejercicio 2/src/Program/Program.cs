using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


           // Se agregaron los nuevos parámetros
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", "30", DateTime.Now, "Wall Street","114477", "Armand", "Otolaryngologist");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", "22", DateTime.Now, "Queen Street","114488", "", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
