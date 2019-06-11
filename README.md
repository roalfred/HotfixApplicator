# Hotfix Applicator
Written in C#, application allows system administrators who may not have access to the domain controller or group policy server, to install pre downloaded hotfix files to one or multiple computers over the network.



## Requirements
The user of this application must have the necessary privilaged at the domain or local level to install hotfixes on the computers.  Hotfix Applicator must be run as administrator.

This application also requires PSExec.exe to remotely execute the install.  It is included with the source code and in the compiled folder, or you can download it from Microsoft.  Only PSExec.exe is needed.

Successfully tested on Windows 7 Pro workstations in a domain environment.



## Usage
1.  Download and compile the source code or just use the precompiled application in the Compiled folder.
2.  Ensure that PSExec.exe is in the same folder of the HotfixApplicator.exe or globaly accessable on the system.
3.  Run HotfixApplicator as administrator
4.  Choose the type of installation: Single, Range, or List
4.1 If list is selected, ensure that the IPs are in a text file and one IP per line
5.  Select the hotfix and choose the delivery option: Report Only, Skip If Installed and Force Restart
5.1 If the KB number is not displayed after selecting Report Only or Skip If Instaled, manually enter it.  Its needed for those functions.
6.  Choose domain or local authentication and enter the credentials.  These are for the remote workstation install.
7.  Click Start.  Feedback will be shown in the feedback area.  

The application will appear to be hung during the execution but this because it may be copying the hotfix over to the computer and then executing the install.  Upon completion of all workstatioins in the list, the word "done!" will be dilplayed in the feedback area. 



## Next Improvements
1.  Better feedback.  I am working on a progress bar and improved user feedback
2.  Code Documentation.  Better in-code docmentation
3.  Parrallel Installations.  Having the application spin up at least 4 simultainious installs 



## Contributions
Pull requests are welcome.
