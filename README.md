<h1>Windows Forms project with Blazor integration</h1>

This is a simple Windows Forms app with Blazor integration. It is used to select and display details of certain person, such as It's first name, last name and birthday.

<h1>How does it work?:</h1>

- User selects one of the people from list presented on the left side by clicking a left mouse button while hovering over full name of given person

- After selecting person from the list, It's details are displayed in the panel to the right - Person details are: First name, last name and birth date

- Person details displayed change when other person is selected from the list

<h1>Core points:</h1>

- Written in C#, HTML and CSS, using Windows Forms with Blazor integration

- It utilizes <b>BlazorWebView</b> class from <b>Microsoft.AspNetCore.Components.WebView.WindowsForms</b> package, to provide intergration of Windows Forms app with Blazor framework.

- <b>BlazorWebView</b> utilizes simple HTML document with CSS stylesheet attached to it via \<link> tag.

- Person details are retrieved from <b>IPersonService</b> interface, implemented in <b>PersonService</b> class, which is injected into a <b>Form</b> object. Currently service has data asigned at compile time, but by using service for that purpose, the code can be easily refactored, to use a database as a data source in It's implementation.

- Dependency injection is done via <b>ServiceCollection</b> class, instantiated in <b>Program.cs</b>, which is used to build a ServiceProvider object, after all services have been added to <b>ServiceCollection</b> Injection is done automatically thanks to <b>ServiceProvider.GetRequiredService()</b> method, passed as a parameter of <b>Appliacation.Run()</b> method.