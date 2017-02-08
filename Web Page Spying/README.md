#Web Page Spying   <img src="https://cloud.githubusercontent.com/assets/24522089/21962098/41a510c8-db36-11e6-95ef-eb392a0a1919.png" align="right" width="130px" height="130px" /> 

> ### Example of using  Exeption handling, IDisposable interface(IDisposable Pattern), and IO

The Class WebSpy provides an opportunity to get all **URL**-s, from web page, and write them in txt document, creats document of content of web page **cleaned from html tags**, and downloads **all pictures to folder**.

![webspy](https://cloud.githubusercontent.com/assets/24522089/22568638/04730a4e-e9ae-11e6-9c86-c977235a33bf.gif)

### IDisposable interface(IDisposable Pattern)
The primary use of this interface is to release unmanaged resources. The garbage collector automatically releases the memory allocated to a managed object when that object is no longer used. However, it is not possible to predict when garbage collection will occur. Furthermore, the garbage collector has no knowledge of unmanaged resources such as window handles, or open files and streams.
<br>
The CLR provides some help in releasing unmanaged resources. System.Object declares a virtual method Finalize (also called the finalizer) that is called by the GC before the object’s memory is reclaimed by the GC and can be overridden to release unmanaged resources. Types that override the finalizer are referred to as finalizable types.
<br>
Although finalizers are effective in some cleanup scenarios, they have two significant drawbacks:
<br>
* The finalizer is called when the GC detects that an object is eligible for collection. This happens at some undetermined period of time after the resource is not needed anymore. The delay between when the developer could or would like to release the resource and the time when the resource is actually released by the finalizer might be unacceptable in programs that acquire many scarce resources (resources that can be easily exhausted) or in cases in which resources are costly to keep in use (e.g., large unmanaged memory buffers).
* When the CLR needs to call a finalizer, it must postpone collection of the object’s memory until the next round of garbage collection (the finalizers run between collections). This means that the object’s memory (and all objects it refers to) will not be released for a longer period of time.
<br>
Therefore, relying exclusively on finalizers might not be appropriate in many scenarios when it is important to reclaim unmanaged resources as quickly as possible, when dealing with scarce resources, or in highly performant scenarios in which the added GC overhead of finalization is unacceptable.
<br>
The Framework provides the System.IDisposable interface that should be implemented to provide the developer a manual way to release unmanaged resources as soon as they are not needed. It also provides the GC.SuppressFinalize method that can tell the GC that an object was manually disposed of and does not need to be finalized anymore, in which case the object’s memory can be reclaimed earlier. Types that implement the IDisposable interface are referred to as disposable types.
<br>
> The **Dispose Pattern** is intended to standardize the usage and implementation of finalizers and the IDisposable interface.

### Basic Dispose Pattern

The basic implementation of the pattern involves implementing the System.IDisposable interface and declaring the Dispose(bool) method that implements all resource cleanup logic to be shared between the Dispose method and the optional finalizer.

```c#
public class DisposableResourceHolder : IDisposable {  
  
    private SafeHandle resource; // handle to a resource  
  
    public DisposableResourceHolder(){  
        this.resource = ... // allocates the resource  
    }  
  
    public void Dispose(){  
        Dispose(true);  
        GC.SuppressFinalize(this);  
    }  
  
    protected virtual void Dispose(bool disposing){  
        if (disposing){  
            if (resource!= null) resource.Dispose();  
        }  
    }  
}
```
<br>
> This project written on C# 6.0, .NET Framework 4.6 Visual Studio 2015 Comunity Edition
