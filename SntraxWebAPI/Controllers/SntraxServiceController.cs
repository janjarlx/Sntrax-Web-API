using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SntraxWebAPI.Model;

namespace SntraxWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SntraxServiceController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _rootObjectCommon;
        private string _constrPrimary = string.Empty;
        private string _constrSecondary = string.Empty;
        public SntraxServiceController()
        {
        }
        public SntraxServiceController(IConfiguration rootObjectCommon, ILogger<SntraxServiceController> logger)
        {
            _logger = logger;
            _rootObjectCommon = rootObjectCommon;
            _constrPrimary = _rootObjectCommon.GetValue<string>("ConnectionStrings:ConstrPrimary");
            _constrSecondary = _rootObjectCommon.GetValue<string>("ConnectionStrings:ConstrSecondry");
        }

        [HttpPost]
        public List<IBaseData> IBaseGetDataByDN(List<IBaseData> list)
        {
            List<IBaseData> IBaseData = new List<IBaseData>();
            return IBaseData;
        }

        [HttpPost]
        public List<IBaseData> IBaseGetSingleData(List<IBaseData> list)
        {
            List<IBaseData> IBaseData = new List<IBaseData>();
            return IBaseData;
        }
        
        [HttpPost]
        public ShipToResult Validate_SSD_CPU_ShipTo(string RequestType, string RequestValue)
        {
            ShipToResult shipResult = new ShipToResult();
            return shipResult;
        }

        [HttpPost]
        public shipData get_EIMRma(string strSN)
        {
            shipData ship = new shipData();
            return ship;
        }

        [HttpPost]
        public List<SNv6> UploadSNv6(List<SNv6> SNv6List)
        {
            List<SNv6> _rtnList = new List<SNv6>();
            return _rtnList;
        }
    }
}
