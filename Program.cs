/*
 Factory method define an interface for creating object.
 the subclasses can alter the type of objects that will be created.
 It relies on inheritance and polymorphism to add flexibility
 Using the Factory method pattern, we can defer the creation of an object to
 subclasses, and this is possible through inheritance.
 */



using Creational_Factory2;

OrdersController ordersController  = new OrdersController();
ordersController.ListOrders();
ordersController.GetOrder(1);