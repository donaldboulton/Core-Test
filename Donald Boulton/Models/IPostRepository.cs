using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mansbooks.Models.Repository
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
    }
}
