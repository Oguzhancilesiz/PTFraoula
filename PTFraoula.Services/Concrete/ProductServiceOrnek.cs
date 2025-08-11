using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTFraoula.Services.Concrete
{
    //public class ProductService : IProductServices
    //{
    //    private readonly IBaseRepository<Product> _baseRepository;
    //    private readonly IUnitOfWork _unitOfWork;
    //    public ProductService(IUnitOfWork unitOfWork)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _baseRepository = _unitOfWork.Repository<Product>();
    //    }

    //    public async Task Add(ProductAddDTO productDto)
    //    {
    //        try
    //        {
    //            if (productDto == null)
    //            {
    //                throw new ArgumentNullException(nameof(productDto), "Product cannot be null");
    //            }
    //            Product newProduct = new Product();

    //            productDto.Adapt(newProduct);

    //            await _baseRepository.AddAsync(newProduct);
    //            await _unitOfWork.SaveChangesAsync();
    //        }
    //        catch (Exception ex)
    //        {

    //            throw new Exception(ex.Message);
    //        }
    //    }
    //    public async Task Update(ProductUpdateDTO product)
    //    {
    //        var existingProduct = await _baseRepository.GetById(product.Id);
    //        if (existingProduct == null)
    //        {
    //            throw new KeyNotFoundException("Product not found");
    //        }
    //        var updatedProduct = product.Adapt(existingProduct);
    //        await _baseRepository.Update(updatedProduct);
    //        await _unitOfWork.SaveChangesAsync();

    //    }
    //    public async Task Delete(Guid id)
    //    {
    //        var product = await _baseRepository.GetById(id, ignoreQueryFilter: true);
    //        await _baseRepository.Delete(product);
    //        await _unitOfWork.SaveChangesAsync();
    //    }

    //    public async Task<List<ProductDTO>> GetAll()
    //    {
    //        var result = await _baseRepository.GetAllActives();
    //        var products = result.Adapt<List<ProductDTO>>();
    //        return products;
    //    }

    //    public Task<List<ProductDTO>> GetByCategoryId(Guid categoryId)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<ProductDTO> GetById(Guid id)
    //    {
    //        var product = await _baseRepository.GetById(id, include: q => q.Include(p => p.Category));

    //        if (product == null)
    //            throw new KeyNotFoundException("Product not found");

    //        return product.Adapt<ProductDTO>();
    //    }

    //    public async Task<List<ProductDTO>> GetByName(string name)
    //    {
    //        var result = await _baseRepository.GetBy(x => x.Name.Contains(name));
    //        if (result == null || !result.Any())
    //        {
    //            throw new KeyNotFoundException("No products found with the specified name");
    //        }
    //        return result.Adapt<List<ProductDTO>>();
    //    }

    //    public Task<List<ProductDTO>> GetByPrice(decimal minPrice, decimal maxPrice)
    //    {
    //        throw new NotImplementedException();
    //    }


    //}
}
