using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrototypeDesignPattern.ConcretePrototype;

namespace PrototypeDesignPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public Task<IEnumerable<AdminPrototype>> GetAllAdmin()
        {
            //shallow copy
            var newAdmin = new AdminPrototype("Test", Enum.AdminLevel.Senior.ToString(), new AdmicFeaturePrototype(true, false));
            AdminPrototype admin2 = (AdminPrototype)newAdmin.Clone();
            admin2.AdminName = "Test2";
            admin2.AdminFeature.IsHaveDeleteTopic = true;
            
            //deep copy (with the copy constructor method)

            AdminPrototype admin3 = new AdminPrototype(admin2); //admin2 copied
            admin3.AdminFeature.IsHaveUpdateMember = false;
            admin3.AdminFeature.IsHaveDeleteTopic = false;

            var adminList = new List<AdminPrototype> { newAdmin, admin2, admin3 };
            return Task.FromResult(adminList.AsEnumerable());

        }
    }
}
