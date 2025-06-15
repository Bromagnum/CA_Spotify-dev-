using System.Collections.Generic;
using CA_Sotify_�dev_.Models;

namespace CA_Sotify_�dev_.Repositories.Abstract
{
    public interface IAlbumRepository
    {
        void GetAllAlbums();
        void CreateAlbum(Album album);
        void UpdateAlbum(Album updated);
        void DeleteAlbum(int id);
    }
}