using System;
using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Repositories.Abstract;

namespace CA_Sotify_Ödev_.Repositories.Concretes
{
    public class ArtistsReopsitory: IArtistsRepository
    {
        MyDbContext context = new MyDbContext();

        public void GetAllArtists()
        {
            foreach (Artisit artist in context.Artisits)
            {
                string artistFormat = $"Id: {artist.Id} Ad: {artist.Name} Soyad: {artist.Surname} Doğum Tarihi: {artist.DateOfBirth}";
                Console.WriteLine(artistFormat);
            }
        }

        public void CreateArtist(Artisit artist)
        {
            context.Artisits.Add(artist);
            context.SaveChanges();
            Console.WriteLine("Sanatçı eklendi.");
        }

        public void UpdateArtist(Artisit updated)
        {
            var artist = context.Artisits.Find(updated.Id);
            if (artist != null)
            {
                artist.Name = updated.Name;
                artist.Surname = updated.Surname;
                artist.DateOfBirth = updated.DateOfBirth;
                // Diğer alanlar varsa ekleyin
                context.SaveChanges();
                Console.WriteLine("Sanatçı güncellendi.");
            }
            else
            {
                Console.WriteLine("Sanatçı bulunamadı.");
            }
        }

        public void DeleteArtist(int id)
        {
            var artist = context.Artisits.Find(id);
            if (artist != null)
            {
                context.Artisits.Remove(artist);
                context.SaveChanges();
                Console.WriteLine("Sanatçı silindi.");
            }
            else
            {
                Console.WriteLine("Sanatçı bulunamadı.");
            }
        }
    }
}
