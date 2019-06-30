# CRM
#### How to Run


 1. Download the .zip file for the CRM project on github, you can do that using the green
 clone or download button in the top right hand corner of the Github repo page. Or you can just
 [click here](https://github.com/jhb15/CRM/archive/master.zip).
 
 2. Unzip the downloaded .zip file.

 3. Now open up a cmd window if you use windows and a terminal if you use a linux distro and then
 navigate to the unzipped folder.
 
 4. From there you need to go to the prebuilt binarys for your OS, here are the filepaths for each OS:
    * Windows: CRM/bin/Release/netcoreapp2.1/win10-x64/
    * Linux: CRM/bin/Release/netcoreapp2.1/ubuntu.16.10-x64/
 
 5. Now you will be able to run the application, but before you do that you need to tell it where to
 get the csv file to extract the data from. To do this you need to set the 'CRM_DATA_SRC_FILEPATH'
 environment variable to contain the path to the csv file you wish to use.
 
 6. Now you can run the application, these are the commands you use depending on your OS. 
    * Linux: ./CRM
    * Windows: CRM.exe

#### Notes

> The filepath will default to 'res/CustomerInformation.csv' if the filepath enviroment variable is
not set before running the application.

> The prebuilt binary for windows was built for windows 10 and the prebuilt binaries for linux were
built for ubuntu 16.10 but I have ran the linux binaries on an Arc Linux distribution so they may be okay
on other distributions.

#### Credits

> Built using the CsvHelper package, [CsvHelper](https://joshclose.github.io/CsvHelper/)
