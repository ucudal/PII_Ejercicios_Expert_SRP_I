using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /* Este código no está mal, solo está incompleto, ya que lo único que veo es como un sistema para que no queden lugares en blanco.
         Crearé unas clases más para el doctor, el paciente y también uno separado para el appointment. */
        public static string CreateAppointment(string name, string id, string phoneNumber, string age, DateTime date, string appoinmentPlace, string appointmentIdentifier, string doctorName, string doctorSpeciality)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(age)) //Nuevo
            {
                stringBuilder.Append("Unable to schedule appointment, 'age' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentIdentifier)) //Nuevo
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment identifier' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorSpeciality)) //Nuevo
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor speciality' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }



    }
 //Aquí voy a agregar las otras clases, lo demás queda igual.

    public class Paciente{
        public string name { get ; set ; }
        public string id { get ; set ; }
        public string phoneNumber { get ; set ; }
        public string age { get ; set ; }

        public Paciente (string name, string id, string phoneNumber, string age){
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.age = age;
        }
            
        }
    
    public class Doctor{
        public string doctorName { get ; set ; }
        public string doctorSpeciality{ get ; set ; }

        public Doctor(string doctorName, string doctorSpeciality){
            this.doctorName = doctorName;
            this.doctorSpeciality = doctorSpeciality;
        }
        


    }

    public class Appointment{

        public DateTime date;
        public string appoinmentPlace;
        public string appointmentIdentifier;

        public Appointment(DateTime date, string appoinmentPlace, string appointmentIdentifier){

            this.date = date;
            this.appoinmentPlace = appoinmentPlace;
            this.appointmentIdentifier = appointmentIdentifier;
        }
    }

}
