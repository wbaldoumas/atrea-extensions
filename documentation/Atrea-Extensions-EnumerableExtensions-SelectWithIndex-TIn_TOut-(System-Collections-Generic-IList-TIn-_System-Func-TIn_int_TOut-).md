#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.SelectWithIndex&lt;TIn,TOut&gt;(System.Collections.Generic.IList&lt;TIn&gt;, System.Func&lt;TIn,int,TOut&gt;) Method
Iterate over a list, projecting using both the index and the item, a la Select(...).  
```csharp
public static System.Collections.Generic.IEnumerable<TOut> SelectWithIndex<TIn,TOut>(this System.Collections.Generic.IList<TIn> source, System.Func<TIn,int,TOut> lambda);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-TIn'></a>
`TIn`  
The source enumeration type  
  
<a name='Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-TOut'></a>
`TOut`  
The projected type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TIn](#Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-TIn 'Atrea.Extensions.EnumerableExtensions.SelectWithIndex&lt;TIn,TOut&gt;(System.Collections.Generic.IList&lt;TIn&gt;, System.Func&lt;TIn,int,TOut&gt;).TIn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-lambda'></a>
`lambda` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TIn](#Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-TIn 'Atrea.Extensions.EnumerableExtensions.SelectWithIndex&lt;TIn,TOut&gt;(System.Collections.Generic.IList&lt;TIn&gt;, System.Func&lt;TIn,int,TOut&gt;).TIn')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TOut](#Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-TOut 'Atrea.Extensions.EnumerableExtensions.SelectWithIndex&lt;TIn,TOut&gt;(System.Collections.Generic.IList&lt;TIn&gt;, System.Func&lt;TIn,int,TOut&gt;).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')  
A function taking an item and its index  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOut](#Atrea-Extensions-EnumerableExtensions-SelectWithIndex-TIn_TOut-(System-Collections-Generic-IList-TIn-_System-Func-TIn_int_TOut-)-TOut 'Atrea.Extensions.EnumerableExtensions.SelectWithIndex&lt;TIn,TOut&gt;(System.Collections.Generic.IList&lt;TIn&gt;, System.Func&lt;TIn,int,TOut&gt;).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
