### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[DictionaryExtensions](./Atrea-Extensions-DictionaryExtensions.md 'Atrea.Extensions.DictionaryExtensions')
## DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;) Method
Merge the new dictionary into the source directory, overwriting on duplicate keys.  
If the new dictionary is null or empty, the first dictionary is returned unmodified.  
If the source dictionary is null or empty, the new dictionary is returned unmodified.  
```csharp
public static System.Collections.Generic.IDictionary<TKey,TValue> Merge<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> source, System.Collections.Generic.IDictionary<TKey,TValue> newDictionary);
```
#### Type parameters
<a name='Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TKey'></a>
`TKey`  
The dictionary key type  
  
<a name='Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TValue'></a>
`TValue`  
The dictionary value type  
  
#### Parameters
<a name='Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TKey 'Atrea.Extensions.DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TValue 'Atrea.Extensions.DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The dictionary of old values  
  
<a name='Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-newDictionary'></a>
`newDictionary` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TKey 'Atrea.Extensions.DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TValue 'Atrea.Extensions.DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The dictionary with new values  
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TKey 'Atrea.Extensions.DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#Atrea-Extensions-DictionaryExtensions-Merge-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_System-Collections-Generic-IDictionary-TKey_TValue-)-TValue 'Atrea.Extensions.DictionaryExtensions.Merge&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A merged dictionary whose keys are a union of the keys of the two dictionaries, and  
whose values are drawn from the second dictionary if they are present, otherwise the first.  
