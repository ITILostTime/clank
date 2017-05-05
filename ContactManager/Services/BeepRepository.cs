using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManager.Services
{
    public class BeepRepository
    {
        private const string CacheKey = "BeepStore";
        public BeepRepository()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var beeps = new Beep[]
                    {
                        new Beep
                        {
                            Name = "Miller"
                        }  
                    };
                    ctx.Cache[CacheKey] = beeps;
                }
            }
        }
        public Beep[] GetAllBeeps()
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                return (Beep[])ctx.Cache[CacheKey];
            }

            return new Beep[]
            {
                new Beep
                {
                    Name = "Placeholder"
                }
            };
        }
        public bool SaveBeep(Beep beep)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((Beep[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(beep);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            return false;
        }
    }
}