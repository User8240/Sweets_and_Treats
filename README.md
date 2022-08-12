# Pierre's Sweet and Savory Treats

#### By _**Grace Kostanich**_  

#### _This website will..._  

---


## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is an MVC application that was built using C#._

---
## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"

<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/User8240/Sweets_and_Treats.git
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/User8240/Sweets_and_Treats.git</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "SweetsAndTreats.Solution".
<li>Navigate to the projects root directory, "SweetsAndTreats".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "SweetsAndTreats" directory  
   <pre>SweetsAndTreats.Solution
   └── SweetsAndTreats
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=grace_kostanich;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>In root directory of project folder "SweetsAndTreats", run
<br>
<strong>$ dotnet restore</strong>
<br>
<strong>$ dotnet build</strong>
<br>
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<br>
<li>Then run <strong>$ dotnet ef database update and do the following:</strong>

<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "grace_kostanich" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>sweets</strong>, <strong>treats</strong>, & <strong>sweettreat</strong>.
  
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>SweetsAndTreats.Solution
   └── <strong>SweetsAndTreats</strong></pre>

Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal.
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---

>#### _**A Big Thanks To:**_ 
>#### **Garrett Hays @ https://github.com/GarrettHays**    
>#### **Zachary Waggoner @ https://github.com/CyndaZ42**  
>#### _**for amazing README formatting and instructions!**_  

---

## Known Bugs

* _No known issues_

## License

_None_


Copyright (c) 8/12/2022 Grace Kostanich