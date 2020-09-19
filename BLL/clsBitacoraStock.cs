using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsBitacoraStock
    {
        public bool AgregarBitacoraStock(int idUsuario, string nombreUsuario, DateTime fechaCambio, int idBodega, string nombreProducto, 
            int unidad, string codigoBodega, int idProveedor, bool estadoStock)
        {
            try
            {
                int respuesta = 1;
                DatosDataContext dc = new DatosDataContext();
                respuesta = Convert.ToInt32(dc.AgregarBitacoraStock(idUsuario, nombreUsuario, fechaCambio, idBodega, nombreProducto, 
                    unidad, codigoBodega, idProveedor, estadoStock));

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

        public bool ActualizarBitacoraStock(int idStock, int idUsuario, string nombreUsuario, DateTime fechaCambio, int idBodega, string nombreProducto, int unidad, string codigoBodega
        , int idProveedor, bool estadoStock)
        {
            try
            {
                int respuesta = 1;
                DatosDataContext dc = new DatosDataContext();
                respuesta = dc.ActualizarBitacoraStock(idStock, idUsuario, nombreUsuario, fechaCambio, idBodega, nombreProducto, unidad, codigoBodega, idProveedor, estadoStock);
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
