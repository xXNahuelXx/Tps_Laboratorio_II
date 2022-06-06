using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    public static class GestorArchivo<T>
    {
        static string rutaBase;
        static GestorArchivo()
        {
            GestorArchivo<T>.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

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
