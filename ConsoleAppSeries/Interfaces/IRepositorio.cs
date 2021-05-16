using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSeries.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Listar();
        T RetornarPorId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
