# programs/Makeflie

a:
	make TestMultiTable
	make TestStarDrawing
	make TestExamReport        

TestExamReport:
	mcs -t:library ExamReport.cs
	mcs -t:library -r:nunit.framework,ExamReport TestExamReport.cs
	nunit-console -nologo             TestExamReport.dll

TestStarDrawing:
	mcs -t:library StarDrawing.cs
	mcs -t:library -r:nunit.framework,StarDrawing TestStarDrawing.cs
	nunit-console -nologo             TestStarDrawing.dll

TestMultiTable:
	mcs -t:library MultiTable.cs
	mcs -t:library -r:nunit.framework,MultiTable TestMultiTable.cs
	nunit-console -nologo             TestMultiTable.dll
c:
	rm TestResult.xml *.dll
