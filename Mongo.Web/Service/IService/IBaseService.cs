using Mango.Web.Models;
using Mongo.Web.Models;

namespace Mongo.Web.Service.IService
{
	public interface IBaseService
	{
		//The use of Task in this context indicates that the method is designed to be asynchronous.
		Task<ResponseDto?> SendAsync(RequestDto requestDto);
	}
}
