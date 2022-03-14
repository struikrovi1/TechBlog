using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {

        List<Category> getAll();
        void Create(Category category);

    }
}
