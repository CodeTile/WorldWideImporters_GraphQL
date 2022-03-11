using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WWI.Data.Context
{
    public partial class WideworldimportersContext
    {
        public WideworldimportersContext(DbContextOptions<WideworldimportersContext> options, IConfiguration configuration)
           : base(options)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:Target"]);
            }
        }
    }
}