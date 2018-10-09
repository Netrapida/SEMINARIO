using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_IPG.Data
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string Nome { get; set; }
        [PersonalData]
        public DateTime Data_Nascimento { get; set; }   
    }
}


// ver aqui 
// [PersonalData] <- novo RGPD
// Deleted when the Areas/Identity/Pages/Account/Manage/DeletePersonalData.cshtml Razor Page calls UserManager.Delete 
// https://docs.microsoft.com/en-us/aspnet/core/security/authentication/add-user-data?view=aspnetcore-2.1&tabs=visual-studio