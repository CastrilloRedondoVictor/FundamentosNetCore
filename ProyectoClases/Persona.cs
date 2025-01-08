using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{

    
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Francia, Alemania, Brasil }

    public class Persona
    {

        //public Persona() {

        //    Debug.WriteLine("Constructor vacío persona");

        //    this.Domicilio = new Direccion();
        //}

        public Persona(string nombre, string apellidos)
        {

            Debug.WriteLine("Constructor con parámetros Persona");

            this.Nombre = nombre;
            this.Apellidos = apellidos;

            this.Domicilio = new Direccion();
        }

        #region PROPIEDADES

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }


        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return _Genero; }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor del género incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Pais { get; set; }

        public string Nombre;

        public string Apellidos;

        public int _Edad;

        public int Edad
        {
            get { return _Edad; }

            set
            {
                if (value < 0)
                {
                    throw new Exception("La edad debe ser positiva");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        public string GetNombreCompleto()
        {
            return $"Nombre: {this.Nombre}, Apellidos: {this.Apellidos}";
        }

        #endregion

        #region METODOS
        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Apellidos: {this.Apellidos}, Edad: {this.Edad}, Género: {this.Genero}, País: {this.Pais}, Domicilio: {this.Domicilio.ToString()}";
        }
        #endregion


    }
}
