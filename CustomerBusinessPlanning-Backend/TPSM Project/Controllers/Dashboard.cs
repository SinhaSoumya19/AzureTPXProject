using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TPSM_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Dashboard : ControllerBase
    {
        // List for RetailersName
        List<string> retailersName = new List<string> { "Rohan", "Chandra", "Soumya", "Urmy", "Arjun" };

        [HttpGet("RetailersName")]
        public ActionResult RetailersName()
        {
            return Ok(retailersName);
        }

        // List for RetailersBanner
        List<string> retailersBanner = new List<string> { "Banner1", "Banner2", "Banner3", "Banner4", "Banner5" };

        [HttpGet("RetailersBanner")]
        public ActionResult RetailersBanner()
        {
            return Ok(retailersBanner);
        }

        // List for CategoryName
        List<string> categoryName = new List<string> { "Electronics", "Grocery", "Clothing", "Furniture", "Toys" };

        [HttpGet("CategoryName")]
        public ActionResult CategoryName()
        {
            return Ok(categoryName);
        }

        // List for PromotedGroupName
        List<string> promotedGroupName = new List<string> { "Group1", "Group2", "Group3", "Group4", "Group5" };

        [HttpGet("PromotedGroupName")]
        public ActionResult PromotedGroupName()
        {
            return Ok(promotedGroupName);
        }

        // List for PlanYear
        List<string> planYear = new List<string> { "2021", "2022", "2023", "2024", "2025" };

        [HttpGet("PlanYear")]
        public ActionResult PlanYear()
        {
            return Ok(planYear);
        }
    }
}
