﻿2023-10-24.
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
works

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

 ------------------
 Part 2
 ------------------

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

1454
20231113172923_AddCategoryToDb2 

1458
now removing buttons from index in category they will be in newly added js file category.js

1527
testing
getting thrown exception in Repository.cs: throw new NotImplementedException();
when I tried to continue I got waring from the browser: DataTables warning: table id=tblData - Ajax error. For more information about this error, please see http://datatables.net/tn/7

1532
Also the table just says loading I think its either the table cant connect or its beacuse their are no entries
im going to continue then see if it fixes itself

2023-11-23
0339
Applying code to activate Edit, Delete and Create using upsert action in category controller
adding upsert view and adding html from class files 

0418 
within the shared layouts adding a partial view for the EDIT | BACK called "_CreateAndBackToListButton";
not letting me add view...
It was because the project was running. 
creating view now. I dont know how to make it a partial view.

0441
now adding another view "_EditAndBackToListButton";

0446
modify Upset.cshtml view file 

"@if(Model.Id != null)" Id is giving me an error
I figured it out its because Id needs to be id to match my Category.cs

adding asp-action "Upsert" to Index.cshtml

running application, still getting thrown exception when going to category page

0515
adding section to call validation.
testing
didnt work spelt the scripts name wrong
testing again to see if validation works
tried creating category with no name got back: "The Category Name field is required" (under input field in red text)
it works!

0538
Adding to CategoryController to valadate and for deleting
adding onclick=Delete("/Admin/Category/Delete/${data}") to the delete button on category.js
now adding the delete function to the category.js

0600 
I got:NotImplementedException: The method or operation is not implemented.
when trying to add category

2023-11-20
1927
was thrtowing exceptions because i never added the repository functions from class file
now getting error with trying to implement IRepository<T>

