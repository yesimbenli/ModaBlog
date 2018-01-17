using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VideoRepository
    {
        private MyContext db = new MyContext();
        public Video GetVideoByID(int ID)
        {
            return db.Videolar.Find(ID);
        }
        public List<Video> GetAllVideos()
        {
            return db.Videolar.ToList();
        }
        public List<Video> SearchGallerys(string searchTxt)
        {
            return db.Videolar.Where(x => x.Aciklama.Contains(searchTxt)).ToList();
        }
        public void AddVideo(Video newVideo)
        {
            db.Videolar.Add(newVideo);
            db.SaveChanges();
        }
        public void DeleteVideo(Video trash)
        {
            db.Videolar.Remove(trash);
            db.SaveChanges();
        }
        public void DeleteVideoByID(int ID)
        {
            db.Videolar.Remove(GetVideoByID(ID));
            db.SaveChanges();
        }
        public void UpdateVideo(Video updateVideo)
        {
            var orginal = GetVideoByID(updateVideo.VideoID);
            orginal.VideoURL = updateVideo.VideoURL;
            orginal.Aciklama = updateVideo.Aciklama;
            orginal.Baslik = updateVideo.Baslik;

            db.Entry(orginal).State = System.Data.Entity.EntityState.Modified;//state kaydın durumu eklendi silindi modified edildi demek biz modified ettik
            db.SaveChanges();
        }
    }
}
