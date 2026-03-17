using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeeShopApp.Infrastructure.Data.Domain;

namespace TeeShopApp.Core.Contracts
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int brandId);
        List<Product> GetProductsByBrand(int brandId);
    }
}
