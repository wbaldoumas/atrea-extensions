#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[DictionaryExtensions](./Atrea-Extensions-DictionaryExtensions.md 'Atrea.Extensions.DictionaryExtensions')
## DictionaryExtensions.ToReadableString&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;&gt;) Method
Creates a readable string value from a given dictionary.  
```csharp
public static string ToReadableString<TKey,TValue>(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>> source);
```
#### Type parameters
<a name='Atrea-Extensions-DictionaryExtensions-ToReadableString-TKey_TValue-(System-Collections-Generic-IEnumerable-System-Collections-Generic-KeyValuePair-TKey_TValue--)-TKey'></a>
`TKey`  
The dictionary key type  
  
<a name='Atrea-Extensions-DictionaryExtensions-ToReadableString-TKey_TValue-(System-Collections-Generic-IEnumerable-System-Collections-Generic-KeyValuePair-TKey_TValue--)-TValue'></a>
`TValue`  
The dictionary value type  
  
#### Parameters
<a name='Atrea-Extensions-DictionaryExtensions-ToReadableString-TKey_TValue-(System-Collections-Generic-IEnumerable-System-Collections-Generic-KeyValuePair-TKey_TValue--)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Collections.Generic.KeyValuePair&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TKey](#Atrea-Extensions-DictionaryExtensions-ToReadableString-TKey_TValue-(System-Collections-Generic-IEnumerable-System-Collections-Generic-KeyValuePair-TKey_TValue--)-TKey 'Atrea.Extensions.DictionaryExtensions.ToReadableString&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[TValue](#Atrea-Extensions-DictionaryExtensions-ToReadableString-TKey_TValue-(System-Collections-Generic-IEnumerable-System-Collections-Generic-KeyValuePair-TKey_TValue--)-TValue 'Atrea.Extensions.DictionaryExtensions.ToReadableString&lt;TKey,TValue&gt;(System.Collections.Generic.IEnumerable&lt;System.Collections.Generic.KeyValuePair&lt;TKey,TValue&gt;&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2 'System.Collections.Generic.KeyValuePair`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The dictionary being parsed into a string  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string parsed from the dictionary key => value pairs  
