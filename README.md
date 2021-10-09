#  Json Web Token with ASP.NET Core Web API.
The following project demonstrates how to create and use JWT (Json Web Token) in ASP.NET Core Web API. 

The step by step video can be found here :<br/>  [https://www.youtube.com/watch?v=MltKzQpaltk](https://www.youtube.com/watch?v=MltKzQpaltk)

# Description
The API manages a sneaker store, it exposes endpoints for CRUD operations over a Sneaker table.

The endpoints are secure with a JWT.

# Setup
## Create an empty database<br/>
I used SQLExpress in this tutorial.

## Clone the repo
```
git clone https://github.com/techwithpat/SneakerAPI
```

## Update the configuration
In __appsettings.Development.json__ (under appsettings.json) :

Set the connectionstring to the database 
```javascript
 "ConnectionStrings": {
    "SqlConnection": "The Connection string to your database"
  }
```
Check Jwt setttings
```javascript
"JwtSettings": {
    "validIssuer": " String that represents a valid issuer [your name for instance]",
    "validAudience": "http://localhost:35464 or the Url of your API [check in Properties/launchSettings.json]",
    "secret": "yoursecret"
  }
```

## Build the solution (Ctrl + Shift + B)
This step should download and install the dependencies.

## Apply existing migrations 
This step will create all the tables and seed them with some data.

If you use VS, in the package manager console : `Update-Database`<br/>
If you use NET Core CLI : `dotnet ef database update`

## Run the project
Press F5 to launch the API.<br/>
First, with your __username / password__, you should request an authentication token to the endpoint : __/api/auth/login__.

Then, include the token in your headers for GET and POST operations :
__Authorization: Bearer eyJhbGc...........__

# Built With
 C#<br/>
 ASP.NET Core Web API<br/>
.NET 5<br/>


# Author
Patrick Tshibanda
