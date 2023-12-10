using System.ComponentModel;
using System.Net;

usingSystem;
public class SimpleGoal()
{
    _name="Name of Simple Goal";
    _desc= "Description of Simple Goal";
    _goalPoints=65;
    _status=false;
}
public SimpleGoal(string name, string desc, int goalPoints,bool status)
{
    _name=name;
    _desc= description;
    _goalPoints=goalPoints;
    _status=status;
}
public override void CreateChildGoal()
{
    CreateFirstGoal();
}
public override void Record Event()
{
    if(_status==false){
        _status=true;
    }
    else{
        Console.Write("Goal Completed");
    }
}
public override bool IsComplete();
{
    if(_status==true){
        return true;
    }
    else{ 
        return false;
    }
}
public override void ListGoal()
{
    string statusSymbol="";
    bool status=IsComplete();
    if(status==true){
        statusSymbol="A";
    }
else{
    statusSymbol="";
}
   Console.Write($"[{statusSymbol}](_desc)") ;
}
public override int CalculateAGP()
{
    bool status=IsCompleteAGP()
    int aGP =0;
    if(status==true){
        aGP=_goalPoints;
    }
    else{
        aGP=0}
        return aGP;
}
public override string SaveGoal()

{
    string line="";
    line=$ "SimpleGoal:{_name},{_desc},{_goalPoints},{IsComplete().ToString()}";

return line;
}
}
