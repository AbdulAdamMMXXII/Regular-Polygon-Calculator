# Regular Polygon Calculator

## Overview
The Regular Polygon Calculator is a C# console-based application designed to calculate the **perimeter** and **area** of regular polygons with a number of sides ranging from **3 to 10**. The program follows fundamental C# programming principles and was developed using **Visual Studio IDE**.

## Features
- Supports regular polygons with 3–10 sides  
- Calculates perimeter and area accurately  
- Uses constants for mathematical precision  
- Rounds results to two decimal places  
- Input validation with clear error messages  
- User-friendly console interface  
- Looping functionality to perform multiple calculations  

## Technologies Used
- C#  
- .NET Console Application  
- Visual Studio IDE  

## How the Program Works
1. The program displays a welcome message and usage note.
2. The user is prompted to enter:
   - Length of one side
   - Units of measurement
   - Number of sides (between 3 and 10)
3. Invalid inputs are detected and handled gracefully.
4. The program calculates:
   - **Perimeter** = number of sides × length
   - **Apothem** using trigonometric functions
   - **Area** = (Perimeter × Apothem) ÷ 2
5. Results are displayed with appropriate units.
6. The user can choose to repeat or exit the program.

## Sample Output  
The perimeter of your 5-sided regular polygon is 25.00 cm.  
The area of your 5-sided regular polygon is 43.01 cm².  


## Input Validation
- Only integer values between **3 and 10** are accepted for polygon sides.
- Exception handling ensures the program does not crash on invalid input.

## Future Improvements
- Support for polygons with more than 10 sides  
- Graphical user interface (GUI)  
- Improved mathematical precision using `Math.PI`  

## Author
Developed by **Abdulrazig Adam** as part of C# programming practice.

## Licence
This project is intended for educational purposes.
