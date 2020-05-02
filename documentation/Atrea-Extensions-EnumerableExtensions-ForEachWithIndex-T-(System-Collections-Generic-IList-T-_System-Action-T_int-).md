#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.ForEachWithIndex&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, System.Action&lt;T,int&gt;) Method
Iterate over a list, returning both the index and the item.  
```csharp
public static void ForEachWithIndex<T>(this System.Collections.Generic.IList<T> source, System.Action<T,int> action);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-ForEachWithIndex-T-(System-Collections-Generic-IList-T-_System-Action-T_int-)-T'></a>
`T`  
The source enumeration type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-ForEachWithIndex-T-(System-Collections-Generic-IList-T-_System-Action-T_int-)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#Atrea-Extensions-EnumerableExtensions-ForEachWithIndex-T-(System-Collections-Generic-IList-T-_System-Action-T_int-)-T 'Atrea.Extensions.EnumerableExtensions.ForEachWithIndex&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, System.Action&lt;T,int&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-ForEachWithIndex-T-(System-Collections-Generic-IList-T-_System-Action-T_int-)-action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](#Atrea-Extensions-EnumerableExtensions-ForEachWithIndex-T-(System-Collections-Generic-IList-T-_System-Action-T_int-)-T 'Atrea.Extensions.EnumerableExtensions.ForEachWithIndex&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, System.Action&lt;T,int&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
A function taking an item and its index  
  
