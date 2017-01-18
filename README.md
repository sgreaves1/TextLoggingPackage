# TextLoggingPackage
A nuget package to add simple text file logging to C# applications 

To use install the package called SamsSimpleTextLogger.

To use you must first add the using statement for the package to your file.

image

Now you can call the Log function in the file. The Log function is static so can be called without the Logger class being created.

image

in the image above the Log function is being called with 2 strings and an enum. The first string is the message to display. The second is the application name. The enum is set to critical. This means the message will be logged under the critical category. Other catagories are availible such as Debug and Trace.

The categories work as like a logging level. what this means is that a less critical a log message can receive a lower priority category. For example the application starting or some data read from a file is not so important as an error. So these can be catorgrised as Trace level. By default the logging library wont log these trace messages. In order to do this you have to turn the priority down to trace before you call the log function. 

image of this

If the category is set to a lower priority than what the message relates too then it will be logged. for example if the logging level is set to Trace, all trace and debug and critical messages are logged. however if the logging level is set to Critical it will only log critical or higher priority messages. Following is an image of what levels there are to set the logging level to. Critical being the highest level.

image.

Following is an image of the text file the logger produces when using the above code snippets and logging level set to Trace.

![Alt text](https://cloud.githubusercontent.com/assets/7986716/22067719/5a9a464c-dd8a-11e6-91a9-15ee69a2364e.png "Log file")
