using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Car{
    private string make;
    private string model;
    public int Year { get; set;}
    

     //a getter is a function the returns a strin
    public string GetMake(){
        return make;
    }

    //a setter is something that can change the value of a private value
    public void SetMake(string newMake){
        if(newMake.Length == 0){
            //thow an error
        }
        make = newMake;
    }

    public Car(string make, string model){
        this.make = make;
        this.model = model;

        
    }

    public void PrintsDetails(){
        System.Console.WriteLine($"{make} {model}");
        //try to keep the data private and then make them public as you need them
        //idealy data does not become public, only functions and variables
    }
}

