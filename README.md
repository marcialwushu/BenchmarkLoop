# BenchmarkLoop

```
// AfterAll
// Benchmark Process 60956 has exited with code 0.

Mean = 5.071 ns, StdErr = 0.063 ns (1.24%), N = 94, StdDev = 0.611 ns
Min = 4.261 ns, Q1 = 4.639 ns, Median = 4.854 ns, Q3 = 5.415 ns, Max = 6.759 ns
IQR = 0.775 ns, LowerFence = 3.476 ns, UpperFence = 6.577 ns
ConfidenceInterval = [4.857 ns; 5.285 ns] (CI 99.9%), Margin = 0.214 ns (4.22% of Mean)
Skewness = 1.03, Kurtosis = 3, MValue = 2.25

// ** Remained 0 (0,0%) benchmark(s) to run. Estimated finish 2024-05-26 1:42 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Equilibrado)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\BenchmarkLoop.LoopBenchmark-report.csv
  BenchmarkDotNet.Artifacts\results\BenchmarkLoop.LoopBenchmark-report-github.md
  BenchmarkDotNet.Artifacts\results\BenchmarkLoop.LoopBenchmark-report.html

// * Detailed results *
LoopBenchmark.ForLoop: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 8.243 ns, StdErr = 0.109 ns (1.33%), N = 95, StdDev = 1.065 ns
Min = 6.926 ns, Q1 = 7.403 ns, Median = 7.887 ns, Q3 = 8.748 ns, Max = 10.758 ns
IQR = 1.345 ns, LowerFence = 5.386 ns, UpperFence = 10.766 ns
ConfidenceInterval = [7.872 ns; 8.614 ns] (CI 99.9%), Margin = 0.371 ns (4.50% of Mean)
Skewness = 0.98, Kurtosis = 2.76, MValue = 2.67
-------------------- Histogram --------------------
[ 6.620 ns ;  7.154 ns) | @@@@@
[ 7.154 ns ;  7.767 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 7.767 ns ;  8.401 ns) | @@@@@@@@@@@@@@@@@@@@@@@
[ 8.401 ns ;  9.126 ns) | @@@@@@@@@@@@@
[ 9.126 ns ;  9.588 ns) | @@@
[ 9.588 ns ;  9.988 ns) | @
[ 9.988 ns ; 10.601 ns) | @@@@@@@@@@@@@
[10.601 ns ; 11.065 ns) | @
---------------------------------------------------

LoopBenchmark.ParallelForLoop: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 3.787 us, StdErr = 0.016 us (0.41%), N = 14, StdDev = 0.059 us
Min = 3.661 us, Q1 = 3.764 us, Median = 3.795 us, Q3 = 3.823 us, Max = 3.876 us
IQR = 0.059 us, LowerFence = 3.675 us, UpperFence = 3.912 us
ConfidenceInterval = [3.720 us; 3.853 us] (CI 99.9%), Margin = 0.066 us (1.75% of Mean)
Skewness = -0.67, Kurtosis = 2.55, MValue = 2
-------------------- Histogram --------------------
[3.639 us ; 3.715 us) | @@
[3.715 us ; 3.908 us) | @@@@@@@@@@@@
---------------------------------------------------

LoopBenchmark.ParallelLINQ: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 7.678 us, StdErr = 0.027 us (0.36%), N = 15, StdDev = 0.106 us
Min = 7.494 us, Q1 = 7.612 us, Median = 7.655 us, Q3 = 7.740 us, Max = 7.899 us
IQR = 0.128 us, LowerFence = 7.420 us, UpperFence = 7.932 us
ConfidenceInterval = [7.565 us; 7.792 us] (CI 99.9%), Margin = 0.114 us (1.48% of Mean)
Skewness = 0.38, Kurtosis = 2.41, MValue = 2
-------------------- Histogram --------------------
[7.437 us ; 7.725 us) | @@@@@@@@@@@
[7.725 us ; 7.956 us) | @@@@
---------------------------------------------------

LoopBenchmark.TaskAsyncAwait: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 5.708 us, StdErr = 0.033 us (0.58%), N = 84, StdDev = 0.306 us
Min = 5.364 us, Q1 = 5.454 us, Median = 5.635 us, Q3 = 5.895 us, Max = 6.555 us
IQR = 0.441 us, LowerFence = 4.793 us, UpperFence = 6.557 us
ConfidenceInterval = [5.594 us; 5.821 us] (CI 99.9%), Margin = 0.114 us (1.99% of Mean)
Skewness = 0.82, Kurtosis = 2.63, MValue = 2.4
-------------------- Histogram --------------------
[5.356 us ; 5.539 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[5.539 us ; 5.724 us) | @@@@@@@@@@@@@@@
[5.724 us ; 5.927 us) | @@@@@@@@@@@@@@@
[5.927 us ; 6.073 us) | @@@@
[6.073 us ; 6.256 us) | @@@@@@@@@@@
[6.256 us ; 6.464 us) | @@@
[6.464 us ; 6.647 us) | @
---------------------------------------------------

LoopBenchmark.TaskChannels: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 6.351 us, StdErr = 0.152 us (2.39%), N = 99, StdDev = 1.510 us
Min = 4.782 us, Q1 = 5.170 us, Median = 5.644 us, Q3 = 7.373 us, Max = 10.631 us
IQR = 2.204 us, LowerFence = 1.864 us, UpperFence = 10.679 us
ConfidenceInterval = [5.836 us; 6.865 us] (CI 99.9%), Margin = 0.515 us (8.11% of Mean)
Skewness = 0.96, Kurtosis = 2.76, MValue = 2.45
-------------------- Histogram --------------------
[4.771 us ;  5.628 us) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[5.628 us ;  6.407 us) | @@@@@@@@@@@@@
[6.407 us ;  6.793 us) | @@
[6.793 us ;  7.650 us) | @@@@@@@@@@@@@
[7.650 us ;  8.633 us) | @@@@@@@@@@@
[8.633 us ;  9.729 us) | @@@@@@@@
[9.729 us ; 10.650 us) | @@@
---------------------------------------------------

LoopBenchmark.CollectionMarshalAsSpan: DefaultJob
Runtime = .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 5.071 ns, StdErr = 0.063 ns (1.24%), N = 94, StdDev = 0.611 ns
Min = 4.261 ns, Q1 = 4.639 ns, Median = 4.854 ns, Q3 = 5.415 ns, Max = 6.759 ns
IQR = 0.775 ns, LowerFence = 3.476 ns, UpperFence = 6.577 ns
ConfidenceInterval = [4.857 ns; 5.285 ns] (CI 99.9%), Margin = 0.214 ns (4.22% of Mean)
Skewness = 1.03, Kurtosis = 3, MValue = 2.25
-------------------- Histogram --------------------
[4.231 ns ; 4.578 ns) | @@@@@@@@@@@@@@@
[4.578 ns ; 4.931 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[4.931 ns ; 5.294 ns) | @@@@@@@@@@@@
[5.294 ns ; 5.615 ns) | @@@@@@@@@
[5.615 ns ; 5.956 ns) | @@@@
[5.956 ns ; 6.309 ns) | @@@@@@@@@
[6.309 ns ; 6.637 ns) | @@@@
[6.637 ns ; 6.936 ns) | @
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3447/23H2/2023Update/SunValley3)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.200
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT AVX2


| Method                  | Mean         | Error       | StdDev        | Median       |
|------------------------ |-------------:|------------:|--------------:|-------------:|
| ForLoop                 |     8.243 ns |   0.3712 ns |     1.0651 ns |     7.887 ns |
| ParallelForLoop         | 3,786.503 ns |  66.0837 ns |    58.5814 ns | 3,795.435 ns |
| ParallelLINQ            | 7,678.299 ns | 113.5503 ns |   106.2150 ns | 7,655.312 ns |
| TaskAsyncAwait          | 5,707.652 ns | 113.7918 ns |   305.6942 ns | 5,634.702 ns |
| TaskChannels            | 6,350.507 ns | 514.9915 ns | 1,510.3810 ns | 5,644.481 ns |
| CollectionMarshalAsSpan |     5.071 ns |   0.2140 ns |     0.6107 ns |     4.854 ns |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger

// * Hints *
Outliers
  LoopBenchmark.ForLoop: Default                 -> 5 outliers were removed (13.43 ns..14.47 ns)
  LoopBenchmark.ParallelForLoop: Default         -> 1 outlier  was  removed, 2 outliers were detected (3.66 us, 3.95 us)
  LoopBenchmark.TaskAsyncAwait: Default          -> 1 outlier  was  removed (7.03 us)
  LoopBenchmark.TaskChannels: Default            -> 1 outlier  was  removed (10.94 us)
  LoopBenchmark.CollectionMarshalAsSpan: Default -> 6 outliers were removed (8.46 ns..11.03 ns)

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  Median : Value separating the higher half of all measurements (50th percentile)
  1 ns   : 1 Nanosecond (0.000000001 sec)

// ***** BenchmarkRunner: End *****
Run time: 00:05:43 (343.09 sec), executed benchmarks: 6

Global total time: 00:06:04 (364.28 sec), executed benchmarks: 6
// * Artifacts cleanup *
Artifacts cleanup is finished
```
