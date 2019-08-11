# IDE for reference (localhost development)
* Windows 10 Pro 1803, OS Build: 17134.885
* .NET Framework 4.8 Developer Pack
* IIS Express 10.0
* Visual Studio 2019 Community Version 16.2.1

I've been running the localhost instance through Visual Studio (Build/Ctrl+F5) so no seperate SQL server has been used

# Modifications

Umbraco 8.1.1 w/ [The Starter Kit](https://our.umbraco.com/packages/starter-kits/the-starter-kit/) used as the foundation

## Files modified
* `AppCMS.Web\Views\master.cshtml`
* `AppCMS.Web\Views\home.cshtml`
* `AppCMS.Web\Views\Partials\Navigation\TopNavigation.cshtml`

## Files added
* `AppCMS.Web\Views\login.cshtml`
* `AppCMS.Web\Views\SignUp.cshtml`
* `AppCMS.Web\Views\Partials\Login.cshtml`
* `AppCMS.Web\Views\Partials\SignUp.cshtml`
* `AppCMS.Web\css\appcms.css`

# Models and Controllers
* `AppCMS.Web\Controllers\MemberController.cs`
* `AppCMS.Web\Models\LoginModel.cs`
* `AppCMS.Web\Models\SignupModel.cs`

# Users
## Backend (Users)
* Email: admin@local.dev
* Password: NgC-$#0NAo

## Frontend (Members)
* Email: member-test@local.dev
* Password: membertest
