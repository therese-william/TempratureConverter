# Temprature Converter
## Application design
### The application consists of the following projects:

#### 1. Buisiness Layer: TempratureConverter.BL
This is resposible of doing all the business logic which is the calculations in our application, it consists of a model and service classes
1. Temprature.cs is the model, it has celsius, fahrenhite and kelvin variables, setting one of the variables will automatically calculate the other 2.
2. Temprature service interface, where we have only 3 methods to get the temprature using each type of the variables.

#### 2. Unit Testing project: TempratureConverter.Tests
Unit tests to ensure the calculations are correct when setting each temprature type.

#### 3. Web API Layer: TempratureConverter.Web
The web project has the following:
1. Web Api (TempratureController) which has 3 methods to calculate temprature by celsius, fahrenhite and kelvin, and to be used by the UI or angular project
2. Publish profile to publish the web application on IIS, also different profiles can be added for different desitnations (Azure, deploy package, ...)

#### 4. UI Layer: TempratureConverter.UI
This is the Angular project consists of:
1. temprature model in shared folder used to be filled by the api calls to get the temprature by all types.
2. temprature service used to call the web api methods and retrieve the temprature model.
3. The temprature service is injected into and used by the app.component.
4. I set the output for the angular project to the (wwwroot) folder of the (TempratureConverter.Web) project
5. In (TempratureConverter.Web) project file, added a pre build command to build the angular prject to it'll be published in the wwwroot folder and index.html will be created before the api project is built

## Steps to run the application
1. Clone the solution in visual studio using the url: https://github.com/therese-william/TempratureConverter.git
2. Navigate to angular project path: [repository path]\TempratureConverter.UI\temprature-converter from cmd and run command "npm install"
3. Open TempratureConverter.sln solution in visual studio, run TempratureConverter.Web project, this will build the angular project and will show the tempraure converter application in the browser
