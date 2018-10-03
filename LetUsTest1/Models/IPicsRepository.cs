using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsTest1.Models
{
    public interface IPicsRepository
    {
        IEnumerable<Pics> GetPics();

        Pics GetPicById(int picId);

    }
}
