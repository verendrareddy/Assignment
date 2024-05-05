// See https://aka.ms/new-console-template for more information
using Test;
MyClass obj = new MyClass();

//Question1
obj.Q1_Even_odd_Sum();

//Question2
Product obj1 = new Product();
double Disounted_Price =obj1.Price -
    obj1.Price * 0.2;
Product obj2 = new Product(obj1.ProductId, Disounted_Price, obj1.ProductName);
obj2.DisplatData();
//Console.WriteLine(Disounted_Price);


//question3
obj.Q2_Pattern();


