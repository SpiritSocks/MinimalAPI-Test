using Microsoft.EntityFrameworkCore;
using StudentMinimalAPI.Models;

namespace StudentMinimalAPI {
    public class TodoDb : DbContext {

        public DbSet<Todo> Todos => Set<Todo>();
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }
        
    }
}
