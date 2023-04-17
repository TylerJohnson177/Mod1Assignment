public class Dog : Talkable{
    private bool _friendly;
    private string _name;

    public Dog(bool friendly, string name){
        _name = name;
        _friendly = friendly;
    }

    public bool IsFriendly(){
        return _friendly;
    }
    public string GetName(){
        return _name;
    }

    public string Talk(){
        return "Bark";
    }

    public override string ToString(){
        return "Dog: " + "Name: " + _name + " Friendly: " + _friendly; 
    }
}