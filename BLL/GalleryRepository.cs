using DAL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GalleryRepository
    {
        private MyContext db = new MyContext();
        public Gallery GetGalleryByID(int ID)
        {
            return db.Resimler.Find(ID);
        }
        public List<Gallery> GetAllGallerys()
        {

            return db.Resimler.ToList();
        }
        public List<Gallery> SearchGallerys(string searchTxt)
        {

            return db.Resimler.Where(x => x.ImagePath.Contains(searchTxt)).ToList();
        }
        public void AddGallery(Gallery newGallery)
        {
            db.Resimler.Add(newGallery);
            db.SaveChanges();
        }
        public void DeleteGallery(Gallery trash)
        {
            db.Resimler.Remove(trash);
            db.SaveChanges();
        }
        public void DeleteGalleryByID(int ID)
        {
            db.Resimler.Remove(GetGalleryByID(ID));
            db.SaveChanges();
        }
        public void UpdateGallery(Gallery updateGallery)
        {
            var orginal = GetGalleryByID(updateGallery.ImageID);
            orginal.ImagePath = updateGallery.ImagePath;
            orginal.DescriptionGallery = updateGallery.DescriptionGallery;

            db.Entry(orginal).State = System.Data.Entity.EntityState.Modified;//state kaydın durumu eklendi silindi modified edildi demek biz modified ettik
            db.SaveChanges();
        }
    }
}
