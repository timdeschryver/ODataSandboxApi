using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly SandboxContext _context;

    public StudentsController(SandboxContext context)
    {
        _context = context;
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<IQueryable<Student>> Get()
    {
        return Ok(_context.Students);
    }
}
