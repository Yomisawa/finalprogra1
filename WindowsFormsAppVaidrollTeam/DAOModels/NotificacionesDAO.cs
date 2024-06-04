using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppVaidrollTeam.Models;

namespace WindowsFormsAppVaidrollTeam.DAOModels
{
    public class NotificacionesDAO
    {
        public List<Notificaciones> notificaciones;
        public string stringConnection = "server=Yeferson-Lemus\\SERVERPGR;integrated security=true;database=DBTeam1";


        public List<Notificaciones> ObtenerNotificaciones()
        {
            notificaciones = new List<Notificaciones> { };
            MessageBox.Show("Cargando notificaciones...");
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {

                    conn.Open();

                    string consulta = "SELECT * FROM notificaciones";

                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Notificaciones notificacion = new Notificaciones { 
                            
                               id = reader.GetInt32( reader.GetOrdinal("id")),
                               nombre = reader.GetString(reader.GetOrdinal("nombre")),
                               descripcion = reader.GetString(reader.GetOrdinal("descripcion"))


                            };
                            notificaciones.Add(notificacion);


                        }

                        return notificaciones ;

                    }
                }

            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
        } 
    }
}
