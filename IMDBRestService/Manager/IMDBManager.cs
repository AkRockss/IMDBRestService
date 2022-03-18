using IMDBRestService.Contexts;
using IMDBRestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IEnumerable<NameBasic> GetAll(string substring)
        {
            IEnumerable<NameBasic> nameBasics = from nameBasic in _context.NameBasicData
                                                where (substring == null || nameBasic.nconst.Contains(substring))
                                                   select nameBasic;
            return nameBasics;
        }

    

        public IEnumerable<NameBasic> Add(NameBasic nameBasics)
        {
             
            _context.NameBasicData.Add(nameBasics);
            _context.SaveChanges();

            return new List<NameBasic>();
        }


        public NameBasic GetByNconst(string nconst)
        {
            //The find method looks for the primary key (id)
            return _context.NameBasicData.Find(nconst);
        }


        //



    }
}
