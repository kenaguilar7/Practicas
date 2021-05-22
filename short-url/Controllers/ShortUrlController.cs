using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace short_url.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShortUrlController : ControllerBase
    {
        [HttpPost]
        public string CutUrl([FromBody] ParamRequest urlPath)
        {
            EncodeTest(urlPath); 

            var link = new ShortLink()
            {
                Url= urlPath.UrlPath, 
                Id = urlPath.Id
            }; 

            var urlChunk = link.GetUrlChunk(); 

            return urlChunk; 
            // return urlPath;
        }

        [Route("~/r/{code}")]
        [HttpGet]
        public IActionResult TestRoute(string code){
            return Redirect("https://google.com");
        }

        
        [Route("~/r/{code}")]
        [HttpGet]
        public IActionResult TestOperators(string code){
            var newSimpleModel = new SimpleModel(); 


            var ss = newSimpleModel
            return Ok(); 

        }

        private void EncodeTest(ParamRequest urlPath)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(urlPath.UrlPath);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            Console.WriteLine(returnValue);
            Console.WriteLine("---------------------------");     
        }

    }

    public class ParamRequest
    {
        public int Id { get; set; }
        public string UrlPath { get; set; }
    }
}