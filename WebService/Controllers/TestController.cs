using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebService.Controllers
{
	[EnableCors(origins: "http://localhost:29438", headers: "*", methods: "*")]
	public class TestController : ApiController
	{
		// GET: api/Test
		public HttpResponseMessage Get()
		{
			return new HttpResponseMessage
			{
				Content = new StringContent("GET: Test message")
			};
		}

		// POST: api/Test
		public HttpResponseMessage Post([FromBody]string value)
		{
			return new HttpResponseMessage
			{
				Content = new StringContent("POST: Test message")
			};
		}

		// PUT: api/Test
		public HttpResponseMessage Put([FromBody]string value)
		{
			return new HttpResponseMessage
			{
				Content = new StringContent("PUT: Test message")
			};
		}
	}
}
