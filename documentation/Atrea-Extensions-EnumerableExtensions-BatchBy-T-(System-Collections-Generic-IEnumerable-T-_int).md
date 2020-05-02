### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.BatchBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int) Method
Batch items in an enumerable by batchSize.  Does not fully load the source enumeration  
while making batches. Arrays are returned to optimize memory usage.  Implemented as  
iterator for just-in-time creation.  
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> BatchBy<T>(this System.Collections.Generic.IEnumerable<T> source, int batchSize);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-BatchBy-T-(System-Collections-Generic-IEnumerable-T-_int)-T'></a>
`T`  
The source enumeration type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-BatchBy-T-(System-Collections-Generic-IEnumerable-T-_int)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-BatchBy-T-(System-Collections-Generic-IEnumerable-T-_int)-T 'Atrea.Extensions.EnumerableExtensions.BatchBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-BatchBy-T-(System-Collections-Generic-IEnumerable-T-_int)-batchSize'></a>
`batchSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Number of elements by which to group items  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-BatchBy-T-(System-Collections-Generic-IEnumerable-T-_int)-T 'Atrea.Extensions.EnumerableExtensions.BatchBy&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An IEnumerable of lists  
