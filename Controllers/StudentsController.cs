using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly ILogger<StudentsController> _logger;
    private readonly SandboxContext _context;

    public StudentsController(ILogger<StudentsController> logger, SandboxContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    [EnableQuery]
    public IQueryable<Student> Get()
    {
        return _context.Students;
    }
}
