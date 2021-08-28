using System;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using SharedAssemblies2.Models;

namespace basicblazorexample.API
{
    public class NameMethods
    {

        public static async Task<bool> AddName(Name name)
        {
            try
            {
                var repstring = await "https://localhost:5001/names"
                    .PostUrlEncodedAsync(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
            return true;
        }
    }
}