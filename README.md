# **Accelerate Project Management System**
### An MVC application written in C#, January 8, 2021

#### By Zahnen Garner

---  

_Accelerate is a project management tool developed for a fictional factory as an independent project while studying at Epicodus. The application allows users to manage engineers and machines via a many-to-many relationship within a database. The application was created to apply concepts I learned this week which include the basics of code-first migration with MySQL, establishing relationships within databases with join tables, using EF Core, using ASP.NET Core, and implementing CRUD functionality within an MVC application._  

---  

## User Stories

<details>
  <summary>Expand</summary>
  You've been contracted by the factory of the famous Dr. Sillystringz to build an application to keep track of their machine repairs. You are to build an MVC web application to manage their engineers, and the machines they are licensed to fix. The factory manager should be able to add a list of engineers, a list of machines, and specify which engineers are licensed to repair which machines. There should be a many-to-many relationship between Engineers and Machines. An engineer can be licensed to repair (belong to) many machines (such as the Dreamweaver, the Bubblewrappinator, and the Laughbox) and a machine can have many engineers licensed to repair it.
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

## Setup/Installation Instructions

### To run the project locally:

* _Open your git-capable command line program (I recommend Terminal on Mac or Git Bash on PC)_
* _Ensure you are within the directory you'd like the file to be created in._
* _Enter the command "$ git clone https://github.com/zahnen/Factory.Solution" in your command line_
* _Once cloned, use the "$ cd " command to navigate to the directory created in the previous step._
* _You must have .NET Core V2.2 installed in order to run the console app successfully. If you do not have .NET Core V2.2 installed, find more information and download it [here](https://dotnet.microsoft.com/download/dotnet-core/2.2)_
* _To run the console application, enter "dotnet build" in your command line while in the Factory directory. Follow this command with "dotnet run"_
* _Your command line will open a server (likely "http://localhost:5000/"). Navigate to this URL in your browser to view the project._



---  

## Known Bugs/Issues

There are no known bugs or issues at this time. If you come across any, please let me know by emailing me!


---  


## Support and Contact Details

* zahnen@gmail.com

---  

## Technologies Used

_This application required use of the following programs/languages/libraries to create:_
* _GitBash_
* _Visual Studio Code_
* _GitHub_
* _GitHub Pages_
* _C# v 7.3_
* _.NET Core v 2.2_
* _EF Core_
* _MySQL_
* _MySQL Workbench_
* _ASP.NET Core_
* _Bootstrap_
* _CSS_
* _cshtml_

---  

## License

*Licensed under MIT* 

Copyright (c) 2020 Zahnen Garner