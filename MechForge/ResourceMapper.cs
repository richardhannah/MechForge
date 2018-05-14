using Newtonsoft.Json;

namespace MechForge
{
    public class ResourceMapper<T>
    {
        public T MapResource(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}