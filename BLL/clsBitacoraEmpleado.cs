using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsBitacoraEmpleado
    {
        public bool AgregarBitacoraEmpleado(int idUsuario, string nombreUsuario, DateTime fechaCambio, int IdTipoIdentificacion, string Identificacion, string Nombre, string Apellido1, string Apellido2,
            string Direccion, string fechaNacimiento, string departamento, string Correo, string Telefono, char Provincia, string Canton, string Distrito,
            string FechaEntrada, string FechaSalida, bool Estado, bool estadoEmpleado)
        {
            try
            {
                int respuesta = 1;
                DatosDataContext dc = new DatosDataContext();
                respuesta = Convert.ToInt32(dc.AgregarBitacoraEmpleado(idUsuario, nombreUsuario, fechaCambio, IdTipoIdentificacion, Identificacion, Nombre, Apellido1, Apellido2,
             Direccion, fechaNacimiento, departamento, Correo, Telefono, Provincia, Canton, Distrito,
             FechaEntrada, FechaSalida, Estado, estadoEmpleado));

                if (respuesta == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool ActualizarBitacoraEmpleado(int idEmpleado, int idUsuario, string nombreUsuario, DateTime fechaCambio, int IdTipoIdentificacion, string Identificacion, string Nombre, string Apellido1, string Apellido2, string Direccion, string fechaNacimiento, string departamento, string correo, string telefono, char provincia, string canton, string distrito
            , string fechaEntrada, string fechaSalida, bool Estado, bool estadoEmpleado)
        {
            try
            {
                int respuesta = 1;
                DatosDataContext dc = new DatosDataContext();
                respuesta = dc.ActualizarBitacoraEmpleado(idEmpleado, idUsuario, nombreUsuario, fechaCambio, IdTipoIdentificacion, Identificacion, Nombre, Apellido1, Apellido2, Direccion, fechaNacimiento, departamento, correo, telefono, provincia, canton, distrito,
                    fechaEntrada, fechaSalida, Estado, estadoEmpleado);
                if (respuesta == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
