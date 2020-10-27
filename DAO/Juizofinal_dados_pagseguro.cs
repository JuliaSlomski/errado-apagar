using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Juizofinal_dados_pagseguro
    {
        private void FillEmptyStringInNullFields()
        {
            var properties = this.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(String) && property.GetValue(this, null) == null)
                {
                    property.SetValue(this, String.Empty, null);
                }
            }
        }

        public string Insert()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                try
                {
                    this.FillEmptyStringInNullFields();

                    db.Juizofinal_dados_pagseguros.InsertOnSubmit(this);

                    db.SubmitChanges();
                    return "";
                }
                catch (Exception ex)
                {
                    // TODO: Gerar log de erro
                    throw;
                }
            }
        }
    }
}
