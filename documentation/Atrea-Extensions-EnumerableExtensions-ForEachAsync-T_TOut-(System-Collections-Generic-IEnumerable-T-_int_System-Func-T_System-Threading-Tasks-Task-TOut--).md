### [Atrea.Extensions](./Atrea-Extensions.md 'Atrea.Extensions').[EnumerableExtensions](./Atrea-Extensions-EnumerableExtensions.md 'Atrea.Extensions.EnumerableExtensions')
## EnumerableExtensions.ForEachAsync&lt;T,TOut&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&lt;TOut&gt;&gt;) Method
Process an enumeration in parallel, asynchronously, with a limit on simultaneous asynchronous tasks.  
```csharp
public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TOut>> ForEachAsync<T,TOut>(this System.Collections.Generic.IEnumerable<T> source, int threads, System.Func<T,System.Threading.Tasks.Task<TOut>> func);
```
#### Type parameters
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-T'></a>
`T`  
The source enumeration type  
  
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-TOut'></a>
`TOut`  
The result type  
  
#### Parameters
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-source'></a>
`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](#Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-T 'Atrea.Extensions.EnumerableExtensions.ForEachAsync&lt;T,TOut&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&lt;TOut&gt;&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
The source enumeration  
  
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-threads'></a>
`threads` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The degree of parallelism to use  
  
<a name='Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-func'></a>
`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](#Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-T 'Atrea.Extensions.EnumerableExtensions.ForEachAsync&lt;T,TOut&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&lt;TOut&gt;&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TOut](#Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-TOut 'Atrea.Extensions.EnumerableExtensions.ForEachAsync&lt;T,TOut&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&lt;TOut&gt;&gt;).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The asynchronous function to execute  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOut](#Atrea-Extensions-EnumerableExtensions-ForEachAsync-T_TOut-(System-Collections-Generic-IEnumerable-T-_int_System-Func-T_System-Threading-Tasks-Task-TOut--)-TOut 'Atrea.Extensions.EnumerableExtensions.ForEachAsync&lt;T,TOut&gt;(System.Collections.Generic.IEnumerable&lt;T&gt;, int, System.Func&lt;T,System.Threading.Tasks.Task&lt;TOut&gt;&gt;).TOut')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task to await for all processes to be complete  
