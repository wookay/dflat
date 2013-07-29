# programs/Makeflie

	
a:
	make TestMultiTable
	make TestStarDrawing
	make TestExamReport        
	make TestHangul

TestMultiTable:
	mcs -t:library MultiTable.cs
	mcs -t:library -r:nunit.framework,MultiTable TestMultiTable.cs
	nunit-console -nologo                        TestMultiTable.dll

TestStarDrawing:
	mcs -t:library StarDrawing.cs
	mcs -t:library -r:nunit.framework,StarDrawing TestStarDrawing.cs
	nunit-console -nologo                         TestStarDrawing.dll

TestExamReport:
	mcs -t:library ExamReport.cs
	mcs -t:library -r:nunit.framework,ExamReport TestExamReport.cs
	nunit-console -nologo                        TestExamReport.dll

TestHangul:
	mcs -t:library Hangul.cs
	mcs -t:library -r:nunit.framework,Hangul TestHangul.cs
	nunit-console -nologo                    TestHangul.dll

c:
	rm TestResult.xml *.dll
