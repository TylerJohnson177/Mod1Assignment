public class Cat : Talkable{
    private int _mousesKilled;
    private string _name;

    public Cat(int mousesKilled, string name){
        _name = name;
        _mousesKilled = mousesKilled;
    }

    public int GetMousesKilled(){
        return _mousesKilled;
    }

    public string GetName(){
        return _name;
    }

    public void AddMouse(){
        _mousesKilled ++;
    }

    public string Talk(){
        return "Meow";
    }

    public override string ToString()
    {
        return "Cat: " + "name: " + _name + " mousesKilled: " + _mousesKilled;
    }
}