using System;
public class CheckGoals:CheckGoals{
    private int_extraPoints;
    private int_steps;
    private int_stepCounter;
    public CheckGoals()
{

}
public CheckGoals(string name,string description,int goalPoints,int bonusPoints, int steps, int stepCounter)
{
    _name=name;
    _desc=description;
    _steps=steps;
    _stepCounter;
    _bonusPoints=bonusPoints;
}
public override void CreateChildGoal()
{
    CreateMainGoal();
    Console.Write(Times require to get extrabonus?");
    string stringcheckGoalstSteps=Console.ReadLine();
    _step=CoverToInt32(stringCheckGoals);
    Console.Write("What is the price/bonus ?");
    string bonusPoints=Console.ReadLine();
    _bonusPoints=Convert.ToInt32(bonusPoints);
    _stepCounter=0;

}
public override bool IsComplete()
{
    if(_stepCounter>=_steps)
    {
        return true;

    }
    else{
        return false;
    }
}
public override int CalculateAGP()
{
    int points=0;
    points=_stepCounter*_goalPoints;
    bool status=IsComplete();
    if (status==true){
        points+=_bonusPoints;
    }
    return points;
}
public override void ListGoal()
{
    string levelSymbol="";
    bool status=IsComplete();
    if (status==true){
        statusSymbol="A";
    }
    else{
        statusSymbol="";

    }
    Console.Write($"[{statusSymbol}] {-name} ({_desc})--completed{_stepCounter}/{_steps}");
}
public override string saveGoal()
{
    string line="";
    line=$"CheckGoal:"+_name +", ",_desc+","_goalPoints.ToString()+","+_bonusPoints.ToString()+","_steps.ToString()+"."+_stepCounter.ToStrins();
    return line;
}
}