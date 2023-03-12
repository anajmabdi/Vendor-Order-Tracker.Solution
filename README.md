# <div align="center"> **Pierre's Bakery: Vendor and Order Tracker**</div>

#### <div align="center"> By Najma Abdi </div>  
<p>&nbsp;</p>

# <div align="center"> Technologies Used
- <div align="center">C#
- <div align="center">HTML
- <div align="center">ASP.NET Core MVC
- <div align="center">MSTest

<p>&nbsp;</p>

# <div align="center"> Description </div>
<div align="center"> I built a C# MVC application for Pierre's bakery where he can track the vendors that purchase baked goods from him and the orders that belong to the vendors. 
<p>&nbsp;</p>

## The following are the functionalities used:
<p>&nbsp;</p>

* A Vendor class:
  Includes properties for the vendor's name and description and a list of the orders that were made by the vendor.
* Order class:
  Includes properties for the title, the description, the price, and the date.
* The homepage of the app at the root path (localhost:5000/) will be a splash page welcoming Pierre and providing him with a link to a Vendors page.
* The vendors page will contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object will be saved into a static List and Pierre will be routed back to the homepage.
* Pierre will be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
* Pierre will be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor.

 </div>

<p>&nbsp;</p>


# <div align="center">Installation Requirements 
You must make sure the following software packages are locally installed in order to use this application:

- A preferred code editor (my case: VS Code)
- .NET6

## <div align="center">Setup
- After cloning, navigate to this project's production directory ("Tracker") and run 'dotnet restore'. This will establish project-specific tools and dependencies that are listed in the project file.
- Run 'dotnet test' after navigating to the test folder (Tracker.Tests) to run tests.

- Run 'dotnet run' to start the server after navigating to "Tracker".

<p>&nbsp;</p>
<p>&nbsp;</p>


# <div align="center"> Known bugs </div>
## None
<p>&nbsp;</p>

#### License

MIT License

Copyright (c) [2022] [Najma Abdi]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
