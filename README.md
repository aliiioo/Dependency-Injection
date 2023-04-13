# Dependency-Injection-DI-
In this project, we are going to learn how to use Dependency Injection and how is it

Dependency Injection (DI) is a software design pattern that allows us to develop loosely coupled code.
DI is a great way to reduce tight coupling between software components.
DI also enables us to better manage future changes and other complexity in our software

example:
Suppose your Client class needs to use two service classes, then the best you can do is to make your Client class aware of abstraction i.e. IService interface rather than implementation i.e. Service1 and Service2 classes. In this way, you can change the implementation of the IService interface at any time (and for how many times you want) without changing the client class code
