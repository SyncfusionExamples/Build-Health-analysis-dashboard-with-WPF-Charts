# Creating a Health Tracker App with Syncfusion WPF Chart Controls

## Overview

The Personal Wellness Tracker dashboard uses Syncfusion® WPF controls to centralize calories, activity, hydration, and sleep metrics. Users see trends instantly and use chart interactions to refine daily habits.

## Syncfusion WPF SfChart

This high-performance [charting library](https://help.syncfusion.com/wpf/charts/getting-started) is designed for WPF applications and offers rich data visualization capabilities. It supports various chart types, making it ideal to creating a Health Tracker App . With built-in interactivity features such as zooming, panning, tooltips, and exporting, users can explore complex datasets with ease. 


## Personal Wellness Tracker dashboard

### Layout overview

The shell uses three grid rows:

- **Title bar**: “Personal Wellness Tracker” icon + user profile.

- **Navigation tiles**: Calories, Steps, Water, Sleep.

- **Content host**: ContentControl that swaps in each module.

## Health Modules 

### Calories Consumed Page

**Purpose:** Show real-time and historical nutritional intake.

**Components:**
- **Quick Metrics:**  
  - Badge 1: Today's calorie count  
  - Badge 2: Daily average

- **Weekly Trend Chart:**  
  - Line chart showing daily calorie intake  
  - Interactive tooltip for exact values  
  - Annotated target line for recommended daily intake

- **Macro Nutrients Section:**  
  - A doughnut chart displays the distribution of: Fat, Fibre, Carbs, Calcium, Protein, Vitamins.

- **Meal Selector Buttons:**  
  - Interactive buttons: Breakfast, Lunch, Dinner, Snacks  
  - Switch between meals to view detailed nutrient data

## Steps Taken Page

**Purpose:** Provide a comprehensive view of daily and weekly physical activity.

**Components:**
- **Quick Metrics:**  
  - Badge 1: Today's step count  
  - Badge 2: Weekly average

- **Weekly Trend Chart:**  
  - Column chart showing daily step counts  
  - Interactive tooltip for exact values  
  - Annotated target line for daily step goal

- **Activity Panel:**  
  - Nested doughnut charts comparing:  
    - Steps  
    - Exercise Minutes  
    - Active Hours  
  - Center label: Calories burned  
  - Tooltips on hover for precise values  
  - Quick stats: Completed steps, exercise duration, active hours

## Water Consumed Page

**Purpose:** Track hydration patterns and progress toward daily goals.

**Components:**
- **Quick Metrics:**  
  - Badge 1: Daily water target  
  - Badge 2: Weekly average

- **Weekly Trend Chart:**  
  - Line chart showing daily water intake  
  - Interactive tooltip for exact values  
  - Annotated target line at 7 liters

- **Activity Panel:**  
  - Column chart showing hourly water consumption  
  - Two compact progress cards:  
    - Daily goal  
    - Amount consumed so far

## Sleep Duration Page

**Purpose:** Visualize sleep patterns and quality metrics.

**Components:**
- **Quick Metrics:**  
  - Badge 1: Sleep goal  
  - Badge 2: Daily average

- **Weekly Trend Chart:**  
  - Bubble chart representing each day  
  - Bubble size indicates hours slept  
  - Interactive tooltip for exact values

- **Sleep Quality Panel:** 
  - Doughnut chart showing total sleep hours  
  - Bedtime and wake time indicators  
  - Four compact cards showing:  
    - Deep sleep minutes  
    - Light sleep minutes  
    - REM sleep minutes  
    - Awake minutes

![Personal Wellness Tracker](https://github.com/user-attachments/assets/07ca26e6-ea5d-4791-a655-e48b22979f12)

## Troubleshooting

### Path Too Long Exception

If you are facing a **path too long** exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.**Path too long** exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

### Phase 1: Calories and Steps Tracking

Refer to the blog for step-by-step guidance on [visualizing calories burned and steps taken in the Health Tracker dashboard](https://www.syncfusion.com/blogs/post/wpf-health-tracker-chart-calories-steps).

### Phase 2: Water and Sleep Tracking (Coming Soon)

Refer to the blog for step-by-step guidance on visualizing  water consumption and sleep duration in the Health Tracker dashboard.
