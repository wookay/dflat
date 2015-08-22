# C# test

Linux, OSX: [![Build Status](https://api.travis-ci.org/wookay/dflat.svg?branch=master)](https://travis-ci.org/wookay/dflat)

```shell
~/work/dflat master$ cd Test/ && mono ./testrunner/NUnit.Runners.2.6.4/tools/nunit-console.exe -labels -nologo ./Test/bin/Release/Test.exe
WARNING: The runtime version supported by this application is unavailable.
Using default runtime: v4.0.30319
ProcessModel: Default    DomainUsage: Single
Execution Runtime: mono-4.0
***** ExamReport.TestExamReport.TestExam
***** HangulSystem.TestHangul.TestHangulProcessing
***** MultiTable.TestMultiTable.TestMulti
***** StarDrawing.TestStarDrawing.TestStar

Tests run: 4, Errors: 0, Failures: 0, Inconclusive: 0, Time: 0.0357531 seconds
  Not run: 0, Invalid: 0, Ignored: 0, Skipped: 0
```
