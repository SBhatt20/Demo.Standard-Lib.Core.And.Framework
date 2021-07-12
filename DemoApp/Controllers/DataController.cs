using DemoLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class DataController : ControllerBase
  {
    string Summary;

    private readonly ILogger<DataController> _logger;

    public DataController(ILogger<DataController> logger, IStorageManager storageManager)
    {
      this.Summary = storageManager.MySettings();

      _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
      return this.Summary;

    }
  }
}
