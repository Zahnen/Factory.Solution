# **Accelerate Project Management System**
### An MVC application written in C#, January 8, 2021

#### By [Zahnen Garner](https://www.github.com/zahnen)

---  

_Accelerate is a project management tool developed for a fictional factory as an independent project while studying at Epicodus. Accelerate enables project managers to quickly delegate repair and maintenance tasks by accessing a database that keeps track of machines, engineers, and approvals for engineers certified to maintain specific machines. The application allows users to manage engineers and machines via a many-to-many relationship within a database. The application was created to apply concepts I learned this week which include the basics of code-first migration with EF Core & MySQL, establishing relationships within databases using join tables, using ASP.NET Core, and implementing CRUD functionality within an MVC application._  

---  

## 📘 User Stories

<details>
  <summary>Expand</summary>
  This project was created to respond to the following prompt:
  
  _You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it._
  <table>
  <tr>
    <th>Scenario 1</th>
    <th></th>
  </tr>
  <tr>
    <td>Behavior</td>
    <td>As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.</td>
  </tr>
  <tr>
    <td>Completion</td>
    <td>✅</td>
  </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 2</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 3</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 4</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 5</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 06</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
</details>

---  

## 🔧 Setup/Installation Instructions

Running this project locally requires:
- A code editor such as [VisualStudio Code](https://code.visualstudio.com/) 
- [ASP.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- [MySQL/MySQL Workbench](https://www.mysql.com/).
- A loose familiarity with MySQL databases & navigating through local files using your command line program such as Terminal or Gitbash (e.g., "cd Desktop").

Please ensure all of the aforementioned softwares are installed on your device or refer to the previous links to begin installion. If you have questions on the installation process, please don't hesitate to [reach out!](mailto:zahnen@gmail.com)

### 1. Clone or Download the project:

#### To Clone:
* _Open your preferred command line program._
* _Ensure you are within the directory you'd like the project directory to be created in. (e.g., "cd Desktop" if you'd like to clone the project to your desktop)_
* _Enter the command "$ git clone https://github.com/zahnen/Factory.Solution" in your command line._

#### To Download:
* _Navigate to the [project repository](https://github.com/zahnen/Factory.Solution) in your browser._
* _Click the green "Code" button toward the top right of the page._
* _Click "Download ZIP" and extract the files._
* _Open the newly-downloaded project in your preferred code editor._


### 2. Establish a MySQL database for using the project:

#### Code-First migration with EF Core (Preferred):

- Create a file at the root level of the directory named "appsettings.json" _Note: This file is included in this repository for the purposes of submitting the project as a graded assignment. If you elect to move forward with code-first migration with EF Core, you may simply replace the contents of this file rather than create a duplicate "appsettings.json" file._
- Add the following code into the appsettings.json file

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[ENTERDATABASENAMEHERE];uid=[ENTERUSERIDHERE];pwd=[ENTERPASSWORDHERE]];"
    }
}

```
- Replace the [ENTERDATABASENAMEHERE], [ENTERUSERIDHERE], and [ENTERPASSWORDHERE] placeholders with your desired database name + your user information associated with your local MySQL server.
- Navigate to the directory titled "Factory" within the root directory created when cloning the project.
- Run the command "dotnet ef database update" to establish the database in MySQL using the migrations included with this repository (suggested).
- If you choose to modify the database by altering the model logic of this project, save all changes and then run the command "dotnet ef migrations add [ENTERMIGRATIONNAMEHERE]" within the "Factory" directory to create a new migation using EF Core. Replace [ENTERMIGRATIONNAMEHERE] with whatever you'd like to name this migration. Follow this by running the command "dotnet ef database update" to update the MySQL database with your changes. You will need to create a new migration _and_ update the MySQL database each time you modify elements of the existing database within the code.
- Verify that your newly establish database exists within your MySQL Workbench before proceeding (you may need to right click the explorer and click "Refresh All" to see the new database).

#### Importing the database using the included .sql file:

- Open MySQL Workbench and navigate to the server on which you'd like to host the database.
- In the workbench's navigation panel, click "Server" and then click "Data Import".
- Select the option to "Import from Self-Contained File" and select the file titled "zahnen_garner.sql" from within the project directory using the file navigator.
- To run the project successfully, I recommend that all schema objects be imported when prompted and that you create a new schema when importing (click "New" next to the "Default Target Schema" input and name the schema how you see fit).
- Ensure that you're proceeding with the "Dumpstructure and Data" option towards the bottom of the import screen.
- Click "Start Import"
- Verify that your newly establish database exists within your MySQL Workbench before proceeding (you may need to right click the explorer and click "Refresh All" to see the new database).


### 3. Run the project:

* _Once the project is cloned and the MySQL database is established, use your preferred command line program to navigate to the directory titled "Factory" within the root directory created when cloning the project._
* _To run the console application, enter "dotnet build" in your command line while still within the Factory directory. Follow this command with "dotnet run"_
* _Your command line will open a server (likely "http://localhost:5000/"). Navigate to this URL in your browser to view the project._

---  

## 📊 SQL Schema

![Schema diagram](https://i.imgur.com/LkJjmPw.jpg)

---  

## ❗ Known Bugs/Issues

There are no known bugs or issues at this time. If you come across any, please let me know by [emailing me](mailto:zahnen@gmail.com).

---  

## ❓ Support and Contact Details

* Zahnen Garner // zahnen@gmail.com

---  

## 💻 Technologies Used

_This application required use of the following programs/languages/libraries to create:_
* _[Microsoft Visual Studio Code](https://code.visualstudio.com/)_
* _[Git/GitHub](https://github.com/)_
* _[C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_
* _[.NET Core v 2.2](https://dotnet.microsoft.com/download)_
* _[ASP.NET MVC](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)_
* _[ASP.NET Razor](https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c)_
* _[EF Core](https://docs.microsoft.com/en-us/ef/core/)_
* _[MySQL/My SQL Workbench](https://www.mysql.com/)_
* _[MySQL Designer](https://ondras.zarovi.cz/sql/demo/)_
* _[Bootstrap](https://getbootstrap.com/)_
* _[CSS](https://developer.mozilla.org/en-US/docs/Learn/CSS)_

---  

## 📃  License

*Licensed under MIT* 

Copyright (c) 2020 Zahnen Garner