using System;
using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Repositories.Abstract;
namespace CA_Sotify_Ödev_.Repositories.Concretes
{
    public class MusicRepository: IMusicRepository
    {
        MyDbContext context = new MyDbContext();

        public void GetAllMusics()
        {
            foreach (Music music in context.Musics)
            {
                string musicFormat = $"Id: {music.Id} Şarkı: {music.SongName} SanatçıId: {music.ArtistId} AlbümId: {music.AlbumId}";
                Console.WriteLine(musicFormat);
            }
        }

        public void CreateMusic(Music music)
        {
            context.Musics.Add(music);
            context.SaveChanges();
            Console.WriteLine("Müzik eklendi.");
        }

        public void UpdateMusic(Music updated)
        {
            var music = context.Musics.Find(updated.Id);
            if (music != null)
            {
                music.SongName = updated.SongName;
                music.ArtistId = updated.ArtistId;
                music.AlbumId = updated.AlbumId;
                // Diğer alanlar varsa ekleyin
                context.SaveChanges();
                Console.WriteLine("Müzik güncellendi.");
            }
            else
            {
                Console.WriteLine("Müzik bulunamadı.");
            }
        }

        public void DeleteMusic(int id)
        {
            var music = context.Musics.Find(id);
            if (music != null)
            {
                context.Musics.Remove(music);
                context.SaveChanges();
                Console.WriteLine("Müzik silindi.");
            }
            else
            {
                Console.WriteLine("Müzik bulunamadı.");
            }
        }

        public void GetAllMusic()
        {
            throw new NotImplementedException();
        }
    }
}
