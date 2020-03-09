#### [Atrea.Extensions](./index.md 'index')
### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[StringExtensions](./Atrea-Extensions-StringExtensions.md 'Atrea.Extensions.StringExtensions')
## StringExtensions.ContainsNumericText(string) Method
Checks whether the source string contains numeric text.  

Example strings that would return true:  

    "One way to shop"  
    "A billion things to do"  
    "There are 4 things"  
    "There are actually 3.5 things"  
```csharp
public static bool ContainsNumericText(this string source);
```
#### Parameters
<a name='Atrea-Extensions-StringExtensions-ContainsNumericText(string)-source'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The source string to check for numeric text  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether the string contains numeric text  
