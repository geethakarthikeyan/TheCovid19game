# Nunit Test Automation Framework

Uses: 
 • Selenium (WebDriver)
 • NUnit 3.x 
 • utilises Page Object Model pattern
 • can be run using Jenkins 

Installation Software • Download Visual Studio 2019. • Install Visual Studio Git provider (Visual Studio Tools for Git). • Ensure Chrome web browser is installed. • Ensure Selenium Chrome Driver (chromedriver.exe) is authorized on your PC. Framework • Extract the contents of Covid-19TheGame solution folder from source control. • Make necessary changes to projectPath and filePath in app.config for each project. • Build the solution. NuGet dependencies may need to be restored. Visual Studio Solution

Execution All tests are defined as Nunit test methods and can be executed directly from Visual Studio. Tests are executed in Chrome by default. Although this is configurable, the framework has been tested with edge browser as well.Configuration of dynamic run time information is defined in the App.config file for each test project. General settings like URL, browser... etc. are defined in settings of the project. Automated few UI cases for https://responsivefight.herokuapp.com/
