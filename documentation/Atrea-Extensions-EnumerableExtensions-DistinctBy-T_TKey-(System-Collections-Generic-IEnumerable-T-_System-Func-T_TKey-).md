#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.DistinctBy&lt;T,TKey&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TKey&gt;) Method
Iterate over a enumeration, filtering out distinct items by property.  
```csharp
public static System.Collections.Generic.IEnumerable<T> DistinctBy<T,TKey>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,TKey> selector);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-T'></a>
`T`  
The source enumeration type  
  
<a name='Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-TKey'></a>
`TKey`  
The selector type to filter on  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-T 'Atrea.Extensions.EnumerableExtensions.DistinctBy&lt;T,TKey&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TKey&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-selector'></a>
`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](#Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-T 'Atrea.Extensions.EnumerableExtensions.DistinctBy&lt;T,TKey&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TKey&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](#Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-TKey 'Atrea.Extensions.EnumerableExtensions.DistinctBy&lt;T,TKey&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The selector to filter on  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-DistinctBy-T_TKey-(System-Collections-Generic-IEnumerable-T-_System-Func-T_TKey-)-T 'Atrea.Extensions.EnumerableExtensions.DistinctBy&lt;T,TKey&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, System.Func&lt;T,TKey&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An IEnumerable of items that are distinct by the selector property  
