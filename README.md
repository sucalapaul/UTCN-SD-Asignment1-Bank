UTCN-SD-Asignment1-Bank
=======================


UTCN
Computer Science Department
Software Design2012/2013

ASSIGNMENT A1
====================================================================
1.  Objective
The objective of this assignment is to allow students to become familiar with architectural patterns.

2.	Application Description
Use Swing/C# API to design and implement an application for the front desk employees of a bank. The application should have two types of users (a regular user represented by the front desk employee and an administrator user) which have to provide a username and a password in order to use the application.
The regular user can perform the following operations:
-	Add/update/view client information (name, identity card number, personal numerical code, address, etc.).
-	Create/update/delete/view client account (account information: identification number, type, amount of money, date of creation).
-	Transfer money between accounts.
-	Process utilities bills.
The administrator user can perform the following operations:
-	CRUD on employees’ information.
-	Generate reports for a particular period containing the activities performed by an employee.

3.	Application Constraints
The data will be stored in a database. Use the Layers architectural pattern to organize your application. Use a domain logic pattern (transaction script or domain model) / a data source hybrid pattern (table module, active record) and a data source pure pattern (table data gateway, row data gateway, data mapper) most suitable for the application.

4.	Requirements
-	Create the analysis and design document (see the template).
-	Implement and test the application.

5.	Deliverables
-	Analysis and design document.
-	Implementation source files.

6.	References
Martin Fowler et. al, Patterns of Enterprise Application Architecture, Addison Wesley, 2003
http://java.sun.com/docs/books/tutorial/uiswing/
http://java.sun.com/j2se/1.4.2/docs/api/javax/swing/package-summary.html
http://www.exampledepot.com/egs/?
http://java.sun.com/docs/books/tutorial/jdbc/basics/index.html
http://msdn.microsoft.com/en-us/library/54xbah2z(VS.80).aspx
http://msdn.microsoft.com/en-us/library/e80y5yhx(VS.80).aspx


