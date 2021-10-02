using System;
using System.Collections.Generic;
using System.Text;

namespace VnApplication.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
