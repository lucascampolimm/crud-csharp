using crud_c_sharp_sqlite.Gateway;
using crud_c_sharp_sqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_c_sharp_sqlite.Manager
{
    // Isola o modelo do banco do controle da aplicação.
    public class GerenciarEstudante
    {
        // Abre conexão com o modelo do banco.
        ConexaoEstudante _conexaoEstudante=new ConexaoEstudante();

        // Método de adicionar estudantes, o controle envia para o model.
        // bool porque é necessário saber o status da execução.
        public bool Add(Estudante estudante)
        {
            return _conexaoEstudante.Add(estudante);
        }

        // Método que lista todos os dados da tabela.
        public List<Estudante>GetAll()
        {
            return _conexaoEstudante.GetAll();
        }
        // Método que faz o update.
        public bool Update(Estudante estudante)
        {
            return _conexaoEstudante.Update(estudante);
        }
        // Método que faz o delete.
        public bool Delete(int id)
        {
            return _conexaoEstudante.Delete(id);
        }
    }
}
