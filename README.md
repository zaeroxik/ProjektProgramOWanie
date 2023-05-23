
# ProgramOWanie
Application created for a school project.

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Prerequisites](#prerequisites)
* [Setup](#setup)
* [Usage](#usage)
* [Contact](#contact)



## General Information
- Application is easy for usage, but with rich features.
- Nowadays we all need to have everything optimized, that's why I have invented this app.
- Application was creates as a Project for our classes.
<!-- You don't have to answer all the questions - just the ones relevant to your project. -->


## Technologies Used:
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
- Once Job is finished you can move it to finished jobs section, where all finished jobs are stored


## Screenshots
<a href="https://postimages.org/" target="_blank"><img src="https://i.postimg.cc/qMz653yJ/1.png" alt="1"/></a><br/><br/>
<a href="https://postimg.cc/tsCpP6WS" target="_blank"><img src="https://i.postimg.cc/2Sn6sF6D/2.png" alt="2"/></a><br/><br/>
<a href="https://postimg.cc/4YLZ131J" target="_blank"><img src="https://i.postimg.cc/8CD5NJJr/3.png" alt="3"/></a><br/><br/>


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
            
            
            
So first you will have to create Server like this: (localdb)\Local or edit a code and insert your server.

-  Please run script called "[script.sql](https://github.com/zaeroxik/ProjektProgramOWanie/blob/master/script.sql "script.sql")", this will create database required for this application (Add-migration abc and update-database will also work in Package managment console). 

After that please run project/application via Visual studio or simply with .exe file located in [ProjektProgramOWanie.zip](https://github.com/zaeroxik/ProjektProgramOWanie/blob/master/ProjektProgramOWanie.zip "ProjektProgramOWanie.zip") folder (please copy whole folder).

    

## Usage
For tests we have created an admin account, please use it for further tests.
login: admin
password: admin

After login at top you can see 2 options (Dodaj zleceniodawce, Pracownicy).
In table rows you can see all customers you have added, and on the same row you can see current jobs or jobs which has been archived also you can delete a customer.


## Contact
Created by [@zaeroxik](https://github.com/zaeroxik) - feel free to contact me!


<!-- Optional -->
<!-- ## License -->
<!-- This project is open source and available under the [... License](). -->

<!-- You don't have to include all sections - just the one's relevant to your project -->
