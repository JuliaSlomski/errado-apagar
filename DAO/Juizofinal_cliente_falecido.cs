using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public partial class Juizofinal_cliente_falecido
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

                    db.Juizofinal_cliente_falecidos.InsertOnSubmit(this);
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


        public static List<Juizofinal_cliente_falecido> Get_falecido(int id_cliente)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_cliente_falecido> list = (from Obj in db.Juizofinal_cliente_falecidos
                                                           where Obj.ID_cliente == id_cliente
                                                           select Obj).ToList();

                return list.ToList<Juizofinal_cliente_falecido>();
            }
        }


        public static Juizofinal_cliente_falecido Get_cliente_busca(int Id)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_cliente_falecido Cliente = (from Obj in db.Juizofinal_cliente_falecidos
                                                       where Obj.ID_cliente == Id
                                                       select Obj).FirstOrDefault();

                return Cliente;
            }
        }
    }
}