1934
found problem GetAll() had an extra ( at the begining of it.
testing...
return query.ToList(); thorws an exception
now creating new category
_db.SaveChanges(); throws exception

changed id to Id then updated-database
2214
idk i keep getting an sql error its been 3 hours and i havent been able to fix it im going to see if i can reset from before part 2

=============
Re:Part 2
=============
2023-11-21
0050
Using NuGet to add new migration
name: AddDefaultBook
Timestamp: 20231121061047_AddDefaultBook
updating database

got message There is already an object named 'AspNetRoles' in the database
but i still got the tables i need

0125
adding Category.cs and its values

0138
adding new migration AddCategoryToDb

adding category to ApplicationDbContext 

adding migration to use category.cs called AddCategoryToDb2
Timestamp: 20231121064212_AddCategoryToDb2

0149
Repository 2.2

Adding Repository directory, IRepository directory, IRepository.cs and its functions
now adding Repository 
adding using statments
adding code from class files

forgot to make IRepository an inerface copying its code and remaking it
okay its readded and I pasted its code back in

0248
Adding CategoryRepository and its interface

0339
Adding SP_Call and its interface
install package dapper
adding methods to SP_Call
implementing ISP_Call to SP_Call
getting error with SqlConnection need to add using statment using Microsoft.Data.SqlClient;

0415
Adding Unit of work interface and class
registering it in start up 
AddScoped<IUnitOfWork, UnitOfWork> is giving an error
adding using statements to startup, helped but now has another error
had to Implement IUnitOfWork in UnitOfWork


0505
Added Empty Controllers directery to the Admin directory
Added CategoryController controller 
Add Category directory in views folder

0518
Adding Index view to the category directory and adding code from class files
running application

0523
relizing i didnt make a link to the Category view adding that now to the dropdown
In Index adding buttons for editing and deleting categorys(just visual)
testing...
they are there!

0535
Deleting the code for the buttons adding Javascript 'category' from class files
add @section to call the category.js

tried to run it go same error as before I reset just wasted 5 hours annoying 

0548
added IAction result to the controller
adding Upsert view with code from class files

0550
Added Partial views
modifying upsert
modifying index
adding valitadtion to upsert

0612
creating upsert post action method in CategoryController
adding void save() method to IUnitOfWork

0618
Added HttpDelete to categoryController to implement a delete method
and adding delete functionality to the JavaScript

0627
so idk i just finished part 2 again and still doesnt add to categories just have to move on i think i have 9 hours

======================
Part 3
======================
2023-11-21
1/3

0703
Add new class product in models 
CoverType is giving error?

Adding referance to Produces and coverType in database in ApplicationDbContext


0911
Didnt read instruction right need to add CoverType class to models

1019
Made ICoverTypeRepsotiory And CoverTypeRepository made them the same as ICategoryRepository and CatagoryRepository
but changed Category words to CoverType
Adding to UnitOfWork
the implemented IUnitOfWork has an error in UnitOfWork
got error becasue  I had 'ICoverTypeRepository CoverTypeRepository' where CoverTypeRepository should have been just CoverType

1030 
now need to creat migration
TimeStamp: 20231121153320_AddCoverTypeToDb
Update Database
work on crud for CoverType
navbar

1047
made new CoverType Controller same as Category controller but with values replaced
need to make new view file for index and upsert
index() is giving error in the controller
oh its because i had two index methodss on acciedent

1103
testing...
link isnt working....

1112
found issue I forgot to add [Area("Admin")] to top of CoverTypeController

still getting thrown exception where going to link:
"Microsoft.Data.SqlClient.SqlException: 'Invalid object name 'Categories'.'"
i ont even know how because this isnt even categorys

then when i try to make new cover type I get:
"SqlException: Invalid object name 'CoverTypes'."


1124
-------------
added AddProductToDb migration
Timestamp: 20231121162356_AddProductToDb
-------------

1128
I dont see the databases
adding new validation to product model

1138
adding new migration with the validation
Timestamp: 20231121164058_AddValidationToProduct

1146
adding Product to repository making IRepository interface changing the update methed
need to add them too UnitOfWork and IUnitOfWork
done that and 0 errors rn
moving on

===========
Part 3
2/3
===========
Add product controller and add the IWebHosting call to upload images on the server inside wwwroot
now need a viewModel inside the models project to hold the Product object and select list for category and coverType
SelectListItem is giving error

1235 
fixed! had to Install Microsoft.AspNetCore.Mvc.ViewFeatures package and now it works

1238
now modifying the productcontroller so it calls the ProductVM view model
all the assigned variable have an error ahhh

1254
the error has because on line 32: ProductVM productVM = new ProductVM()| I accidentally had a ';' at the end
its fixed now

1258
adding product view directory
added new index and copy and pasted the code from Index in the category directory
added new properties to the table: Title, ISBN, Price, Author and, category
link to product.js

1310
now need to make product.js just copying category.js and modify it for those new properties
also new to change width size so they all fit.
Also made CoverType its own JavaScript file bc i think i was supposed to do that.

1312
Now just need to add a link to product 

1320 
just tested and realized the nav is getting packed I think ima add out links to the drop down
ya just tested it way nicer now also added another divider to dived them all

2023-11-28
0048
Okay just downloaded Visual studio on laptop because I wasnt able to create tables on pc, something with the database
testing
omg its so slow but it works
but my cover list and category list are being shared on both pages...
actually its just category being shared on both

0059
Okay found the problem was that i forgot to change the CoverType.js at all when i made it
had to change referances to category to be cover.. now the covertype veiw works properly
oh yeah still need to finish 3/3 part 3

============
part 3
3/3
============

0126 
adding upsert.cs to product getting code from class files

0131
need to make textbox with tiny.cloud
made account adding the API key

0141
added rest of code to add function to valide input
and if empty display alert

testing...

0152
The form is there..
although not letting me create new product, it doesnt add anything
also the page said "category list" and "create categories" but I fixed It to say product for both

0208
In wwwroot added directory images and sub directory product

0212
was supposed to uncomment product upsert post action method but I realised it is already uncommented

0233
Error:
"DataTables warning: table id=tblData - Requested unknown parameter 'title' for row 0, 
column 0. For more information about this error, please see http://datatables.net/tn/4"

need to find where this is but idk

0346
now is on price idk what changed 
""DataTables warning: table id=tblData - Requested unknown parameter 'price' for row 0,
column 2. For more information about this error, please see http://datatables.net/tn/4

oh? and now it filled the books into the table with the information it has, title isbn and author

0511
IDK The price still doesnt work and now when selecting covertype for book it gives the options from categories
so late need to get some sleep.

1441
Okay relized I forgot to fix category and coverTypes becuase right now I can't delete 

1507
changed object names in project.js to propernames now it works and table fills


===================
Part 4
===================
2023-12-05
0211
Testing to make sure it still works.. 
it works..
but when making new book the covertype drop down still shows categories

0219
Found in Product Upsert the drop down list was set to CategoryId and CategoryList instead of CoverTypeId and CoverTypeList
changed and testing... It Works!!

0327
trying to figure out how to populate product database

0356
going to remove the buttons at bottom of category and covertype views.
