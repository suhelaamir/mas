# mas
Table of Contents for technology used

1.	Dependency Inversion Principle (DIP)
2.	Inversion of Control (IoC) Pattern
3.	Dependency Injection (DI)
4.	Dependency Injection (DI) Container

Contact List Application Design
	a. Define Entities in Application
	b. Define Context Class
	c. Define Mapping of Entities
	d. Create Generic Repository
	e. Create Service for User Operations

An MVC Application Using the IoC and DI
	a. Ninject Dependency Injection Container
	b. The Operations Model and Controller
	c. Create / Edit Contact View
	d. Contact List View
	e. Contact Detail View
	f. Delete Contact(once you delete the contact then the contact will be in database with status false)

Contact List application
we are listing all(active and inactive) contacts on the Contact List landing page.
We have the section like “Actions” to => Edit | Details | Inactive/Active. 
Here we are displaying as “InActive” action for the Active contact to make it as inactive.
And for Inactive contact we are displaying the “Active” action to make the contact as active.  

Database Info.
We have copied and paste the database backup(bak file) at below location in the same application folder. 
Please see below database bak file path.
Root folder path: EvolentContactList\DatabaseBAK_File
Application folder Path: EvolentContactList\ECL.Web\App_Data

How to run the application.
1) Download the application folder and restore the database bak file at your local machine.
2) Change the connection string as per SQL server at your machine.
3) Run the MVC application ECL.Web. you can host the ECL.Web application in IIS or run directly from visual studio 2015.
 


