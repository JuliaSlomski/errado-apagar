using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Juizofinal_nivel_parentesco
    {
        public static List<Juizofinal_nivel_parentesco> Lista_falecidos()
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                IList<Juizofinal_nivel_parentesco> listOngs = (from Juizofinal in db.Juizofinal_nivel_parentescos
                                                               orderby Juizofinal.ID
                                                               select Juizofinal).ToList();

                return listOngs.ToList<Juizofinal_nivel_parentesco>();
            }
        }

        public static Juizofinal_nivel_parentesco Get_nivel_cadastro(int ID)
        {
            using (JuizoFinalDataContext db = new JuizoFinalDataContext(DAO.Constantes.ConnectionString))
            {
                Juizofinal_nivel_parentesco Num = (from Obj in db.Juizofinal_nivel_parentescos
                                                   where Obj.ID == ID
                                                   select Obj).FirstOrDefault();

                return Num;
            }
        }
    }
}
