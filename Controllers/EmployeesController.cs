using EmployeeDirectory.Data;
using EmployeeDirectory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Controllers;

[ApiController]
[Route("api/[controller]")]   // → /api/employees
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext _db;
    public EmployeesController(AppDbContext db) => _db = db;

    // 取得全部員工：GET /api/employees
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        => await _db.Employees.AsNoTracking()
                              .OrderBy(e => e.EmployeeId)
                              .ToListAsync();

    // 取得單一員工：GET /api/employees/3
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Employee>> GetById(int id)
    {
        var emp = await _db.Employees.FindAsync(id);
        return emp is null ? NotFound() : emp;
    }

    // 更新員工：PUT /api/employees/3
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] Employee input)
    {
        var emp = await _db.Employees.FindAsync(id);
        if (emp is null) return NotFound();

        emp.Name  = input.Name;
        emp.Email = input.Email;
        emp.Role  = input.Role;

        await _db.SaveChangesAsync();
        return NoContent();   // 204，更新成功不回傳內容
    }
}