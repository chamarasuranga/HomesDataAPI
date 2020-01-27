using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomesDataAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomesDataAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomesController : ControllerBase
    {
        private static readonly HomesData[] Homes = new[]
        {
            new HomesData(){ Address="1,Bristol Court ,Glen Waverley ,3150" ,Price=500000,Rooms=5 },
            new HomesData(){ Address="1,Bristol Court ,Glen Waverley ,3150" ,Price=500000,Rooms=5 },
            new HomesData(){ Address="1,Bristol Court ,Glen Waverley ,3150" ,Price=500000,Rooms=5 }
        };

        private readonly ILogger<HomesController> _logger;

        public HomesController(ILogger<HomesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<HomesData> Get()
        {
            return Homes; ;
        }
    }
}
