using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HealthAnalysisDashboard
{

    public class ViewModel 
    {
        public ObservableCollection<CalorieEntry> CalorieData { get; set; }

        public ObservableCollection<MacroNutrient> MacroNutrients { get; set; }

        public ObservableCollection<StepCount> StepsData { get; set; }

        public ObservableCollection<FitnessMetric> Steps { get; set; }

        public ObservableCollection<FitnessMetric> Exercise { get; set; }

        public ObservableCollection<FitnessMetric> ActiveHours { get; set; }

        public ObservableCollection<WaterConsumption> WaterConsumedData { get; set; }

        public ObservableCollection<SleepEntry> SleepData { get; set; }

        public ObservableCollection<DailyWaterConsumption> DailyWaterConsumedData { get; set; }

        public ObservableCollection<SleepActivity> SleepActivityData { get; set; }

        public ViewModel()
        {
            CalorieData =
            [
                new CalorieEntry { Day = "Sunday", Calories = 1200 },
                new CalorieEntry { Day = "Monday", Calories = 1800 },
                new CalorieEntry { Day = "Tuesday", Calories = 2850 },
                new CalorieEntry { Day = "Wednesday", Calories = 1900 },
                new CalorieEntry { Day = "Thursday", Calories = 2500 },
                new CalorieEntry { Day = "Friday", Calories = 1650 },
                new CalorieEntry { Day = "Saturday", Calories = 1300 },
            ];

            MacroNutrients =
            [
                new MacroNutrient { Name = "Fat",      Amount = 30,  Color = (SolidColorBrush)new BrushConverter().ConvertFrom("#7AB9DD")! },
                new MacroNutrient { Name = "Fibre",    Amount = 30,  Color = (SolidColorBrush)new BrushConverter().ConvertFrom("#5A9AC6")! },
                new MacroNutrient { Name = "Carbs",    Amount = 130, Color = (SolidColorBrush)new BrushConverter().ConvertFrom("#428BBA")! },
                new MacroNutrient { Name = "Calcium",  Amount = 260, Color = (SolidColorBrush)new BrushConverter().ConvertFrom("#20699C")! },
                new MacroNutrient { Name = "Protein",  Amount = 40,  Color = (SolidColorBrush)new BrushConverter().ConvertFrom("#0E5585")! },
                new MacroNutrient { Name = "Vitamins", Amount = 60,  Color = (SolidColorBrush)new BrushConverter().ConvertFrom("#033466")! }
            ];

            StepsData =
            [
                new StepCount { Day = "Sunday", Steps = 8000 },
                new StepCount { Day = "Monday", Steps = 6000 },
                new StepCount { Day = "Tuesday", Steps = 10000},
                new StepCount { Day = "Wednesday", Steps = 5000 },
                new StepCount { Day = "Thursday", Steps = 7000 },
                new StepCount { Day = "Friday", Steps = 8000 },
                new StepCount { Day = "Saturday", Steps = 6000 }
            ];


            Steps = new ObservableCollection<FitnessMetric>
            {
                new FitnessMetric { Category = "Progress", Value = 2869, Goal = 9000 },
                new FitnessMetric { Category = "Remaining", Value = 6131, Goal = 9000 }
            };

            Exercise = new ObservableCollection<FitnessMetric>
            {
                new FitnessMetric { Category = "Progress", Value = 21, Goal = 30 },
                new FitnessMetric { Category = "Remaining", Value = 9, Goal = 30 }
            };

            ActiveHours = new ObservableCollection<FitnessMetric>
            {
                new FitnessMetric { Category = "Progress", Value = 5, Goal = 8 },
                new FitnessMetric { Category = "Remaining", Value = 3, Goal = 8 }
            };

            WaterConsumedData =
            new ObservableCollection<WaterConsumption>
            {
                new WaterConsumption { Day = "Sunday", Liters = 4 },
                new WaterConsumption { Day = "Monday", Liters = 5 },
                new WaterConsumption { Day = "Tuesday", Liters = 6 },
                new WaterConsumption { Day = "Wednesday", Liters = 6.5 },
                new WaterConsumption { Day = "Thursday", Liters = 7.5 }, 
                new WaterConsumption { Day = "Friday", Liters = 6 },
                new WaterConsumption { Day = "Saturday", Liters = 5.5 }
            };


            DailyWaterConsumedData = new ObservableCollection<DailyWaterConsumption>
            {
                new DailyWaterConsumption { Time = "00:00", Milliliters = 300 },
                new DailyWaterConsumption { Time = "03:00", Milliliters = 610 },
                new DailyWaterConsumption { Time = "06:00", Milliliters = 910 },
                new DailyWaterConsumption { Time = "09:00", Milliliters = 760 },
                new DailyWaterConsumption { Time = "12:00", Milliliters = 610 },
                new DailyWaterConsumption { Time = "15:00", Milliliters = 460 },
                new DailyWaterConsumption { Time = "18:00", Milliliters = 670 },
                new DailyWaterConsumption { Time = "21:00", Milliliters = 850 },
                new DailyWaterConsumption { Time = "24:00", Milliliters = 370 }
            };

            SleepData = new ObservableCollection<SleepEntry>
            {
                new SleepEntry { Day = "Sunday",    Hours = 9 },
                new SleepEntry { Day = "Monday",    Hours = 6 },
                new SleepEntry { Day = "Tuesday",   Hours = 6 },
                new SleepEntry { Day = "Wednesday", Hours = 7 },
                new SleepEntry { Day = "Thursday",  Hours = 8 },
                new SleepEntry { Day = "Friday",    Hours = 5 },
                new SleepEntry { Day = "Saturday",  Hours = 9 }
            };


            SleepActivityData = new ObservableCollection<SleepActivity>
            {
                new SleepActivity { SleepType = "Light", Hours = 4.5 },
                new SleepActivity { SleepType = "Deep",  Hours = 2.5 },
                new SleepActivity { SleepType = "REM",   Hours = 2.0 },
                new SleepActivity { SleepType = "Awake", Hours = 0.5 }
            };

        }

        public void UpdateMacroNutrients(IEnumerable<MacroNutrient> newData)
        {
            MacroNutrients.Clear();
            foreach (var item in newData)
            {
                MacroNutrients.Add(item);
            }
        }
    }
}


