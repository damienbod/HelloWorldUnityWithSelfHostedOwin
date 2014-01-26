﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using HelloWorldUnityWithSelfHostedOwin.Business;
using HelloWorldUnityWithSelfHostedOwin.Filters;

namespace HelloWorldUnityWithSelfHostedOwin.Controllers
{
    [MyCustomFilter]
    [RoutePrefix("api")] 
    public class ValuesController : ApiController
    {
        private readonly IBusinessClass _businessClass;
        private readonly IBusinessClass2 _businessClass2;
        public ValuesController(IBusinessClass businessClass, IBusinessClass2 businessClass2)
        {
            _businessClass = businessClass;
            _businessClass2 = businessClass2;
        }

        // GET api/values 
        [Route("values")]
        [AcceptVerbs("GET")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", _businessClass.Hello()};
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }

    } 
}
