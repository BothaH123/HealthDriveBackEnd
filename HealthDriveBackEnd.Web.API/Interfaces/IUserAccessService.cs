using HealthDriveBackEnd.Web.API.Models;
using System.Collections.Generic;

namespace HealthDriveBackEnd.Web.API.Interfaces
{
    public interface IUserAccessService
    {
        User Authenticate(string username, string password);
    }
}
