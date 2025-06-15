using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_Sotify_Ödev_.Models;   
namespace CA_Sotify_Ödev_.Repositories.Abstract
{
    internal interface IMusicRepository
    {
        void GetAllMusic();
        void CreateMusic(Music music);
        void UpdateMusic(Music updated);
        void DeleteMusic(int id);
    }
}
