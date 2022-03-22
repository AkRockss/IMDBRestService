using IMDBRestService.Contexts;
using IMDBRestService.Models;
using System.Collections.Generic;
using System.Linq;

namespace IMDBRestService.Manager
{
    public class IMDBManager
    {
        private IMDBContext _context;

        public IMDBManager(IMDBContext context)
        {
            _context = context;
        }

        public IMDBManager()
        {

        }

        //NAMEBASIC

        public IEnumerable<NameBasic> GetAll(int substring)
        {
            IEnumerable<NameBasic> nameBasics = from nameBasic in _context.Name_Basic
                                                where substring == null || nameBasic.nconst.Equals(substring)
                                                   select nameBasic;
            return nameBasics;
        }


        public IEnumerable<NameBasic> Add(NameBasic nameBasics)
        {
            _context.Name_Basic.Add(nameBasics);
            _context.SaveChanges();

            return new List<NameBasic>();
        }


        public NameBasic GetByNconst(int nconst)
        {
            return _context.Name_Basic.Find(nconst);
        }


        //TitleAkas

        public TitleAkas GetByTitleId(int titleId)
        {
            return _context.Title_Akas.Find(titleId);
        }


    }
}
