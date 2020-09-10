# 200911-scaffolding-prep
[Microsoft Docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio-code)

You add scaffolding to your project when you want to quickly add code that interacts with data models. Using scaffolding can reduce the amount of time to develop standard data operations in your project

## Step by Step
- install new too globally 
	- dotnet tool install --global dotnet-aspnet-codegenerator
```
You can invoke the tool using the following command: dotnet-aspnet-codegenerator
Tool 'dotnet-aspnet-codegenerator' (version '3.1.4') was successfully installed.
```
- create mvc application
- install packages
	- dotnet add package Microsoft.EntityFrameworkCore.SQLite
	- dotnet add package Microsoft.EntityFrameworkCore.Design
	- dotnet add package Microsoft.AspNetCore.MVC.Razor.RuntimeCompilation
	- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
	- 
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- add data model
- add db context
- make changes to app settings
- configure db context with sqlite and razon runtime compliation in services 
- make and apply migrations
- scaffold CRUD pages
	- dotnet aspnet-codegenerator controller -name CustomerController -m CustomerModel -dc CustomerDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
```
-m	The name of the model.
-dc	The data context.
-udl	Use the default layout.
--relativeFolderPath	The relative output folder path to create the files.
--useDefaultLayout	The default layout should be used for the views.
--referenceScriptLibraries	Adds _ValidationScriptsPartial to Edit and Create pages
```
- successful scaffold creates controller with , landing page, and crud endpoints
```
Added Controller : '\Controllers\CustomerController.cs'.
Added View : \Views\Customer\Create.cshtml
Added View : \Views\Customer\Edit.cshtml
Added View : \Views\Customer\Details.cshtml
Added View : \Views\Customer\Delete.cshtml
Added View : \Views\Customer\Index.cshtml
RunTime 00:00:16.81
```
