using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Juizofinal_falecido
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

                    db.Juizofinal_falecidos.InsertOnSubmit(this);
                    db.SubmitChanges();
                    return "";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<Juizofinal_falecido> Lista_falecidos()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_falecido> listOngs = (from Juizofinal in db.Juizofinal_falecidos
                                                       orderby Juizofinal.Nome_falecido
                                                       select Juizofinal).ToList();

                return listOngs.ToList<Juizofinal_falecido>();
            }
        }


        public static Juizofinal_falecido Get_falecido(string nome_falecido)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_falecido falecido = (from Obj in db.Juizofinal_falecidos
                                                where Obj.Nome_falecido_busca == nome_falecido
                                                select Obj).FirstOrDefault();

                return falecido;
            }
        }

        public void UpdateRegistro()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                try
                {
                    var obj = (from Objs in db.Juizofinal_falecidos
                               where Objs.ID_falecido == this.ID_falecido
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

        private void Map(Juizofinal_falecido objDb, Juizofinal_falecido objNew)
        {
            objDb.estrelas_azuis = objNew.estrelas_azuis;
            objDb.estrelas_brancas = objNew.estrelas_brancas;
            objDb.estrelas_vermelhas = objNew.estrelas_vermelhas;
            objDb.vela = objNew.vela;
        }



        public void UpdateRegistro_falecido()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                try
                {
                    var obj = (from Objs in db.Juizofinal_falecidos
                               where Objs.ID_falecido == this.ID_falecido
                               select Objs).Single();

                    Map_(obj, this);

                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    // TODO: Gerar log de erro
                    throw;
                }
            }
        }

        private void Map_(Juizofinal_falecido objDb, Juizofinal_falecido objNew)
        {
            objDb.Nome_pai = objNew.Nome_pai;
            objDb.Nome_mae = objNew.Nome_mae;
            objDb.data_nasceimento = objNew.data_nasceimento;
            objDb.data_morte = objNew.data_morte;
            objDb.cidade_nascimento = objNew.cidade_nascimento;
            objDb.cidade_morte = objNew.cidade_morte;
            objDb.causa_morte = objNew.causa_morte;
            objDb.profissao = objNew.profissao;
            objDb.epitafio = objNew.epitafio;
            objDb.DT_Alteracao = objNew.DT_Alteracao;
        }




        public static List<Juizofinal_falecido> Get_falecido_a()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_falecido> listOngs = (from Obj in db.Juizofinal_falecidos
                                                       where Obj.Nome_falecido_busca.StartsWith("a")
                                                       orderby Obj.Nome_falecido_busca ascending
                                                       select Obj).ToList();

                return listOngs.ToList<Juizofinal_falecido>();
            }
        }


        public static Juizofinal_falecido Get_falecido_busca(int id_falecido)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_falecido falecido = (from Obj in db.Juizofinal_falecidos
                                                where Obj.ID_falecido == id_falecido
                                                select Obj).FirstOrDefault();

                return falecido;
            }
        }
    }
}
