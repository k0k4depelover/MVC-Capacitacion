using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace CapaVista_PolloRey
{
    public class ValidacionDatos
    {
        private ValidationContext contexto;
        private List<ValidationResult> resultados;
        private bool valido;
        private string message;

        public ValidacionDatos(object instancia)
        {
            contexto = new ValidationContext(instancia);
            resultados = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, contexto, resultados, true);
        }

        public bool Validar()
        {
            if (valido == false)
            {
                foreach (ValidationResult result in resultados)
                {
                    message += result.ErrorMessage + "\n";
                }

                System.Windows.Forms.MessageBox.Show(message);
            }
            return valido;
        }
    }
}
