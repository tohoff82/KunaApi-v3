using System.Linq;
using System.Text;

namespace KunaApi.Extensions
{
    public static class Extensions
    {
        public static string Separate(this string[] data, string separator)
        {
            var sb = new StringBuilder(data.First());

            if (data.Length > 1)
            {
                for (int i = 1; i < data.Length; i++)
                {
                    sb.AppendFormat("{0}{1}", separator, data[i]);
                }
            }

            return sb.ToString();
        }
    }
}
