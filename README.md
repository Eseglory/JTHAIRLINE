
## Whats Including In This Repository
We have implemented below **features over the run-aspnetcore-microservices repository**.

#### Catalog microservice which includes; 
* ASP.NET Core Web API application 
* REST API principles, CRUD operations 
* **Mongo DB NoSQL database** connection on docker
* N-Layer implementation with Repository Pattern
* Swagger Open API implementation
* Dockerfile implementation

#### Basket microservice which includes;
* ASP.NET Core Web API application 
* REST API principles, CRUD operations 
* **Redis** connection as a Database on docker
* Redis connection implementation
* **RabbitMQ trigger event queue** when checkout cart
* Swagger Open API implementation
* Dockerfile implementation

#### RabbitMQ messaging library which includes;
* Base **EventBus implementation** and add references Microservices

#### Ordering microservice which includes; (over the catalog specs)
* ASP.NET Core Web API application 
* **Entity Framework Core on SQL Server** docker
* REST API principles, CRUD operations 
* **Consuming RabbitMQ** messages
* **Clean Architecture** implementation with CQRS Design Pattern
* Event Sourcing
* Implementation of MediatR, Autofac, FluentValidator, AutoMapper
* Swagger Open API implementation
* Dockerfile implementation

#### API Gateway Ocelot microservice which includes;
* **Routing** to inside microservices
* Dockerization api-gateway

#### WebUI ShoppingApp microservice which includes;
* Asp.net Core Web Application with Razor template
* Call **Ocelot APIs** with **HttpClientFactory**
* Aspnet core razor tools - View Components, partial Views, Tag Helpers, Model Bindings and Validations, Razor Sections etc.. 

#### Docker Compose establishment with all microservices on docker;
* Dockerization of microservices
* **Dockerization** of database
* Override Environment variables
