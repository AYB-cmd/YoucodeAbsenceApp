﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GADataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
 /*    [HttpGet]
     public UserModel GetById()
     {
         string userId = RequestContext.Principal.Identity.GetUserId();

         UserData data = new UserData();

         return data.GetUserById(userId).First();
     }*/

    }
}
