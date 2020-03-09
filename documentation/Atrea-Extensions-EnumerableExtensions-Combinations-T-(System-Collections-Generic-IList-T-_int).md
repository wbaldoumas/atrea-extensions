#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.Combinations&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int) Method
Creates and returns an enumeration of lists, which is every combinationSize size combination that  
can be created from the source enumeration.  
```csharp
public static System.Collections.Generic.IEnumerable<T[]> Combinations<T>(this System.Collections.Generic.IList<T> source, int combinationSize);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-Combinations-T-(System-Collections-Generic-IList-T-_int)-T'></a>
`T`  
The source enumeration type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-Combinations-T-(System-Collections-Generic-IList-T-_int)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#Atrea-Extensions-EnumerableExtensions-Combinations-T-(System-Collections-Generic-IList-T-_int)-T 'Atrea.Extensions.EnumerableExtensions.Combinations&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
  
  
<a name='Atrea-Extensions-EnumerableExtensions-Combinations-T-(System-Collections-Generic-IList-T-_int)-combinationSize'></a>
`combinationSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-Combinations-T-(System-Collections-Generic-IList-T-_int)-T 'Atrea.Extensions.EnumerableExtensions.Combinations&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumeration of lists, which is every combinationSize combination that can be created from the source enumeration  
