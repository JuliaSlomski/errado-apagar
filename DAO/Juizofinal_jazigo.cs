using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;
using System.Text;
using System.Collections;
using System.Data;
namespace DAO
{
    public partial class Juizofinal_jazigo
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

                    db.Juizofinal_jazigos.InsertOnSubmit(this);
                    db.SubmitChanges();
                    return "";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<Juizofinal_jazigo> Lista_falecidos_jazigo(int id_cliente)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_jazigo> listOngs = (from Juizofinal in db.Juizofinal_jazigos
                                                     where Juizofinal.ID_cliente == id_cliente
                                                     orderby Juizofinal.Nome_falecido
                                                     select Juizofinal).ToList();

                return listOngs.ToList<Juizofinal_jazigo>();
            }
        }

        public static Juizofinal_jazigo Nome_jazigo_cadastro(int id_cliente)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_jazigo Juizo_jazigo = (from Juizo in db.Juizofinal_jazigos
                                                  where Juizo.ID_cliente == id_cliente
                                                  select Juizo).FirstOrDefault();

                return Juizo_jazigo;
            }
        }

        public static Juizofinal_jazigo Nome_jazigo_dados(int id_cliente, string nome)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_jazigo Juizo_jazigo = (from Juizo in db.Juizofinal_jazigos
                                                  where Juizo.ID_cliente == id_cliente
                                                  && Juizo.Nome_falecido == nome
                                                  select Juizo).FirstOrDefault();

                return Juizo_jazigo;
            }
        }

        //public static IList Get()
        //{
        //    using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
        //    {
        //        var listlancamentos = (from Ong in db.Juizofinal_jazigos
        //                               //where Ong.ID_cliente == id_usuario
        //                               select new { c = Ong.ID_cliente }).Distinct().ToList();

        //        return listlancamentos;
        //    }
        //}
    }
}
