using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Services
{
    public interface ITokenService
    {
        string Generate(string username);
    }
}
