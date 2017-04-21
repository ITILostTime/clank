# clank
A repository to test a .Net MVC application and a NodeJs SPA. The objective is to test the building, testing, versionning and deployment of the test application.

## Functonality
The project only display a JS button calling a Rest API that print a bip into the .NET console.

# Technologies

## .NET
One part of the test project is a .NET MVC application. 2 or more NuGet package will be added.

## NodeJS
The second part of the test project is a NodeJJ compiled application. 2 or more package will be added. The package gestion is made by Yarn.

# Build process

The build will be done by Travis. He will restore the Nuget and Yarn Package, then build the .NET and NodeJS package. Then he will test wih NUnit and JTest the api. Finaly if the test passes, he will update the release repository, pack the project and send an happy message. :)