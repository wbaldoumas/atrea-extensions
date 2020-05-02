#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.Combinations(int, int) Method
Enumerate all possible combinationSize size combinations of an [0, 1, ..., maxIndex-1] array  
in lexicographic order (first [0, 1, ..., combinationSize-1]).  
```csharp
private static System.Collections.Generic.IEnumerable<int[]> Combinations(int combinationSize, int maxIndex);
```
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-Combinations(int_int)-combinationSize'></a>
`combinationSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
  
<a name='Atrea-Extensions-EnumerableExtensions-Combinations(int_int)-maxIndex'></a>
`maxIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
  
#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
An enumeration of all possible combinationSize combinations of the specified array  
