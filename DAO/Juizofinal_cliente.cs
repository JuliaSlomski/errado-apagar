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
    public partial class Juizofinal_cliente
    {
        public static void RodaProc()
        {
            using (SqlConnection oConn = new SqlConnection(ConfigurationManager.ConnectionStrings["JUIZO"].ConnectionString))
            {
                SqlCommand oComm = new SqlCommand();

                oComm.CommandText = "PreencheJuizo_Clientes";
                oComm.CommandType = CommandType.StoredProcedure;
                oComm.Connection = oConn;
                oConn.Open();
                oComm.ExecuteNonQuery();
            }
        }

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

                    db.Juizofinal_clientes.InsertOnSubmit(this);
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

        public static Juizofinal_cliente GetCliente(string key)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_cliente> listCliente = (from cliente in db.Juizofinal_clientes
                                                         where Convert.ToString(cliente.UserId) == key
                                                         select cliente).ToList();

                if (listCliente.Count > 1)
                    throw new ApplicationException(String.Format("Quantidade de usuarios vinculado a chave {0} incorreta. Esperado '1', encontrado '{1}'", key, listCliente.Count));

                return listCliente.Count > 0 ? listCliente[0] : null;
            }
        }

        public static Juizofinal_cliente GetCliente_ID(int ID)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_cliente Cliente = (from Obj in db.Juizofinal_clientes
                                              where Obj.ID_cliente == ID
                                              select Obj).FirstOrDefault();

                return Cliente;
            }
        }

        public static Juizofinal_cliente busca_cliente(string cliente)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_cliente Cliente = (from Obj in db.Juizofinal_clientes
                                              where Obj.Nome_cliente == cliente
                                              select Obj).FirstOrDefault();

                return Cliente;
            }
        }

        public void UpdateRegistro()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                try
                {
                    var obj = (from Objs in db.Juizofinal_clientes
                               where Objs.ID_cliente == this.ID_cliente
                               select Objs).Single();

                    Map(obj, this);

                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    // TODO: Gerar log de erro
                    throw;
                }
            }
        }

        private void Map(Juizofinal_cliente objDb, Juizofinal_cliente objNew)
        {
            objDb.Licenca_comprada = objNew.Licenca_comprada;
            objDb.Jazigo_comprado = objNew.Jazigo_comprado;
            objDb.Documento = objNew.Documento;
            objDb.Email = objNew.Email;
            objDb.Nome_completo = objNew.Nome_completo;
            objDb.Nome_jazigo = objNew.Nome_jazigo;
            objDb.Corporacao = objNew.Corporacao;
            objDb.Nome_jazigo_corporacao = objNew.Nome_jazigo_corporacao;
        }


        public static List<Juizofinal_cliente> Lista_clientes()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_cliente> listOngs = (from Juizofinal in db.Juizofinal_clientes
                                                      orderby Juizofinal.Nome_cliente
                                                      select Juizofinal).ToList();

                return listOngs.ToList<Juizofinal_cliente>();
            }
        }
    }
}
