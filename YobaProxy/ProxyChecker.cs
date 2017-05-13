using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace YobaProxy
{
   public class ProxyChecker
   {
      public event EventHandler<WebProxy> ProxyChecked;
      public event EventHandler<WebProxy> ProxyCheckedSuccessfull;

      public async Task CheckAsync(ProxyList proxies, int connections, TimeSpan timeout)
      {
         var semaphore = new SemaphoreSlim(connections);

         var tasks = proxies.Select(async proxy => {
            await semaphore.WaitAsync();
            try
            {
               var handler = new HttpClientHandler() {
                  Proxy = proxy,
                  UseProxy = true
               };

               var http = new HttpClient(handler) { Timeout = timeout };
               http.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:49.0) Gecko/20100101 Firefox/49.0");

               Console.WriteLine("Check {0}", proxy.Address);
               HttpResponseMessage responce = await http.GetAsync("http://google.com");

               Console.WriteLine("Status {0}: {1}", proxy.Address, responce.StatusCode);
               if(responce.IsSuccessStatusCode)
                  ProxyCheckedSuccessfull(this, proxy);
            }
            catch(Exception e)
            {
               Console.WriteLine(e.Message);
            }
            finally
            {
               ProxyChecked(this, proxy);
               semaphore.Release();
            }
         });

         await Task.WhenAll(tasks);
      }
   }
}
