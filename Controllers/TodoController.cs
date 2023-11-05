    using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CustomerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public TodoController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        //menggunakan aSyncronous methode
        public async Task<ActionResult<IEnumerable<TodoModel>>> GetTodosAsync()
        {
            var client = _clientFactory.CreateClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            var response = await client.GetAsync("todos");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var todos = JsonConvert.DeserializeObject<IEnumerable<TodoModel>>(content);
                return Ok(todos);
            }

            return Problem(statusCode: (int)response.StatusCode, detail: response.ReasonPhrase);
        }

        
        [HttpGet("{id}")]
        //menggunakan Syncronous methode
        public ActionResult<TodoModel> GetTodo(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            var response = client.GetAsync($"todos/{id}").Result;

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                var todo = JsonConvert.DeserializeObject<TodoModel>(content);
                return Ok(todo);
            }

            return Problem(statusCode: (int)response.StatusCode, detail: response.ReasonPhrase);
        }

    }
}
