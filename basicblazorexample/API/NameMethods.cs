using System;
using System.Net.Http.Json;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;
using SharedAssemblies2.Models;

namespace basicblazorexample.API
{
    public class NameMethods
    {

        public static async Task<bool> RemoveName(string guid)
        {
            try
            {
                var repstring = await "https://localhost:5001/removenames"
                    .PostUrlEncodedAsync(new {Guid = guid});
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
            return true;
        }
        
        public static async Task<bool> AddName(Name name)
        {
            try
            {
                var repstring = await "https://localhost:5001/namesadd"
                    .PostUrlEncodedAsync(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
            return true;
        }

        public static async Task<GuidInstance[]> GetNameInstances(int page, int interval)
        {
            try
            {
                var repstring = await "https://localhost:5001/fetchnames"
                    .PostJsonAsync(JsonConvert.SerializeObject(new Paging() {Page = page, Interval = interval}));
                
                return JsonConvert.DeserializeObject<GuidInstance[]>(await repstring.ResponseMessage.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new GuidInstance[]{};
            }
        }
    }
}