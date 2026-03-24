# Low Coupling: Program.cs has no direct access to data lists and any calcualtions. All of this handled by class RentalService. So all data and logic is in the safe place and if we want to change some calculations we can do it and it will no affect to Program.cs

# 

# Cohesin: classes Laptop, Projector, Camera extends class Equipment, each of the extending classes have common properties in Equipment and their own properties, same thing is for classes User and Student, Emploee. Also for example system handles equipment limits in  classes student and employee.

# 

# Class responsebilities: Each class(exept of RentalService) does his own job(dont knw what to say here, is better to just look yourself)


In my project we have 3 layers. First layer is data and calculation layer. Second layer is a connection layer between first and User interface layer(third layer). This is very nice because User cannot access any data or calculations and we can modify or add smth to first layer and this will not affect third layer. Only one thing I didn't do is to divide class RentalService into many small classes with their own methods, because pjatkslave is tired and in the task mentioned that we can do it in one class.
===

