# _Vendor and Order Tracker _

####  MVC application that tracks the vendors and the orders belonging to those vendors  , March 13 2020_

#### By _**Fatma C. Dogan**_

## Description

MVC application to track the vendors that purchase baked goods from Pierre's bakery and the orders belonging to those vendors.

## Project Specifications

| Behavior | Input | Output |
|---|:---|:---:|
|When the user runs the application, they receive a  welcome message along with the links for both `view vendors` and `add a new vendor`. |  localhost:5000/ | Welcome to Pierre's Bakery Vendor Tracker! <br> `View Vendors`<br>`Add a new Vendor`|
|The user can see a list of vendors by clicking the `view vendors` link | `view vendors` | No Vendors have been added yet! |
|When the user clicks on `add a new vendor` link, receives a form to create a new vendor| `add a new vendor` | Vendor Name: <br> |
|When the user fills out the form and clicks to the `add` button, the user is routed to the vendor list page. | Vendor name : Suzie's Cafe  | Vendors: <br>  Suzie's Cafe
|When the user clicks the vendor's name, the user is routed to the order page of that vendor. | `Suzie's Cafe` | `Add a new Order` <br> `Return to Vendors list`<br> `Return to Main Page`|
|The user can create a new order by clicking the "add a new order" | `add a new order` | Order Title: <br> Description: <br> Total Price: <br> Date: |
|When the user fills out the form and clicks to the `add order` button, the user is routed to the order list page. | `add order` | 1. Order: Bread <br> Description: 5 loaves of bread <br> Price: $20 <br> Date: 3/13/2020|
|From the order list page, the user can click on for the Vendor page or the main page or can create a new order. |



## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/fc-dogan/Vendor-and-Order-Tracker ```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} ```
* On Windows: ``````

_Download Manually:_

* Navigate to https://github.com/fc-dogan/Vendor-and-Order-Tracker
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "Vendor-and-Order-Tracker".


_Note For Editors:_ 
* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal

* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
## Known Bugs

_No known bugs at this time._


## Technologies Used

* C#
* ASP.NET Core MVC
* VS Code

### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Fatma C. Dogan_**