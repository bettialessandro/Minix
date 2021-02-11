using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace Minix.Data
{
    public class dal
    {
        MinixContext db = new MinixContext();
        public List<View_Mag> GetAllArticoli()
        {
                List<View_Mag> art;
                art = db.View_Mags.ToList();
            if(art != null )
            {
                return art;
            }
            else
            {
                return null;
            }
            
        }
        public List<articoli> GetArticoli()
        {
            List<articoli> art;
            art = db.articolis.ToList();
            if (art != null)
            {
                return art;
            }
            else
            {
                return null;
            }

        }
        public View_Mag GetViwArticolo(int id)
        {
            View_Mag art = new View_Mag();
            art = db.View_Mags.FirstOrDefault(x => x.ID == id);

            if (art != null)
            {
                return art;
            }
            else
            {
                return null;
            }

        }



        public Boolean SaveAll(List<View_Mag> art)
        {
            using var transaction = db.Database.BeginTransaction();
            List<articoli> allArt = new List<articoli>();
            allArt = GetArticoli();
           
            foreach(View_Mag arti in art)
            {
                var found = allArt.FirstOrDefault(c => c.ID == arti.ID);
                found.QTA = arti.QTA;
                var k = db.articolis.Update(found);
            }
            
            
            var a = db.SaveChanges();

            transaction.Commit();
            return true;

        }
        public List<View_Mag> Search(string PN)
        {

            List<View_Mag> a = new List<View_Mag>();
            if(PN != "")
            {
                a = db.View_Mags.Where(x => x.PN == PN).ToList();

            }
            else
            {
                a = GetAllArticoli();
            }

            if (a != null)
            {
                return a;

            }
            else
            {
                return null;
            }
        }

        public bool cechkUser(user u)
        {
            List<user> ut = new List<user>();

            ut = db.users.ToList();

            foreach(user ru in ut )
            {
                if (ru.User == u.User && ru.Password==u.Password)
                {
                    return true;

                }
            }

            return false;

        }


    }
}
