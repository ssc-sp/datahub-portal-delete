﻿using Microsoft.AspNetCore.Authentication;
using NRCan.Datahub.Portal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NRCan.Datahub.Portal.RoleManagement
{

    //https://stackoverflow.com/questions/58483620/net-core-3-0-claimstransformation
    public class RoleClaimTransformer : IClaimsTransformation
    {
        private readonly ServiceAuthManager serviceAuthManager;

        public RoleClaimTransformer(ServiceAuthManager serviceAuthManager)
        {
            this.serviceAuthManager = serviceAuthManager;
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var userName = principal.Identity.Name;
            var allProjects = await serviceAuthManager.GetAllProjects();
            var authorizedProjects = await serviceAuthManager.GetUserAuthorizations(userName);

            foreach (var project in allProjects)
            {
                if (await serviceAuthManager.IsProjectAdmin(userName, project))
                {
                    ((ClaimsIdentity)principal.Identity).AddClaim(new Claim(ClaimTypes.Role, $"{project}-admin"));
                }
            }
            foreach (var project in authorizedProjects)
            {
                ((ClaimsIdentity)principal.Identity).AddClaim(new Claim(ClaimTypes.Role, project.Project_Acronym_CD));
            }
            return principal;
        }

    }
}
