### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[StringExtensions](./Atrea-Extensions-StringExtensions.md 'Atrea.Extensions.StringExtensions')
## StringExtensions.ReplaceWord(string, string, string) Method
In contrast to string.Replace, this will only replace whole words. For example:  
Using this method on the string "test testing test" and passing "test" as oldValue  
and "text", this will return the string "text testing text", whereas  
string.Replace would return "text texting text."  
```csharp
public static string ReplaceWord(this string source, string oldValue, string newValue);
```
#### Parameters
<a name='Atrea-Extensions-StringExtensions-ReplaceWord(string_string_string)-source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The source string to replace words in  
  
<a name='Atrea-Extensions-StringExtensions-ReplaceWord(string_string_string)-oldValue'></a>
`oldValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The word in the string we want to replace  
  
<a name='Atrea-Extensions-StringExtensions-ReplaceWord(string_string_string)-newValue'></a>
`newValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The replacement word to use  
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
