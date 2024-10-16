﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiReportServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReportController : ControllerBase
    {
        private readonly IMemoryReportStorage memoryReportStorage;

        public ReportController(IMemoryReportStorage memoryReportStorage)
        {
            this.memoryReportStorage = memoryReportStorage;
        }

        // GET: api/<ReportsController>
        [HttpGet]
        public IEnumerable<Report> Get()
        {
            return memoryReportStorage.Get();
        }

        // GET api/<ReportsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReportsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReportsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReportsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
