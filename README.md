
# ProgramOWanie
Application made for work optimalization in Transport industry and  for class project. :)

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Prerequisites](#Prerequisites)
* [Setup](#setup)
* [Usage](#usage)
* [Contact](#contact)



## General Information
- Application is easy for usage, but with rich features.
- Nowadays we all need to have everything optimized, that's why I have invented this app.
- Application was creates as a Project for our classes.
<!-- You don't have to answer all the questions - just the ones relevant to your project. -->


## Technologies and packages in Visual studio 2022 Used:
- Application is writted in C# in WPF XAML
- Microsoft.EntityFrameworkCore 6.0.10
- Microsoft.EntityFrameworkCore.SqlServer 6.0.104
- Microsoft.EntityFrameworkCore.Tools 6.0.10
- BCrypt.Net-Core



## Features
Most of the important features:
- Add and manage your clients and clients cars
- Add and manage your workers
- You can manage database with ProgramOWanie application
- Add and manage any work done with client car


## Sample Screenshots TO DO
<a href="https://postimages.org/" target="_blank"><img src="https://i.postimg.cc/Kj3QkMqC/1.png" alt="1"/></a><br/><br/>
<a href="https://postimages.org/" target="_blank"><img src="https://i.postimg.cc/3WM1gxzN/2.png" alt="2"/></a><br/><br/>
<a href='https://postimages.org/' target='_blank'><img src='https://i.postimg.cc/Z5NR7K2Z/3.png' border='0' alt='3'/></a>
<!-- If you have screenshots you'd like to share, include them here. -->


## Prerequisites

You need the following tools in order to edit the solution.

-   Microsoft Visual Studio (Latest recommended)
    
-   Microsoft SQL Server (Latest recommended)

And to just Run it you will need:
-   Microsoft SQL Server  (Latest recommended)

-   .Net Desktop Runtime (Latest recommended)


## Setup

The application requires a database to store the data. Follow the below step to setup database.

Connection string to database looks like this:
        private string _connectionString =
            "Server=(localdb)\\local;Database=wpfDb;Trusted_Connection=True;";
            

-  Please run script called "[script.sql](https://github.com/zaeroxik/ProjektProgramOWanie/blob/master/script.sql "script.sql")", this will create database required for this application.

After that please run project/application via Visual studio or simply with .exe file located in [ProjektProgramOWanie.zi](https://github.com/zaeroxik/ProjektProgramOWanie/blob/master/ProjektProgramOWanie.zip "ProjektProgramOWanie.zip") folder (please copy whole folder).

    

## Usage
For tests we have created an admin account, please use it for further tests.
login: admin
password: admin

After login at top you can see 4 options (Odswiez, Dodaj pojazd, Dodaj kierowce, Zamknij).
In table rows you can see all cars you have added, and after right click on that you can view more details of this car ("Informacje") and manage a list of repairs of this car etc.


## Contact
Created by [@zaeroxik](https://github.com/zaeroxik) - feel free to contact me!


<!-- Optional -->
<!-- ## License -->
<!-- This project is open source and available under the [... License](). -->

<!-- You don't have to include all sections - just the one's relevant to your project -->
