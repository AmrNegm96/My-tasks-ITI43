``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2728/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.200
  [Host]     : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2


```
|          Method |       Mean |    Error |    StdDev |
|---------------- |-----------:|---------:|----------:|
|      ExecuteSeq | 2,684.8 ms | 53.52 ms | 103.12 ms |
| ExecuteParallel |   850.4 ms | 16.50 ms |  15.43 ms |
