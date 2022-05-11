using Orco.Web.Models;
using Orco.Web.Models.DTOs;
using System;
using System.Threading.Tasks;

namespace Orco.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDTO responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
