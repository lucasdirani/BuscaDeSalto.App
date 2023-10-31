``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                                    Method |       Array |       Mean |     Error |    StdDev |     Median | Rank | Allocated |
|------------------------------------------ |------------ |-----------:|----------:|----------:|-----------:|-----:|----------:|
|         **MedirPerformanceFazerBuscaDeSalto** | **Int32[1000]** |  **41.304 ns** | **1.7730 ns** | **5.2277 ns** |  **39.826 ns** |    **6** |         **-** |
| MedirPerformanceFazerBuscaLinearIterativa | Int32[1000] | 334.865 ns | 6.3433 ns | 5.9336 ns | 332.502 ns |   10 |         - |
|         **MedirPerformanceFazerBuscaDeSalto** |  **Int32[100]** |  **17.442 ns** | **0.1960 ns** | **0.1738 ns** |  **17.373 ns** |    **3** |         **-** |
| MedirPerformanceFazerBuscaLinearIterativa |  Int32[100] |  42.891 ns | 0.3248 ns | 0.2879 ns |  42.887 ns |    7 |         - |
|         **MedirPerformanceFazerBuscaDeSalto** |   **Int32[10]** |   **7.071 ns** | **0.0900 ns** | **0.0752 ns** |   **7.068 ns** |    **2** |         **-** |
| MedirPerformanceFazerBuscaLinearIterativa |   Int32[10] |   4.634 ns | 0.1258 ns | 0.2066 ns |   4.596 ns |    1 |         - |
|         **MedirPerformanceFazerBuscaDeSalto** |  **Int32[200]** |  **19.815 ns** | **0.4019 ns** | **0.7647 ns** |  **19.556 ns** |    **4** |         **-** |
| MedirPerformanceFazerBuscaLinearIterativa |  Int32[200] |  75.081 ns | 1.4619 ns | 3.1470 ns |  74.162 ns |    8 |         - |
|         **MedirPerformanceFazerBuscaDeSalto** |  **Int32[300]** |  **29.594 ns** | **0.3501 ns** | **0.3275 ns** |  **29.533 ns** |    **5** |         **-** |
| MedirPerformanceFazerBuscaLinearIterativa |  Int32[300] | 104.339 ns | 0.4235 ns | 0.3307 ns | 104.388 ns |    9 |         - |
