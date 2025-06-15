using CA_Sotify_Ödev_.Models;
using CA_Sotify_Ödev_.Repositories.Concretes;
using System;

namespace CA_Sotify_Ödev_.Utils
{
    public class ConsoleMenü
    {
        public void ShowMainMenu()
        {
            string selectedItem = "";

            string[] menuItems = { "Sanatçı İşlemleri", "Albüm İşlemleri", "Müzik İşlemleri", "Kullanıcı İşlemleri", "Çıkış" };

            var artistRepo = new ArtistsReopsitory();
            var albumRepo = new AlbumRepository();
            var musicRepo = new MusicRepository();
            var userRepo = new UserRepository();
            var Artist = new Artisit();
            {

                while (selectedItem != "5")
                {
                    Console.Clear();
                    for (int i = 0; i < menuItems.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {menuItems[i]}");
                    }
                    Console.Write("Seçim: ");
                    selectedItem = Console.ReadLine();

                    switch (selectedItem)
                    {
                        case "1":
                            Console.WriteLine("Sanatçı İşlemleri");
                            Console.WriteLine("1. Tüm Sanatçıları Listele");
                            Console.WriteLine("2. Sanatçı Ekle");
                            Console.WriteLine("3. Sanatçı Güncelle");
                            Console.WriteLine("4. Sanatçı Sil");
                            Console.Write("Seçim: ");
                            var artistChoice = Console.ReadLine();
                            switch (artistChoice)
                            {
                                case "1":
                                    artistRepo.GetAllArtists();
                                    break;
                                case "2":
                                    artistRepo.CreateArtist(new Artisit
                                    {
                                        Name = "",
                                        Surname = "",
                                        DateOfBirth = DateOnly.FromDateTime(DateTime.Now)
                                    });
                                    break;
                                case "3":
                                    artistRepo.UpdateArtist(new Artisit
                                    {
                                        Id = 1,
                                        Name = "",
                                        Surname = "",
                                        DateOfBirth = DateOnly.FromDateTime(DateTime.Now)
                                    });
                                    break;
                                case "4":
                                    artistRepo.DeleteArtist(1);
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("Albüm İşlemleri");
                            Console.WriteLine("1. Tüm Albümleri Listele");
                            Console.WriteLine("2. Albüm Ekle");
                            Console.WriteLine("3. Albüm Güncelle");
                            Console.WriteLine("4. Albüm Sil");
                            Console.Write("Seçim: ");
                            var albumChoice = Console.ReadLine();
                            switch (albumChoice)
                            {
                                case "1":
                                    albumRepo.GetAllAlbums();
                                    break;
                                case "2":
                                    albumRepo.CreateAlbum(new Album
                                    {
                                        AlbumName = " ",

                                        ArtistId = 1
                                    });
                                    break;
                                case "3":
                                    albumRepo.UpdateAlbum(new Album
                                    {
                                        Id = 1,
                                        AlbumName = " ",
                                        ArtistId = 1
                                    });
                                    break;
                                case "4":
                                    albumRepo.DeleteAlbum(1);
                                    break;
                            }
                            break;
                        case "3":
                            Console.WriteLine("Müzik İşlemleri");
                            Console.WriteLine("1. Tüm Müzikleri Listele");
                            Console.WriteLine("2. Müzik Ekle");
                            Console.WriteLine("3. Müzik Güncelle");
                            Console.WriteLine("4. Müzik Sil");
                            Console.Write("Seçim: ");
                            var musicChoice = Console.ReadLine();
                            switch (musicChoice)
                            {
                                case "1":
                                    musicRepo.GetAllMusics();
                                    break;
                                case "2":
                                    musicRepo.CreateMusic(new Music
                                    {
                                        SongName = " ",
                                        AlbumId = 1,
                                        ArtistId = 1,

                                    });
                                    break;
                                case "3":
                                    musicRepo.UpdateMusic(new Music
                                    {
                                        SongName = " ",
                                        ArtistId = 0,
                                        AlbumId = 0,
                                    });
                                    break;
                                case "4":
                                    musicRepo.DeleteMusic(1);
                                    break;
                            }
                            break;
                        case "4":
                            Console.WriteLine("Kullanıcı İşlemleri");
                            Console.WriteLine("1. Tüm Kullanıcıları Listele");
                            Console.WriteLine("2. Kullanıcı Ekle");
                            Console.WriteLine("3. Kullanıcı Güncelle");
                            Console.WriteLine("4. Kullanıcı Sil");
                            Console.Write("Seçim: ");
                            var userChoice = Console.ReadLine();
                            switch (userChoice)
                            {
                                case "1":
                                    userRepo.GetAllUsers();
                                    break;
                                case "2":
                                    userRepo.CreateUser(new User
                                    {
                                        Name = " ",
                                        Surname = " ",
                                        Email = " ",
                                        DateOfBirth = DateOnly.FromDateTime(DateTime.Now)
                                    });
                                    break;
                                case "3":
                                    userRepo.UpdateUser(new User
                                    {
                                        Id = 1,
                                        Name = " ",
                                        Surname = " ",
                                        Email = " ",
                                        DateOfBirth = DateOnly.FromDateTime(DateTime.Now)
                                    });
                                    break;
                                case "4":
                                    userRepo.DeleteUser(1);
                                    break;
                            }
                            break;
                        case "5":
                            Console.WriteLine("Çıkılıyor...");
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim!");
                            break;
                    }

                    if (selectedItem != "5")
                    {
                        Console.WriteLine("Devam etmek için bir tuşa basın...");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
