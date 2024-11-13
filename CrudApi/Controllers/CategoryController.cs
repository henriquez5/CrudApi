using Microsoft.AspNetCore.Mvc;

namespace CrudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CrudDbContext _dbContext;

        public CategoryController(CrudDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("obter-todos")]
        public async Task<IActionResult> ObterTodasCategorias()
        {
            try
            {
                var result = _dbContext.Categories.ToList();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensagem = "Erro interno ao processar a solicitação.", detalhe = ex.Message });
            }
        }
    }
}
