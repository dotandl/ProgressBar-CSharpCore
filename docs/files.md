# Files documentation for Progress Bar for C#

## Files
- [ProgressBarManager.cs](#ProgressBarManagercs)  
C# file contains ProgressBarManager class

## ProgressBarManager.cs
`class ProgressBarManager` (in `namespace ProgressBar`)  
Progress bar's management class

Members:
- `public static void SetProgressBar(byte percents, string text)`  
   Method displaying a progress bar

   Arguments
   - `percents` Percentage value which will be displayed
   - `text` Text which will be displayed at the start of widget

   Exceptions:
   - `ArgumentOutOfRangeException` Thrown when percents' value is more than 100
#
- `public static void SetProgressBar(byte percents, string text, string additionalText)`  
   Method displaying a progress bar with additional text

   Arguments:
   - `percents` Percentage value which will be displayed
   - `text` Text which will be displayed at the start of widget
   - `additionalText` Text which will be displayed in brackets as additional information

   Exceptions:
   - `ArgumentOutOfRangeException` Thrown when percents' value is more than 100
#
- `public static void ClearProgressBar()`  
   Method clearing a progress bar
#
- `public Task SetProgressIndicator(string text)`  
   Method displaying a progress indicator

   Arguments:
   - `text` Text which will be displayed at the start of widget
   - **Returns** Object of Task class for asynchronious working
#
- `public Task SetProgresIndicator(string text, string additionalText)`  
   Method displaying a progress indicator with additional text

   Arguments:
   - `text` Text which will be displayed at the start of widget
   - `additionalText` Text which will be displayed in brackets as additional information
   - **Returns** Object of Task class for asynchronious working
#
- `public Task UpdateProgressIndicator(string text)`  
   Method updating text on progress indicator

   Arguments:
   - `text` Text which will be displayed at the start of widget
   - **Returns** Object of Task class for asynchronious working
#
- `public Task UpdateProgressBar(string text, string additionalText)`  
   Method updating text and additional text on progress indicator

   Arguments:
   - `text` Text which will be displayed at the start of widget
   - `additionalText` Text which will be displayed in brackets as additional information
   - **Returns** Object of Task class for asynchronious working
#
- `public void ClearProgressBar()`  
   Method clearing a progress indicator