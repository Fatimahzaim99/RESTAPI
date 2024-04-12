using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapiCDN.Models;

namespace webapiCDN.Controllers
{
    public class FreelancerRepository
    {
        private readonly TodoContext _context;

        public FreelancerRepository(TodoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Freelancer>> GetAllFreelancers()
        {
            return await _context.Freelancers.ToListAsync();
        }

        public async Task<Freelancer> GetFreelancerById(int id)
        {
            return await _context.Freelancers.FindAsync(id);
        }

        public async Task AddFreelancer(Freelancer freelancer)
        {
            _context.Freelancers.Add(freelancer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFreelancer(Freelancer freelancer)
        {
            _context.Entry(freelancer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFreelancer(int id)
        {
            var user = await _context.Freelancers.FindAsync(id);
            _context.Freelancers.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
