#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[DictionaryExtensions](./Atrea-Extensions-DictionaryExtensions.md 'Atrea.Extensions.DictionaryExtensions')
## DictionaryExtensions.ToMultiLookup&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;TValue&gt;, System.Func&lt;TValue,TKey&gt;) Method
Create a lookup by key that maps to multiple items per key.  
```csharp
public static System.Collections.Generic.Dictionary<TKey,System.Collections.Generic.List<TValue>> ToMultiLookup<TKey,TValue>(this System.Collections.Generic.IEnumerable<TValue> source, System.Func<TValue,TKey> keyFunction);
```
#### Type parameters
<a name='Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TKey'></a>
`TKey`  
The dictionary key type  
  
<a name='Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TValue'></a>
`TValue`  
The source item type  
  
#### Parameters
<a name='Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TValue](#Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TValue 'Atrea.Extensions.DictionaryExtensions.ToMultiLookup&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;TValue&gt;, System.Func&lt;TValue,TKey&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The source enumeration  
  
<a name='Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-keyFunction'></a>
`keyFunction` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](#Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TValue 'Atrea.Extensions.DictionaryExtensions.ToMultiLookup&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;TValue&gt;, System.Func&lt;TValue,TKey&gt;).TValue')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TKey](#Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TKey 'Atrea.Extensions.DictionaryExtensions.ToMultiLookup&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;TValue&gt;, System.Func&lt;TValue,TKey&gt;).TKey')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The function to map items to their keys  
  
#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[TKey](#Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TKey 'Atrea.Extensions.DictionaryExtensions.ToMultiLookup&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;TValue&gt;, System.Func&lt;TValue,TKey&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TValue](#Atrea-Extensions-DictionaryExtensions-ToMultiLookup-TKey_TValue-(System-Collections-Generic-IEnumerable-TValue-_System-Func-TValue_TKey-)-TValue 'Atrea.Extensions.DictionaryExtensions.ToMultiLookup&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;TValue&gt;, System.Func&lt;TValue,TKey&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
A dictionary mapping keys to an enumeration of source items with that key  
