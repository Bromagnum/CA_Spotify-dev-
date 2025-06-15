using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Models;

namespace CA_Sotify_Ödev_.Repositories.Abstract
{
    public interface IArtistsRepository
    {
              
        void GetAllArtists();
        void CreateArtist(Artisit artist);
        void UpdateArtist(Artisit updated);
        void DeleteArtist(int id);
       
    }
}
