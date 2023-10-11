using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dDatos
    {
        Database db;
        List<eCiudad> listaciudad;
        List<eAlmacen> listaalmacen;
        List<eLoteSalida> listalotessalidas;
        List<eLoteentrante> listalotesentrantes;
        List<eUsuario> listausuarios;
        public dDatos()
        {
            db = new Database();
            listaciudad = listarciudad();
            listaalmacen = listaralmacen();
            listalotessalidas = listarLoteSaliente();
            listalotesentrantes = listarLote_Entrante();
            listausuarios = listarUsuario();


        }





         public List<eUsuario> listarUsuario()
         {
            try
            {
                List<eUsuario> lista = new List<eUsuario>();

                eUsuario objUsuario;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select usuario, contrasenia from Usuario", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objUsuario = new eUsuario();
                    objUsuario.usuario = (string)reader["usuario"];
                    objUsuario.contrasenia = (string)reader["contrasenia"];
                    lista.Add(objUsuario);
                }

                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }




        public bool EliminarUsuarioPorNombre(string nombreUsuario)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE usuario = @NombreUsuario", con);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Si se eliminó al menos una fila, se considera exitoso
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tu lógica de aplicación
                return false;
            }
            finally
            {
                db.DesconectaDB();
            }
        }




        // lote entrante
        public string Insertar_LoteEntrante(eLoteentrante obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into  LoteEntrada(contenido,tipo,fecha_entrada,ID_almacen) values ({0},'{1}',{2},{3})", obj.contenido, obj.tipo, obj.fecha_entrada, obj.almacen);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "inserto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }

        }

        // lote saliente 

        public string Insertar_LoteSaliente(eLoteSalida objLS)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into LoteSaliente (tipo,fecha_salida,ciudad,ID_almacen,contenido) values ('{0}',{1},'{2}',{3},{4})",objLS.tipo,objLS.fecha_salida,objLS.nombreciudad,objLS.almacen,objLS.contenido_salida);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Inserto";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }





        // almacén 

        public string Insertar_Almacen(eAlmacen obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("INSERT INTO Almacen (contenidoPetroleo,contenidoGasolina) VALUES ({0},{1})", 0, 0);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "inserto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        // ingreso de contenido almacen

        /*la cantidad de contenido de almacen se cambia cuando un lote entra     
         Y el cambio depende del tipo del lote entrante
         Y la cantidad de contenido que tiene el lote 
       va a cambiar aquel almacen que tenga 
        IDalmacen igual al lote entrandte
        Tipo 
         */



        public void Ingresocontenido_LoteentrantePetroleoalmacen(eLoteentrante obj)//pasa cuando se inserta lote entrante
        {
            listaalmacen = listaralmacen();
            int cantidad = obj.contenido;
            eAlmacen almacenencontado = listaalmacen.Find(delegate (eAlmacen value)
            { return obj.almacen == value.ID_Almacen; });

            try
            {
                cantidad = cantidad + almacenencontado.cantidad_petroleo;
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Almacen set contenidoPetroleo={1} where ID_almacen={0}", almacenencontado.ID_Almacen, cantidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                listaalmacen = listaralmacen();
            }
            finally
            {
                db.DesconectaDB();
            }

        }

        public void Ingresocontenido_LoteentranteGasolinaalmacen(eLoteentrante obj)//pasa cuando se inserta lote entrante
        {
            listaalmacen = listaralmacen();
            int cantidad = obj.contenido;
            eAlmacen almacenencontado = listaalmacen.Find(delegate (eAlmacen value)
            { return obj.almacen == value.ID_Almacen; });

            try
            {
                cantidad = cantidad + almacenencontado.cantidad_petroleo;
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Almacen set contenidoGasolina={1} where ID_almacen={0}", almacenencontado.ID_Almacen, cantidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();


            }

            finally
            {
                db.DesconectaDB();
            }

        }

        public List<eAlmacen> listaralmacen()
        {
            try
            {
                List<eAlmacen> lista = new List<eAlmacen>();

                eAlmacen objalmacen = null;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select ID_almacen, contenidoPetroleo, contenidoGasolina from almacen", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objalmacen = new eAlmacen();
                    objalmacen.ID_Almacen = (int)reader["ID_almacen"];
                    objalmacen.cantidad_gasolina = (int)reader["contenidoGasolina"];
                    objalmacen.cantidad_petroleo = (int)reader["contenidoPetroleo"];
                    lista.Add(objalmacen);

                }

                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        // ciudad 

        public string Insertar_Ciudad(eCiudad obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into  Ciudad(ciudad,contenidoPetroleo,contenidoGasolina,Precio) values ('{0}',{1},{2},{3})", obj.nombre_ciudad, 0, 0,obj.precio);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "inserto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        // ingreso de contenido ciudad y disminución en el contenido del almacén

        //almacen

        public void Salidacontenido_LotesalientePetroleo(eLoteSalida obj)//pasa cuando se inserta lote entrante
        {
            listaalmacen = listaralmacen();
            int cantidad = obj.contenido_salida;
            eAlmacen almacenencontado = listaalmacen.Find(delegate (eAlmacen value)
            { return obj.almacen == value.ID_Almacen; });

            try
            {
                cantidad = almacenencontado.cantidad_petroleo - cantidad;
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Almacen set contenidoPetroleo={1} where ID_almacen={0}", almacenencontado.ID_Almacen,cantidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                listaalmacen = listaralmacen();

            }
            finally
            {
                db.DesconectaDB();
            }

        }

        //almacen

        public void Salidacontenido_LotesalienteGasolina(eLoteSalida obj)//pasa cuando se inserta lote entrante
        {
            listaalmacen = listaralmacen();
            int cantidad = obj.contenido_salida;
            eAlmacen almacenencontado = listaalmacen.Find(delegate (eAlmacen value)
            { return obj.almacen == value.ID_Almacen; });

            try
            {
                cantidad = cantidad - obj.contenido_salida;
                
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Almacen set contenidoPetroleo={1} where ID_almacen={0}", almacenencontado.ID_Almacen,cantidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                listaalmacen = listaralmacen();
            }
            finally
            {
                db.DesconectaDB();
            }

        }

        // ciudad
        public List<eCiudad> listarciudad()
        {
            try
            {
                List<eCiudad> lista = new List<eCiudad>();
             
                eCiudad objciudad ;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select ciudad,contenidoPetroleo,contenidoGasolina,Precio from Ciudad", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objciudad = new eCiudad();
                    objciudad.nombre_ciudad = (string)reader["ciudad"];
               objciudad.cantidad_gasolina_enviada = (int)reader["contenidoGasolina"];
                objciudad.cantidad_petroleo_enviada = (int)reader["contenidoPetroleo"];
               objciudad.precio = (decimal)reader["Precio"];
               lista.Add(objciudad);
                }

                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        // ciudad 

        public void Ingresocontenido_LotesalienteCiudadPetroleo(eLoteSalida obj)//pasa cuando se inserta lote entrante
        {
            //  listaalmacen = listaralmacen();
            listaciudad = listarciudad();
            int cantidad = obj.contenido_salida;
            eCiudad ciudadnencontado = listaciudad.Find(delegate (eCiudad value)
            { return obj.nombreciudad == value.nombre_ciudad; });

            try
            {
                cantidad = ciudadnencontado.cantidad_petroleo_enviada + cantidad;
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Ciudad set contenidoPetroleo={1} where ciudad='{0}'", ciudadnencontado.nombre_ciudad, cantidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                listaciudad = listarciudad();

            }
            finally
            {
                db.DesconectaDB();
            }

        }

        //ciudad
        public void Ingresocontenido_LotesalienteCiudadGasolina(eLoteSalida obj)//pasa cuando se inserta lote salida
        {
            //  listaalmacen = listaralmacen();
            listaciudad = listarciudad();
            int cantidad = obj.contenido_salida;
            eCiudad ciudadnencontado = listaciudad.Find(delegate (eCiudad value)
            { return obj.nombreciudad== value.nombre_ciudad; });
            try
            {
                cantidad = ciudadnencontado.cantidad_gasolina_enviada + cantidad;

                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Ciudad set contenidoGasolina={1} where ciudad='{0}'", ciudadnencontado.nombre_ciudad, cantidad);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                listaciudad = listarciudad();

            }
            finally
            {
                db.DesconectaDB();
            }

        }

        // listar lote entrante
        public List<eLoteentrante> listarLote_Entrante()
        {
            try
            {
                List<eLoteentrante> lista = new List<eLoteentrante>();


                eLoteentrante objentrante ;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select ID,contenido,fecha_entrada,tipo,ID_almacen from LoteEntrada", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objentrante = new eLoteentrante();
                    objentrante.ID_LoteE = (int)reader["ID"];
                    objentrante.contenido = (int)reader["contenido"];
                    objentrante.tipo = (string)reader["tipo"];
                    objentrante.fecha_entrada = (int)reader["fecha_entrada"];
                    objentrante.almacen = (int)reader["ID_almacen"];
                   
                //    objentrante.almacen.ID_Almacen = (int)reader["ID_almacen"];
                    lista.Add(objentrante);
                }

                reader.Close();
                return lista;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        //listarlote saliente
        public List<eLoteSalida> listarLoteSaliente()
        {
            try
            {
                List<eLoteSalida> lista = new List<eLoteSalida>();


                eLoteSalida objlotesalida ;
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("select ID,contenido,tipo,fecha_salida,ID_almacen,ciudad,Precio from LoteSaliente", con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    objlotesalida = new eLoteSalida();
                    objlotesalida.ID_LoteS = (int)reader["ID"];
                    objlotesalida.tipo = (string)reader["tipo"];
                    objlotesalida.fecha_salida = (int)reader["fecha_salida"];
                    objlotesalida.contenido_salida = (int)reader["contenido"];
                    objlotesalida.nombreciudad = (string)reader["ciudad"];
               
                    objlotesalida.almacen = (int)reader["ID_almacen"];
                    lista.Add(objlotesalida);

                    
                }

                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        public List<eAlmacen> almacenmascombus()
        {
            List<eAlmacen> maximos = new List<eAlmacen>();
            int petro;
            int combus;
            int sumamax = 0;
            int suma = 0;
            foreach (eAlmacen x in listaalmacen)
            { petro = x.cantidad_petroleo;
                combus = x.cantidad_gasolina;
                suma = petro + combus;
                if (sumamax <= suma)
                {
                    sumamax = suma;
                }

            }
            foreach (eAlmacen x in listaalmacen)
            {
                petro = x.cantidad_petroleo;
                combus = x.cantidad_gasolina;
                suma = petro + combus;
                if (sumamax == suma)
                { maximos.Add(x); }

            }
            return maximos;
        }
        public List<eCiudad> ciudadmasenvios()
        {
            List<eCiudad> ciudadmasenvios = new List<eCiudad>();
          


            foreach (eLoteSalida x in listalotessalidas)
            {
                foreach (eCiudad y in listaciudad)
                {
                    if (x.nombreciudad == y.nombre_ciudad)
                    {
                        y.cantidadenvia = y.cantidadenvia + 1;
                    }
                }
            
            }
            int cantidadmax=0;
            foreach (eCiudad y in listaciudad)
            {
                if (cantidadmax < y.cantidadenvia)
                    cantidadmax = y.cantidadenvia;
            }
            foreach (eCiudad y in listaciudad)
            {
                if (cantidadmax == y.cantidadenvia)
                    ciudadmasenvios.Add(y);
            }
            return ciudadmasenvios;
        }

        public string combustiblemayor()
        {
            int acumuladorP=0;
            int acumuladorC = 0;
            foreach (eAlmacen x in listaalmacen)
            {
                acumuladorP = acumuladorP + x.cantidad_petroleo;
                acumuladorC = acumuladorC + x.cantidad_gasolina;
            }
            if (acumuladorC < acumuladorP)
            { return "Petroleo"; }
            else
            {
                if (acumuladorP < acumuladorC)
                    return "Gasolina";
                else
                {
                    return "Cantidades iguales"; 
                }
            }
           
          
        }
        public List<eLoteentrante> Ordenar()
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("Sp_Sell_Ordenarseguntipo2", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                List<eLoteentrante> lsSector = new List<eLoteentrante>();
                while (reader.Read())
                {

                    eLoteentrante sector = new eLoteentrante();
                    sector.ID_LoteE = (int)reader["ID"];
                    sector.fecha_entrada = (int)reader["FechaEntrada"];
                    sector.tipo = (string)reader["TIPO"];
                    sector.contenido = (int)reader["Contenido"];
                    lsSector.Add(sector);
                }
                reader.Close();
                return lsSector;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally { db.DesconectaDB(); }
        }



        public string Insertar_Usuario(eUsuario obj)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into  Usuario(usuario, contrasenia) values ('{0}','{1}')", obj.usuario, obj.contrasenia);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Usuario registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDB();
            }

        }

        public bool ActualizarContraseña(string nuevaContrasenia, string antiguaContrasenia)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand("UPDATE Usuario SET contrasenia = @nuevaContrasenia WHERE contrasenia = @antiguaContrasenia", con);
                cmd.Parameters.AddWithValue("@antiguaContrasenia", antiguaContrasenia);
                cmd.Parameters.AddWithValue("@nuevaContrasenia", nuevaContrasenia);
                int rowsAffected = cmd.ExecuteNonQuery();

                // Si se actualizó al menos una fila, se considera exitoso
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tu lógica de aplicación
                return false;
            }
            finally
            {
                db.DesconectaDB();
            }
        }



    }
}

