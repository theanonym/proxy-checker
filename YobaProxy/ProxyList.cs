using System;
using System.Text;
using System.Collections.Generic;
using System.Net;
using System.Linq;

namespace YobaProxy
{
   public class ProxyList : List<WebProxy>
   {
      public ProxyList Uniqued()
      {
         var result = new ProxyList();
         var urls = new List<Uri>();

         foreach(WebProxy proxy in this)
            if(!urls.Contains(proxy.Address))
            {
               urls.Add(proxy.Address);
               result.Add(proxy);
            }

         return result;
      }

      public void AddUnique(WebProxy item)
      {
         if(!this.Contains(item))
            base.Add(item);
      }

      public void AddRange(ProxyList collection)
      {
         this.Capacity += collection.Count;
         foreach(var proxy in collection)
            AddUnique(proxy);
      }

      public override string ToString()
      {
         var sb = new StringBuilder();

         foreach(var proxy in this)
            sb.AppendLine(string.Format("{0}:{1}", proxy.Address.Host, proxy.Address.Port));

         if(sb.Length != 0)
            sb.Remove(sb.Length - 1, 1);

         return sb.ToString();
      }
   }
}

