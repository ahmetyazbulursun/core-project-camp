using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }


        public void CategorDelete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void CategorUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public Category GetByID(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetListAll();
        }
    }
}
