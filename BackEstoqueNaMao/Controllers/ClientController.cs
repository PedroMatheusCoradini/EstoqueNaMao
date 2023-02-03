using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEstoqueNaMao.DataContext;
using BackEstoqueNaMao.Models;

namespace BackEstoqueNaMao.Controllers;

[ApiController]
[Route("api/client")]
public class ClientController : ControllerBase
{
    private readonly Context _context;

    public ClientController(Context context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Client>> PostAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();

        return Ok();
    }
}