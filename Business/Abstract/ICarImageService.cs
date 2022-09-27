using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IResult = Core.Utilities.Results.IResult;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int id);
        IDataResult<CarImage> GetByImageId(int imageId);
        IResult Add(IFormFile file, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        

    }
}