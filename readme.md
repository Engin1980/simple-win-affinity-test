# Simple (FS) Win Affinity Test

## Explanation
This app sets the affinity for all the accessible processes in the Win OS. The specific process can have set a different affinity than the other ones. It is useful to preserve the custom cores for the specific process(es) and the other cores for the rest.

## Motivation
This app was created to check if a reservation of specific cores for FS2020 can increase its performance. Short answer: no.

## Installation
Download the ZIP from the Release page and unzip it. Run the .exe file. The .NET framework is required.

## Usage
Run the application. It is suggested to run the app in administrator mode, otherwise, many running processes will not be accessible for the app.
Then:
1. Set the name of the selected process(es). If you know, you can use the regular expression in the text field. The name is case-sensitive.
2. Check the corresponding check-boxes for each of your core. The first row is for the selected processes, the second row is for the other processes.
3. Press the 'Apply' button and wait for the finish (may take a while).
4. Check the result in the grid.

![App demo screen](fatw.png)

The affinity of the processes is set until the OS restart or until another update.
