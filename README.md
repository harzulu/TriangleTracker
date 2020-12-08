# Triangle Tracker

#### Check to see what kind of triangle is from 3 given sides, 12.08.2020

#### By Ben McFarland

## Description

This application will take in 3 side lengths and tell the user which type of triangle that would be.

## Technologies used

* Microsoft Visual Studio Code
* Git/GitHub
* C# v 7.3
* .NET Core v 2.2
* REPL
* MSTest

## Installation Requirements

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/ping-pong], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/dani-t-codes/ping-pong.git`.


#### Installing C#, .NET, dotnet script, & MySQL

###### This program requires C# and the .NET Framework to be installed on your machine:

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download this 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :---------------------------- |
| **Returns the three user input numbers** | 3, 2, 8 | `3, 2, 8` |
| **Returns if there are at least 2 of the same number** | 2, 2, 8 | `true` |
| **Returns if there are 3, 2, or none of the same number** | 3, 3, 8 | `2` |
| **Returns the largest number** | 3, 2, 8 | `8` |
| **Returns if the two smallest numbers' sum is less than the largest number** | 3, 2, 8 | `true` |

### Tests

Describe: allNum(nums)
Test: Return all the user inputted numbers
Expect: allNum(3, 4, 8).toEqual(3, 4, 8)

Describe: duplicates(nums)
Test: Return if there are any duplicates of any number
Expect: duplicates(3, 3, 8).toEqual(true)

Describe: numOfDuplicates(nums)
Test: Return if there are 3, 2, or no duplicates of a number
Expect: numOfDuplicates(3, 3, 8).toEqual(2)

Describe: largestNum(nums)
Test: Returns the largest number
Expect: largestNum(3, 4, 8).toEqual(8)

Describe: smallerSum(nums)
Test: Returns if the two smallest numbers add up to less than the largest num
Expect: smallerSum(3, 4, 8).toEqual(true)

## Bugs / Issues

No known bugs or issues

### License & Copyright

_MIT_ Copyright (c) 2020 *_Ben McFarland_**