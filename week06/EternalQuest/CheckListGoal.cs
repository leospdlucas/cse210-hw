using System;

public class ChecklistGoal : Goal {
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points) {
    _target = target;
    _bonus = bonus;
    _amountCompleted = amountCompleted;
}

    // Idem SimpleGoal.cs... Murphy Law...
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent() {
        if (_amountCompleted < _target) {
            _amountCompleted++;
        }
    }

    public override bool IsComplete() {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation() {
        return $"ChecklistGoal:{_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
    }

    public override string GetDetailsString() {
        return $"{_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}
