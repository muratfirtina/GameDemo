using System.Collections.Generic;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
        void GetAll(List<Gamer> gamers);

    }
}
