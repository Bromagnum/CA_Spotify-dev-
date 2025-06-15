using System.Collections.Generic;
using CA_Sotify_Ödev_.Models;

namespace CA_Sotify_Ödev_.Repositories.Abstract
{
    public interface IAlbumRepository
    {
        void GetAllAlbums();
        void CreateAlbum(Album album);
        void UpdateAlbum(Album updated);
        void DeleteAlbum(int id);
    }
}