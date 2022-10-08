using System;
using System.Security.Claims;

namespace Shopping.Extensions
{
    
        public static class ClaimsPrincipleExtension
        {
            public static string GetUserName(this ClaimsPrincipal user)
            {
                return user.FindFirst(ClaimTypes.Name)?.Value!;
            }

            public static Guid GetUserId(this ClaimsPrincipal user)
            {
                return Guid.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value!);
            }
        }
    }

