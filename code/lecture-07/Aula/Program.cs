using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula
{
   class UseGeneralizedHelpers
   {
      static void Main(string[] args)
      {
         var list = new List<string>(new[] {"a","bb","ccc","dddd"});
         Helpers.ForEach(list,Console.WriteLine);
         Console.WriteLine();

         Helpers.ForEach(Helpers.Filter(list,s=>s.Length>1),Console.WriteLine);
         
         Helpers.ForEach(Helpers.Map(list,s=>s.Length),Console.WriteLine);

         IEnumerable<string> ie = null;
         // Console.WriteLine(ie);

      }
   }
   class Helpers {
      
      public static void ForEach<T>(IEnumerable<T> elems, Action<T> action)
      {
         foreach (var e in elems) action(e); 
      }
      
      public static IEnumerable<T> Filter<T>(IEnumerable<T> elems, Predicate<T> condition)
      {
         foreach (var e in elems) if (condition(e)) yield return e; 
      }
      
      public static IEnumerable<TO> Map<TI,TO>(IEnumerable<TI> elems, Func<TI,TO> fun)
      {
         foreach (var e in elems) yield return fun(e); 
      }
      
      public static int SumAll(IEnumerable<int> elems)
      {
         var sum = 0;
         foreach (var e in elems) sum += e;
         return sum;
      }

      public static IEnumerable<int> Iterate(int size)
      {
         for (var i=0; i<size; i++) yield return i;
      }
   }
   
   
}