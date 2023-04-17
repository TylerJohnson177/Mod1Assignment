using System;

public class Add{

    public Talkable add(){
    
        string animal = "";

        while(animal != "Cat" && animal != "Dog"){

            Console.WriteLine("What type of animal would you like to create (Cat/Dog)");
            animal = Console.ReadLine();
            
        }

        string name;

        if(animal == "Cat"){
            Console.WriteLine("Enter a name for your Cat");
            name = Console.ReadLine();
            Console.WriteLine("How many mice did your cat eat?");
            int mice;
            try{
                mice = Int32.Parse(Console.ReadLine());
            }catch(Exception e){
                mice = 0;
            }

            return new Cat(mice, name);
        }
        else{
            Console.WriteLine("Enter a name for your Dog");
            name = Console.ReadLine();
            Console.WriteLine("Is your dog friendly? (y/n)");
            string friendlyInput = Console.ReadLine();
            bool friendly;
            
            if(friendlyInput.ToUpper() == "N"){
                friendly = false;
            }
            else{
                friendly = true;
            }

            return new Dog(friendly, name);
        }      

    }
}