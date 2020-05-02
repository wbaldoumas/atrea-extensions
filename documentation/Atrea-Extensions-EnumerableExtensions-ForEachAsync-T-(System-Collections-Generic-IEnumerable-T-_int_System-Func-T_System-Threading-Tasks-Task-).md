### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.ForEachAsync&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&gt;) Method
Process an enumeration in parallel, asynchronously, with a limit on simultaneous asynchronous tasks.  
```csharp
public static System.Threading.Tasks.Task ForEachAsync<T>(this System.Collections.Generic.IEnumerable<T> source, int threads, System.Func<T,System.Threading.Tasks.Task> action);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-)-T'></a>
`T`  
The source enumeration type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-ForEachAsync-T-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-)-T 'Atrea.Extensions.EnumerableExtensions.ForEachAsync&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-)-threads'></a>
`threads` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The degree of parallelism to use  
  
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-)-action'></a>
`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](#Atrea-Extensions-EnumerableExtensions-ForEachAsync-T-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-)-T 'Atrea.Extensions.EnumerableExtensions.ForEachAsync&lt;T&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The asynchronous action to execute  
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task to await for all processes to be complete  
