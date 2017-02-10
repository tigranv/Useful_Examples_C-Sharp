# Using Threads <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

>### [**Threading**] (https://msdn.microsoft.com/en-us/library/mt679045.aspx) 

Threading enables your C# program to perform concurrent processing so that you can do more than one operation at a time.
For example, you can use threading to monitor input from the user, perform background tasks, and handle simultaneous streams of input.

Threads have the following properties:

* Threads enable your program to perform concurrent processing.

* The .NET Framework [System.Threading Namespace] (https://msdn.microsoft.com/en-us/library/system.threading(v=vs.110).aspx) makes using threads easier.

* Threads share the application's resources.

By default, a C# program has one thread. However, auxiliary threads can be created and used to execute code in parallel with the primary thread.These threads are often called worker threads. Worker threads can be used to perform time-consuming or time-critical tasks without tying up the primary thread. For example, worker threads are often used in server applications to fulfill incoming requests without waiting for the previous request to be completed. Worker threads are also used to perform "background" tasks in desktop applications so that the main thread--which drives user interface elements--remains responsive to user actions


> ### [**Thread Class**] (https://msdn.microsoft.com/en-us/library/system.threading.thread(v=vs.110).aspx) ( Creates and controls a thread, sets its priority, and gets its status)

When a process starts, the common language runtime automatically creates a single foreground thread to execute application code. Along with this main foreground thread, a process can create one or more threads to execute a portion of the program code associated with the process. These threads can execute either in the foreground or in the background. In addition, you can use the ThreadPool class to execute code on worker threads that are managed by the common language runtime.

***Starting a thread***

You start a thread by supplying a delegate that represents the method the thread is to execute in its class constructor. You then call the Start method to begin execution.
The Thread constructors can take either of two delegate types, depending on whether you can pass an argument to the method to be executed. If the method has no arguments, you pass a **ThreadStart** delegate to the constructor and **ParameterizedThreadStart** delegate If the method has an argument.
You can use the static **CurrentThread** property to retrieve a reference to the currently executing thread from the code that the thread is executing.


***Foreground and background threads***

Instances of the Thread class represent either foreground threads or background threads. Background threads are identical to foreground threads with one exception: a background thread does not keep a process running if all foreground threads have terminated. Once all foreground threads have been stopped, the runtime stops all background threads and shuts down.

> By default, the following threads execute in the foreground:

*The main application thread.*

*All threads created by calling a Thread class constructor.*

> The following threads execute in the background by default:

*Thread pool threads, which are a pool of worker threads maintained by the runtime. You can configure the thread pool and schedule work on thread pool threads by using the **ThreadPool** class.*

*All threads that enter the managed execution environment from unmanaged code.*

You can change a thread to execute in the background by setting the IsBackground property at any time. Background threads are useful for any operation that should continue as long as an application is running but should not prevent the application from terminating, such as monitoring file system changes or incoming socket connections.

***Getting information about and controlling threads***

You can retrieve a number of property values that provide information about a thread. In some cases, you can also set these property values to control the operation of the thread. These thread properties include:

* A name. Name is a write-once property that you can use to identify a thread. Its default value is null.

* A hash code, which you can retrieve by calling the GetHashCode method.

* A thread ID. The value of the read-only ManagedThreadId property is assigned by the runtime and uniquely identifies a thread within its process.

* The thread's current state. For the duration of its existence, a thread is always in one or more of the states defined by the ThreadState property.

* A scheduling priority level, which is defined by the ThreadPriority property. Although you can set this value to request a thread's priority, it is not guaranteed to be honored by the operating system.

* The read-only IsThreadPoolThread property, which indicates whether a thread is a thread pool thread.

* The IsBackground property. For more information, see the Foreground and background threads section.

### Using Threads and Threading

> Code Example

```c#
```





> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
