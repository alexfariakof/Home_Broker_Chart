using Business.Interfaces;
using Domain.Charts.Agreggates;
using Domain.Charts.ValueObject;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ChartHomeBrokerController : ControllerBase
{
    private readonly ILogger<ChartHomeBrokerController> _logger;
    private IHomeBrokerBusiness _homeBrokerBusiness;
    public ChartHomeBrokerController(ILogger<ChartHomeBrokerController> logger, IHomeBrokerBusiness homeBrokerBusiness)
    {
        _logger = logger;
        _homeBrokerBusiness = homeBrokerBusiness;
    }

    [HttpGet]
    public List<MagazineLuizaHistoryPrice> Get([FromQuery] DateTime StartDate, [FromQuery] DateTime EndDate)
    {
        var period = new Period(StartDate, EndDate);
        return _homeBrokerBusiness.GetHistoryData(period);        
    }

    [HttpGet("GetSMA")]
    public SMA GetSMA()
    {
        return _homeBrokerBusiness.GetSMA();
    }

    [HttpGet("GetEMA")]
    public EMA GetEMA()
    {
        var ema = new EMA();
        for (int i=1;i<=50;i++)
        {
            double randomValue = new Random().NextDouble() * (1000 - 1) + 1;
            ema.Values.Add((decimal)randomValue);

        }
        return ema;
    }
}