using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Juizofinal_nivel_corporacao
    {
        public static List<Juizofinal_nivel_corporacao> Lista_()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_nivel_corporacao> listOngs = (from Juizofinal in db.Juizofinal_nivel_corporacaos
                                                               orderby Juizofinal.ID
                                                               select Juizofinal).ToList();

                return listOngs.ToList<Juizofinal_nivel_corporacao>();
            }
        }

        public static Juizofinal_nivel_corporacao Get_nivel_cadastro_corporacao(int ID)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_nivel_corporacao Num = (from Obj in db.Juizofinal_nivel_corporacaos
                                                   where Obj.ID == ID
                                                   select Obj).FirstOrDefault();

                return Num;
            }
        }

    }
}
