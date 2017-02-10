# Using Threads <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

>### [**Threading**] (https://msdn.microsoft.com/en-us/library/mt679045.aspx) 

Threading enables your C# program to perform concurrent processing so that you can do more than one operation at a time.
For example, you can use threading to monitor input from the user, perform background tasks, and handle simultaneous streams of input.

Threads have the following properties:

* Threads enable your program to perform concurrent processing.

* The .NET Framework [System.Threading] (https://msdn.microsoft.com/en-us/library/system.threading(v=vs.110).aspx) namespace makes using threads easier.

* Threads share the application's resources.

By default, a C# program has one thread. However, auxiliary threads can be created and used to execute code in parallel with the primary thread.
These threads are often called worker threads. Worker threads can be used to perform time-consuming or time-critical tasks without tying up the primary thread.
For example, worker threads are often used in server applications to fulfill incoming requests without waiting for the previous request to be completed.
Worker threads are also used to perform "background" tasks in desktop applications so that the main thread--which drives user interface elements--remains responsive to user actions


>### [**Thread Class**] (https://msdn.microsoft.com/en-us/library/system.threading.thread(v=vs.110).aspx) 

Creates and controls a thread, sets its priority, and gets its status.

| Method Name  | Description |
| -------------------------------------------------| ------------------------------------------------------------------------------- |
| **Equals**(Object)| (**virtual**) Determines whether the specified object is equal to the current object. | 
| **ToString**() | (**virtual**) Returns a string that represents the current object.| 
| **GetHashCode**() | (**virtual**) Serves as the default hash function.| 
| **GetType**() | (**virtual**) Gets the Type of the current instance. | 
| **MemberwiseClone**() | (**protected**) Creates a shallow copy of the current Object. | 
| **ReferenceEquals**(Object, Object) | (**static**) Determines whether the specified Object instances are the same instance.| 
| **Equals**(Object, Object) | (**static**) Determines whether the specified object instances are considered equal. | 
|  **Object**()| constructor. | 
| **~Object**()| (**protected**)Finalizer: Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. | 




> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
