using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FStore.Model;

namespace FStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FurnitureStoreController : ControllerBase
    {

        private readonly IRepTest _FurDetails;


        public FurnitureStoreController(IRepTest objuserDetails)
        {

            _FurDetails = objuserDetails;

        }

        [HttpGet]
        [Route("GetAllFurniture")]
        public IList<Models> GetAllFurniture()
        {
            try
            {
                return _FurDetails.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }



        [HttpPost]
        [Route("AddFurniture")]
        public Models AddFurniture(Models data) //AddExam([FromBody] TblTEmpactMain data)
        {
            try
            {
                _FurDetails.Add(data);
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }






    }
}
