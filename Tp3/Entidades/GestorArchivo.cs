using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    /// <summary>
    /// Clase generica para manejar distintos tipos en los archivos.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class GestorArchivo<T>
    {
        static string rutaBase;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        static GestorArchivo()
        {
            GestorArchivo<T>.rutaBase = AppDomain.CurrentDomain.BaseDirectory;
        }

        /// <summary>
        /// Metodo que serializa el dato recibido. Lanza una excepcion si no pudo guardar el archivo.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="dato"></param>
        /// <exception cref="GuardarException"></exception>
        public static void Serializar(string nombreArchivo, T dato)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{GestorArchivo<T>.rutaBase}\\{nombreArchivo}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(sw, dato);
                }
            }
            catch (GuardarException)
            {
                throw new GuardarException("Hubo un error al guardar");
            }

        }

        /// <summary>
        /// Mertodo que deserializa el archivo. Lanza una excepcion si no pudo traer el archivo.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static T Deserializar(string nombreArchivo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    T dato = (T)xml.Deserialize(sr);
                    return dato;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar los datos, si el problema persiste, debe reiniciar!", ex);
            }
        }

        /// <summary>
        /// Metodo para generar un archivo txt que guarde el historial de los movimientos de los clientes con sus datos.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool HistorialClientes(string nombreArchivo, string info)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(($"{GestorArchivo<T>.rutaBase}\\{nombreArchivo}"),true))
                {
                    sw.WriteLine(info);
                }
            }
            catch(Exception)
            {
                throw new Exception("No se pudo guardar el archivo, si el problema persiste, debe reiniciar!");
            }
            return true;
        }
    }
}
