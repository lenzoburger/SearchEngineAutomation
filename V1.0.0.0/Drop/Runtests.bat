::Run Selenium Automation Tests in MSTEST

@ECHO OFF
%~dp0TestWindow\vstest.console.exe %~dp0SearchEngineTestContainer\1.0.0.0\SearchEngineTestContainer.dll /Logger:trx

pause