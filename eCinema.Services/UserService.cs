using Model = eCinema.Model;
using eCinema.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eCinema.Services.Interfaces;

namespace eCinema.Services
{
    public class UserService : IUserService
    {
        private readonly ECinemaContext _context;
        private readonly IMapper _mapper;

        public UserService(ECinemaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.User> GetAllUsers()
        {
            List<Model.User> list = new List<Model.User>();

            var result = _context.Users.ToList();

            return _mapper.Map<List<Model.User>>(result);

        }  
    }
}
