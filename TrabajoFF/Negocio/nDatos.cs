using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class nDatos
    {
        dDatos Repsoldd;
        public List<eCiudad> ciudadess { get; set; }
        public nDatos()
        {
            Repsoldd = new dDatos();
            ciudadess = ListarCiudad();
        }
        // LOTE ENTRANTE

        public string RegistrarLoteEntrante(eLoteentrante lote)
        {
            Sumacontenido(lote);
            return Repsoldd.Insertar_LoteEntrante(lote);

        }
        public void Sumacontenido(eLoteentrante lote)
        {
            if (lote.tipo == "Petroleo")
            { 
                Repsoldd.Ingresocontenido_LoteentrantePetroleoalmacen(lote); 
            }
            else
           { Repsoldd.Ingresocontenido_LoteentranteGasolinaalmacen(lote); }
        }


        //  public void IngresoPetroleo(eLoteentrante lote)
        // {
        //     Repsoldd.Ingresocontenido_LoteentrantePetroleoalmacen(lote);
        // }
        //    public void IngresoGalosina(eLoteentrante lote)
        // {
        //     Repsoldd.Ingresocontenido_LoteentranteGasolinaalmacen(lote);
        //  }
        // REGISTRO LOTE saliente
        public void Restacontenido(eLoteSalida lote)
        {
            if (lote.tipo == "Petroleo")
            { Repsoldd.Ingresocontenido_LotesalienteCiudadPetroleo(lote);
                Repsoldd.Salidacontenido_LotesalientePetroleo(lote);
            }
            else
            {
                Repsoldd.Ingresocontenido_LotesalienteCiudadGasolina(lote);
                Repsoldd.Salidacontenido_LotesalienteGasolina(lote);
            }
        }
        // public void SalePetroleo(eLoteSalida lote)
        // {
        //   Repsoldd.Ingresocontenido_LotesalienteCiudadPetroleo(lote);
        //      Repsoldd.Salidacontenido_LotesalientePetroleo(lote);
        //
        //  }
        //  public void SaleGasolina(eLoteSalida lote)
        //  {
        //      Repsoldd.Ingresocontenido_LotesalienteCiudadGasolina(lote);
        //      Repsoldd.Salidacontenido_LotesalienteGasolina(lote);
        //   }
        
        public string RegistrarLoteSSaliente(eLoteSalida lote)
        {
            Restacontenido(lote);
            return Repsoldd.Insertar_LoteSaliente(lote);
        }


        public string RegistrarAlmacen(eAlmacen almacen)
        {

            return Repsoldd.Insertar_Almacen(almacen);
        }
        public string RegistrarCiudad(eCiudad ciudad)
        {
            return Repsoldd.Insertar_Ciudad(ciudad);
        }
        public List<eLoteentrante> ListarEntrantes()
        {
            return Repsoldd.listarLote_Entrante();
        }
        public List<eLoteSalida> ListarSalientes()
        {
            return Repsoldd.listarLoteSaliente();
        }

        public List<eAlmacen> ListarAlmacenes()
        {
            return Repsoldd.listaralmacen();
        }
        public List<eCiudad> ListarCiudad()
        {
            return Repsoldd.listarciudad();
        }
        public List<eAlmacen> Reportemayorcombustible()
        {
            return Repsoldd.almacenmascombus();
        }
        public List<eCiudad> Reporteciudadmasenvios()
        { return Repsoldd.ciudadmasenvios(); }
        public string Mayorcombustible()
        {
            return Repsoldd.combustiblemayor();
        }
        public List<eLoteentrante> Ordenardescen()
        { return Repsoldd.Ordenar(); }



        //usuario

        public List<eUsuario> ListarUsuarios()
        {
            return Repsoldd.listarUsuario();
        }

        public string RegistrarUsuario(eUsuario nuevousuario)
        {
      
            return Repsoldd.Insertar_Usuario(nuevousuario);

        }

        public bool EliminarUsuario(string usuario)
        {
            return Repsoldd.EliminarUsuarioPorNombre(usuario);
        }

        public bool CambiarContrasenia(string nuevacontrasenia, string antiguacontrasenia)
        {
            return Repsoldd.ActualizarContraseña(nuevacontrasenia, antiguacontrasenia);
        }

    }
}
