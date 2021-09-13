# LoyaltyProgram

.NET MVC with React application generated with .NET 5.0.

To run install .NET 5.0
Clone the repository restore nuget packages, build and run!

To quickly build and run using dotnet cli run the following commands:
At solution level:
```
  dotnet restore
```
Install npm packages at client app level:
```
cd LoyaltyProgram/ClientApp && npm install
```
At project level (cd LoyaltyProgram):
```
  cd .. && dotnet run
```

For live reloading development run:
```
  cd .. && dotnet watch run
```

running application should automatically pick up a browser. If it does not then open up a favorite browser of choice and navigate to either http://localhost:5000 or https://localhost:5001

Note* If you are seing npm errors with rifraf and/or react-scripts run the following scripts in ClientApp folder:
```
  npm install rimraf --save-dev
  npm install react-scripts --save
```
Application uses react, .NET 5, Code first Entity Framework and SQLite.

To begin, navigate to https://localhost:5001/ then register. After registering you will comfirm your identity then see a confimation page.
From the confimation page now navigate to login and sign in with your user credentials. This will log you in and you will be able to see all 
of the nav items in the page. 

To view the database install a db client of choice. Since I am on mac I chose DBeaver and load the SQLite page.
