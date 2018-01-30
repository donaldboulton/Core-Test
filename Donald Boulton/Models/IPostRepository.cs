using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Donald_Boulton.Models.Repository
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
    }
}
