using LsiTask.DB.Models;
using LsiTask.DB.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LsiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        private readonly ExportRepository exportRepository;

        //TODO Add Try catch
        public ExportController(ExportRepository exportRepository)
        {
            this.exportRepository = exportRepository;
        }

        [HttpGet("all")]
        public List<Export> GetAll()
        {
            var result = exportRepository.GetAll();
            return result;
        }

        [HttpGet("{id}")]
        public Export Get(int id)
        {
            return exportRepository.Get(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            exportRepository.Delete(id);
        }

        [HttpGet("{from},{to}")]
        public List<Export> GetByDateRange(DateTime from, DateTime to)
        {
            return exportRepository.GetDataByDate(from, to);
        }
    }
}
