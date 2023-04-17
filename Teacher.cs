public class Teacher: Talkable{
    private int _age;
    private string _name;

    public Teacher(int age, string name){
        _name = name;
        _age = age;
    }

    public int GetAge(){
        return _age;
    }

    public void SetAge(int age){
        age = _age;
    }

    public string Talk(){
        return "Don't forget to do the assigned reading!";
    }

    public string GetName(){
        return _name;
    }

    public void SetName(string name){
        name = _name;
    }

    public override string ToString()
    {
        return "Teacher: " + "name: " + _name;
    }
}