using Mango.Web.CouponAPI.Models;
using Mongo.Web.Models;

namespace Mongo.Web.Service.IService
{
	public interface IBaseService
	{
		Task<ResponseDto?> SendAsync(RequestDto requestDto);
	}
}
