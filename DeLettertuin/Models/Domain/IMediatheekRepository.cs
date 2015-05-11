using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeLettertuin.Models.Domain
{
    public interface IMediatheekRepository
    {
        Mediatheek GetMediatheek();
        void SaveChanges();
    }
}