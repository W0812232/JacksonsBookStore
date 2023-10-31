2023-10-24.
1446
Project created
ASP.NET Core Web App (Model-View-Controller)
ASP.NET Core 5.0
Individual accounts 
Enable Razor runetime compilation

testing
forgot to comment out ssl
//"sslPort": 44315
works and has register and login

1454
creating github repository

1508
testing break points F9

1511
going to register a user to website
User:     a@a.com
Passcode: Star123!

1519
registered user and implied imgrations
now logged in as a@a.com

razor runtime lets you update cshtml while site is running

1520 bootstrap choosing theme on bootswatch
1528 decided on theme downloaded and renamed default to 'bootstrap_bk' as a backup and putting in new theme
testing
lol no theme

1538 
um had to go into layout and change the link from bootstrap.min.css to -> bootstrap.css
it works execpt the navbar has not updated its still white and should be purple according the the bootswatch preview

1546 
oh the navbar was still white beacuse I didn't get to that yet in the tutorial just needed to update layout
it is purple now

2023-10-30
1132
testing... still works
now adding 3rd party tools from CSS_JS.txt file to _Layout

1144
adding dropdown
not showing items
properties of Dropdown link where cut off in tutorial going to find solution

1229
found the missing properties from a post on stackexchange from october 1st 2021
data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"

2312
made the 3 new projects
installed 
Microsoft.EntityFrameworkCore.Relational 5.0.17
Microsoft.EntityFrameworkCore.SqlServer 5.0.17

2023-10-23
0012
ApplicationDbContext errors:
needed to instal
Microsoft.AspNetCore.Identity.EntityFrameworkCore 5.0.17
and 
changed namespace 

0023 
removing all Class1.cs
project built

now working on models

0039
error.cshtml has error need to rerferance the other projects
trying to figureout how 
figured it out thought i had to edit the error.cshtml but just needed to referance the projects in this one
continuing

0058
modifying startup
errors with ApplicationDbContext
fixed by adding using JacksonsBookStore.DataAccess.Data;

0105
also error with ErrorViewModel in homecontroller 
had to replace all referance of ErrorViewModel to acturatly link it

0131
adding area Customer
AHHHH it made a new txt file

0142 
moving homecontroller to customer folder
and home folder to folder in customer folder

testing... and now there is no css

0240 
got the css to work after adding a copie of _ViewStart to the Areas Customer folder 
and I had to modify the path and now the css is working again

0242
adding new area admin like the customer area

0255
got to end.. it looks fine 
 um adding new user doesnt work though
