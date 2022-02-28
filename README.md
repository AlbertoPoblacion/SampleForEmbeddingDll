# SampleForEmbeddingDll
A sample project that shows how to embed a DLL inside a .NET executable

The solution contains two projects: a Console executable and a class library that is called by the executable.

It is just an example; the library simply returns a string and the console displays it to demonstrate that the call to the library succeeded.

The library is Referenced from the executable so that you can compile calls to its members. If you run the project from Visual Studio, the referenced dll will be loaded from the binaries folder.

But if you copy the .exe to another folder, just by itself, and run it from there, it will still run. This is thanks to a copy of the DLL that is embedded as a resource.

Note that the embedding is not dynamic, i.e., if you modify the class library you need to re-embed it in the .resx file.
