using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DemoAPI.Models;

namespace DemoAPI.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class IKEAController : Controller{
        public  IEnumerable<IKEA> GetAll(){
            return new List<IKEA>{
                new IKEA{
                    ProductId=1,
                    ProdName="Home Needs",
                    Price=30000
                
                },
                new IKEA{
                    ProductId=2,
                    ProdName="Chair",
                    Price=600
                
                }
            };

        }       

    }
}