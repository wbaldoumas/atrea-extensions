#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.AddRange&lt;T&gt;(System.Collections.Concurrent.ConcurrentBag&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;) Method
Extension to add multiple items at a time to a ConcurrentBag.  
```csharp
public static void AddRange<T>(this System.Collections.Concurrent.ConcurrentBag<T> source, System.Collections.Generic.IEnumerable<T> toAdd);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-AddRange-T-(System-Collections-Concurrent-ConcurrentBag-T-_System-Collections-Generic-IEnumerable-T-)-T'></a>
`T`  
The source enumeration type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-AddRange-T-(System-Collections-Concurrent-ConcurrentBag-T-_System-Collections-Generic-IEnumerable-T-)-source'></a>
`source` [System.Collections.Concurrent.ConcurrentBag&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentBag-1 'System.Collections.Concurrent.ConcurrentBag`1')[T](#Atrea-Extensions-EnumerableExtensions-AddRange-T-(System-Collections-Concurrent-ConcurrentBag-T-_System-Collections-Generic-IEnumerable-T-)-T 'Atrea.Extensions.EnumerableExtensions.AddRange&lt;T&gt;(System.Collections.Concurrent.ConcurrentBag&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentBag-1 'System.Collections.Concurrent.ConcurrentBag`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-AddRange-T-(System-Collections-Concurrent-ConcurrentBag-T-_System-Collections-Generic-IEnumerable-T-)-toAdd'></a>
`toAdd` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-AddRange-T-(System-Collections-Concurrent-ConcurrentBag-T-_System-Collections-Generic-IEnumerable-T-)-T 'Atrea.Extensions.EnumerableExtensions.AddRange&lt;T&gt;(System.Collections.Concurrent.ConcurrentBag&lt;T&gt;, System.Collections.Generic.IEnumerable&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An IEnumerable of elements to add  
  
