
namespace SntraxWebAPI.Model
{
    public class IBaseData
    {
        public string GapInd { get; set; } 
        public string SN { get; set; }
        public string StockingID { get; set; }
        public string ShipDate { get; set; }
        public string MaterialID { get; set; }
        public string DN { get; set; }
        public string ShipToID { get; set; }
        public string ShipToCountry { get; set; }
        public string SoldToID { get; set; }
        public string SalesOrg { get; set; }
        public string DistChannel { get; set; }
        public string OpCode { get; set; }
        public string SOType { get; set; }
        public int? ShipId { get; set; }
        public string LineItem { get; set; }
        public string SalesOrder { get; set; }

        public List<IBaseChild> IBaseChildList { get; set; }

    }

    public class IBaseChild
    {
        public string CompSN { get; set; }
        public string StockingID { get; set; }
        public List<IBaseGrandChild> IBaseGrandChildList { get; set; }
    }


    public class IBaseGrandChild
    {
        public string CompSN { get; set; }
        public string StockingID { get; set; }
    }


}
