using crud_c_sharp_sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_c_sharp_sqlite.Gateway
{
    // Métodos para manipilar a tabela.
    public class ConexaoEstudante
    {
        ContextoBanco _dbContext = new ContextoBanco();

        public bool Add(Estudante estudante)
        {
            _dbContext.Students.Add(estudante);
            return _dbContext.SaveChanges()>0;
        }

        public List<Estudante>GetAll()
        {
            return _dbContext.Students.ToList();
        }

        public bool Update(Estudante estudante)
        {
            var dados=_dbContext.Students.FirstOrDefault(c=>c.Id==estudante.Id);
            if(dados==null)
            {
                return false;
            }
            dados.Name = estudante.Name;
            dados.FatherName = estudante.FatherName;
            dados.Address = estudante.Address;
           return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var estudante=_dbContext.Students.FirstOrDefault(s=>s.Id==id);
            if(estudante==null)
            {
                return false;
            }
            _dbContext.Students.Remove(estudante);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
