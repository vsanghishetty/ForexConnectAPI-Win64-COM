PrintTable application

Brief
==================================================================================
This sample shows how to get a table and print it.
The sample performs the following actions:
1. Login.
2. Print the accounts table.
3. Request the orders table refresh.
4. Print the orders table.
5. Logout.

Building the application
==================================================================================
In order to build this application you will need Java SDK 1.6 and Apache Ant.
You can download Java SDK from http://www.oracle.com/technetwork/java/javase/downloads
You can download Apache Ant from http://ant.apache.org/bindownload.cgi

Point your command prompt to the current directory and type: 
ant rebuild
For example,
C:\Program Files\CandleWorks\ForexConnectAPI\samples\java\NonTableManagerSamples\PrintTable>ant rebuild
This will generate directory structure .\build\classes\ and place compiled files there.

Running the application
==================================================================================
Change the build.xml file by putting your information in the arguments section.
For example, if your user name is 'testuser' change the line
<arg line="--login {LOGIN}" /> to <arg line="--login testuser" />.
Point your command prompt to the current directory and type:
ant run
For example,
C:\Program Files\CandleWorks\ForexConnectAPI\samples\java\NonTableManagerSamples\PrintTable>ant run
This will run the application and display the output on your console.

Arguments
==================================================================================
{LOGIN} - Your user name. Mandatory argument.
{PASSWORD} - Your password. Mandatory argument.
{URL} - The server URL. Mandatory argument.
        The URL must be full, including the path to the host descriptor.
        For example, http://www.fxcorporate.com/Hosts.jsp. 
{CONNECTION} - The connection name. Mandatory argument.
        For example, "Demo" or "Real".
{SESSIONID} - The database name. Optional argument.
        Required only for users who have a multiple database login.
        If you do not have one, leave this argument as it is.
{PIN} - Your pin code. Optional argument. Required only for users who have a pin.
        If a pin is not required, leave this argument as it is.