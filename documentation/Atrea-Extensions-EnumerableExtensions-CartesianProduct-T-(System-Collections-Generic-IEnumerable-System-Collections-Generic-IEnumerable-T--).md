### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.CartesianProduct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.IEnumerable&lt;T&gt;&gt;) Method
Creates and returns the cartesian product of a list of sequences.  
```csharp
public static System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> CartesianProduct<T>(this System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> sequences);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-CartesianProduct-T-(System-Collections-Generic-IEnumerable-System-Collections-Generic-IEnumerable-T--)-T'></a>
`T`  
The source enumeration type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-CartesianProduct-T-(System-Collections-Generic-IEnumerable-System-Collections-Generic-IEnumerable-T--)-sequences'></a>
`sequences` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-CartesianProduct-T-(System-Collections-Generic-IEnumerable-System-Collections-Generic-IEnumerable-T--)-T 'Atrea.Extensions.EnumerableExtensions.CartesianProduct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.IEnumerable&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The sequences from which to create a cartesian product  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-CartesianProduct-T-(System-Collections-Generic-IEnumerable-System-Collections-Generic-IEnumerable-T--)-T 'Atrea.Extensions.EnumerableExtensions.CartesianProduct&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.IEnumerable&lt;T&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumerable of enumerables, representing the cartesian product of the given sequences  
