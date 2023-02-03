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

    [HttpGet("{clientId}")]
    public async Task<ActionResult<Client>> GetByIdAsync(int clientId)
    {
        Client? client = await _context.Clients.FindAsync(clientId);

        if (client == null)
            return NotFound();

        return client!;
    }

    [HttpPost]
    public async Task<ActionResult<Client>> PostAsync(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut]
    public async Task<ActionResult<Client>> PutAsync(Client client)
    {
        if (client == null)
            return NotFound();

        _context.Clients.Update(client);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Client>> DeleteAsync(int id)
    {
        Client? client = await _context.Clients.FindAsync(id);

        if (client == null)
            return NotFound();

        _context.Clients.Remove(client!);
        await _context.SaveChangesAsync();

        return Ok();
    }
}