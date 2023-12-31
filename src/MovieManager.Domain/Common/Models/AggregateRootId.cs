using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Domain.Common.Models
{
    public abstract class AggregateRootId<TId> : EntityId<TId>
    {
        protected AggregateRootId(TId value) : base(value)
        {
        }
    }
}
