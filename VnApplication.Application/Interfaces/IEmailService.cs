using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VnApplication.Application.DTOs.Email;

namespace VnApplication.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
