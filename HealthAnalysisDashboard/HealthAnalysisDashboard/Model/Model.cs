using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HealthAnalysisDashboard
{
    public class CalorieEntry
    {
        public string? Day { get; set; }

        public int Calories { get; set; }
    }

    public class MacroNutrient
    {
        public string? Name { get; set; }
    
        public int Amount { get; set; }


        public Brush? Color { get; set; }
    }


    public class FitnessMetric
    {
        public string? Category { get; set; }
        public double Value { get; set; }
        public double Goal { get; set; }
    }


    public class WaterConsumption
    {
        public string? Day { get; set; }
        public double Liters { get; set; }
    }


    public class StepCount
    {
        public string? Day { get; set; }
        public int Steps { get; set; }
    }

    public class DailyWaterConsumption
    {
        public string? Time { get; set; }     
        public double Milliliters { get; set; }   
    }

    public class SleepEntry
    {
        public string? Day { get; set; }
        public double Hours { get; set; }
    }

    public class SleepActivity
    {
        public string? SleepType { get; set; }

        public double Hours { get; set; }
    }
}
