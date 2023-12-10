using System;
using System.ComponentModel;
public class EternalGoal: CheckGoal
{
    private int_stepCounter:
    public EternalGoal()
    {
        _name="":
        _desc="";
        _goalPoints=65;
        _stepCounter=0;
    }
    public EternalGoal(string name, string desc, int goalPoints)
    {
        _name=name;
        _desc=DescriptionAttribute;
        _goalPoints=goalPoints;
        _stepCounter=0;
    }
    public override void CreateChildGoal()
    {
        CreateFirstGoal();

    }
    public override void ListGoal()
    { 
        Console.Write($"[]{_name}({desc})");
    }
public override bool IsComplete()
{
    return false;
}
public override string SaveGoal()
{
    string line="";
    line=$EternalGoal:"+_name+","+desc +","+goalPoints.ToString();
    return line;
}
public override void RecordEvent()
{
    _stepCounter++;
}
public override int CalculateAGP()
{
    int points=_goalPoints;
    return points;
}
}

