using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace YobaProxy
{
   public static class ProxyParser
   {
      public static async Task<ProxyList> ParseUsProxyAsync()
      {
         ProxyList proxies = new ProxyList();

         string content = await GetPageAsync("http://www.us-proxy.org/");

         var regex = new Regex(@"<td>(\d+\.\d+\.\d+\.\d+)</td><td>(\d+)</td>");
         foreach(Match match in regex.Matches(content))
            proxies.Add(new WebProxy(match.Groups[1].Value, int.Parse(match.Groups[2].Value)));

         return proxies;
      }

      public static async Task<ProxyList> ParseHideMyIpAsync()
      {
         ProxyList proxies = new ProxyList();

         string content = await GetPageAsync("http://www.hide-my-ip.com/proxylist.shtml");

         var regex = new Regex(@"{""i"":""(\d+\.\d+\.\d+\.\d+)"",""p"":""(\d+)""");
         foreach(Match match in regex.Matches(content))
            proxies.Add(new WebProxy(match.Groups[1].Value, int.Parse(match.Groups[2].Value)));

         return proxies;
      }

      public static async Task<ProxyList> ParseFreeProxyListAsync()
      {
         ProxyList proxies = new ProxyList();

         string content = await GetPageAsync("http://free-proxy-list.net/");

         var regex = new Regex(@"<td>(\d+\.\d+\.\d+\.\d+)</td><td>(\d+)</td>");
         foreach(Match match in regex.Matches(content))
            proxies.Add(new WebProxy(match.Groups[1].Value, int.Parse(match.Groups[2].Value)));

         return proxies;
      }

      public static async Task<ProxyList> ParseAllAsync()
      {
         var proxies = new ProxyList();

         var tasks = new List<Task<ProxyList>>();
         tasks.Add(ParseUsProxyAsync());
         tasks.Add(ParseFreeProxyListAsync());


         foreach(var task in tasks)
            proxies.AddRange(await task);

         return proxies;
      }

      public static ProxyList ParseString(string content)
      {
         var proxies = new ProxyList();

         var regex = new Regex(@"(\d+\.\d+\.\d+\.\d+)(?:\:|\s+)(\d+)");
         foreach(Match match in regex.Matches(content))
            proxies.Add(new WebProxy(match.Groups[1].Value, int.Parse(match.Groups[2].Value)));

         return proxies;
      }

      public static ProxyList ReadFile(string path)
      {
         return ParseString(File.ReadAllText(path));
      }

      public static void WriteFile(string filePath, ProxyList proxies)
      {
         var output = new StreamWriter(filePath);
         foreach(var proxy in proxies)
            output.WriteLine("{0}", proxy.Address);
      }

      private static async Task<string> GetPageAsync(string url)
      {
         var http = new HttpClient() { Timeout = TimeSpan.FromSeconds(20) };
         http.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:49.0) Gecko/20100101 Firefox/49.0");

         Console.WriteLine("Get {0}", url);
         var responce = await http.GetAsync(url);
         return await responce.Content.ReadAsStringAsync();
      }
   }
}
