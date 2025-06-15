using System;
using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Repositories.Abstract;
namespace CA_Sotify_Ödev_.Repositories.Concretes
{
    public class AlbumRepository: IAlbumRepository
    {
        MyDbContext context = new MyDbContext();

        public void GetAllAlbums()
        {
            foreach (Album album in context.Albums)
            {
                string albumFormat = $"Id: {album.Id} Ad: {album.Name} Çıkış Tarihi: {album.ReleaseDate}";
                Console.WriteLine(albumFormat);
            }
        }

        public void CreateAlbum(Album album)
        {
            context.Albums.Add(album);
            context.SaveChanges();
            Console.WriteLine("Albüm eklendi.");
        }

        public void UpdateAlbum(Album updated)
        {
            var album = context.Albums.Find(updated.Id);
            if (album != null)
            {
                album.Name = updated.Name;
                album.ReleaseDate = updated.ReleaseDate;
                // Diğer alanlar varsa ekleyin
                context.SaveChanges();
                Console.WriteLine("Albüm güncellendi.");
            }
            else
            {
                Console.WriteLine("Albüm bulunamadı.");
            }
        }

        public void DeleteAlbum(int id)
        {
            var album = context.Albums.Find(id);
            if (album != null)
            {
                context.Albums.Remove(album);
                context.SaveChanges();
                Console.WriteLine("Albüm silindi.");
            }
            else
            {
                Console.WriteLine("Albüm bulunamadı.");
            }
        }
    }
}
