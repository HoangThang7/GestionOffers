using GestionOffers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionOffer.ClientApp.app.Repository
{
    public class UserRepository : BaseRepository<User>
    {
        
        
        public UserRepository() : base(Context.Create())
        {

        }

       
    }
}
