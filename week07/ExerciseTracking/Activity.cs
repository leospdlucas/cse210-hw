using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENT: Allow switching between kilometers and miles.
public enum UnitType {
    Kilometers,
    Miles
}

public abstract class Activity {
    private DateTime _date;
    private int _lengthMinutes;

    public static UnitType Unit { get; set; } = UnitType.Kilometers;

    public Activity(DateTime date, int lengthMinutes) {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    protected double ConvertDistanceIfNeeded(double distanceKm) {
        return Unit == UnitType.Kilometers ? distanceKm : distanceKm * 0.62;
    }

    protected string GetDistanceUnit() {
        return Unit == UnitType.Kilometers ? "km" : "miles";
    }

    public int GetMinutes() => _lengthMinutes;
    public DateTime GetDate() => _date;

    public abstract double GetDistance();  // in km
    public abstract double GetSpeed();     // in kph or mph
    public abstract double GetPace();      // min per km or mi

    // EXCEEDING REQUIREMENT: emojis and styled output.
    public virtual string GetSummary() {
        double distance = ConvertDistanceIfNeeded(GetDistance());
        double speed = ConvertDistanceIfNeeded(GetSpeed());
        double pace = GetPace();

        string unit = GetDistanceUnit();
        string emoji = this is Running ? "🏃" :
                       this is Cycling ? "🚴" :
                       this is Swimming ? "🏊" : "🏋️";

        return $"{emoji} {GetDate():dd MMM yyyy} {this.GetType().Name} ({GetMinutes()} min): "
                + $"Distance: {distance:F2} {unit}, Speed: {speed:F1} {(unit == "km" ? "kph" : "mph")}, "
                + $"Pace: {pace:F2} min per {unit}";
    }
}