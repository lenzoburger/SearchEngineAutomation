# SearchEngineAutomation
Selenium C# Automation Framework - For Automated Testing of Multiple Search Engines with Multiple Browsers.

USAGE
----
### In Visual Studio

1.  Clone Repo (via _**Team Explorer**_)

2.  Open solution

3.  Open _**Test Explorer**_ tab

4.  _**Build**_  your solution (_**Rebuild**_ if you get errors)

5.  Run tests from test explorer (If test explorer does not appear, launch from _Test > Windows > Test Explorer_ and _**Rebuild**_ solution)


### With Batch File

1.  _**Build**_  your solution (_**Rebuild**_ if you get errors)

2.  Launch Windows Explorer

3.  Navigate to `C:\Users\<USERNAME>\Documents\Automation.Repository` (Copy this folder if you wish to run tests on another machine/environment)

    *  If you wish, you may update this path in VS project _Post Build Events_

4.  Double Click _**Runtests.bat**_

5.  After tests finish running, Navigate to `C:\Users\<USERNAME>\Documents\Automation.Repository\TestWindow\TestResults`

6.  Open results _**TRX**_ file in visual studio or preferred application to view results.

### In Command Line

1.  _**Build**_  your solution (_**Rebuild**_ if you get errors)

2.  Launch Windows Explorer

3.  Navigate to `C:\Users\<USERNAME>\Documents\Automation.Repository\SearchEngineTestContainer\<Version X.X.X.X>` (Copy this folder if you wish to run tests on another machine/environment)

    *  If you wish, you may update this path in VS project _Post Build Events_

4.  Launch **Command Prompt (CMD)**

5.  `cd C:\Users\<USERNAME>\Documents\Automation.Repository` and hit `**ENTER**`

6.  `%~dp0TestWindow\vstest.console.exe  %~dp0SearchEngineTestContainer\<Version X.X.X.X>\SearchEngineTestContainer.dll /Logger:trx` and hit `**ENTER**`
    *  Find more info on MSTEST Commands at https://msdn.microsoft.com/en-us/library/jj155796.aspx

7.  After tests finish running, Navigate to `C:\Users\<USERNAME>\Documents\Automation.Repository\TestWindow\TestResults`

8.  Open results _**TRX**_ file in visual studio or preferred application to view results.
