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

2023-11-13
1134
forgot to save last time worked on

1142
Ok creating category class
going to add migration
last time I had a problem last time because I forgot to change the defualt project

1150
Just saw my migation was full when its supposed to be empty and relized I forgot to add 
the default identity migration first so im copying and pasting Category.cs and README to note pad 
then restarting bc idk I i can fix it

1155
if wrong defualt project is selected it gives a larger error
BookStoreDefault added
20231113165958_BookStoreDefault
updating database

1205
Added Category class
Added new and empty migration AddCategoryToDb
adding to DbContext to implement cateory 

1219 
not letting me re add migration because im already have a migration with that name
Had to make one with different name and it works and is filled with the values from the Category class

1235
part 2

2023-11-14
0230
Adding repository
Adding Category Repository class and interface

0416 
FirstOrDefault is erroring
it was because i removed 'using System.Linq' at some point,.. readed it now

0424
Id from:'s => s.Id == category.Id', is now errors
it was because Id is not in category, id is though hop that doesnt mess anything else up

1011
took nap
Parameter DynamicParameters in ISP_Call giving error
to fix add 'using Dapper'

1031
Adding to SP_Call
in the constructor GetDbConnection is giving error
fix by using Microsoft.EntityFrameworkCore;

1053
SP_Call, SqlConnection is giving error, added using Microsoft.Data.SqlClient and it fixed
also getting error for procedureName

oh its becuase it is supposed to be procedurename,
ok it works now

1143
services.AddScoped<IUnitOfWork, UnitOfWork>();
they are both giving error
added proper using statments for them UnitOfWork is ok...
but still having problem with IUnitOfWork giving error
Oh It says inaccessable due to protection
ok now it works after i make it a public interface

1315
Just added the Category index view 
now going to run and see if it works crossing fingers.

runs! aaaa category inst there!!! :(
updating database
nothing chaged....
need a castegory tab at top changing _Layout
link didnt work
ah just review example and needed to change the area direction to Admin
it works now yay!

1339
Adding Category to Content management
still works