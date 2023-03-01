// I ran a dotnet run to build and run me code and I was still getting an error and this was because I haven't written my C# code file
// Yes I wroote my C# project file(.csproj) but C# wasn't seeing the Main method which will be an entrypoint for my compiler to be able to compile my code
// TIME to write my C# code file

using System;
using System.Collections.Generic;

class Hello{
    static void Main(){
        Console.WriteLine("Hello World!");
        Console.WriteLine("YAY! My first Program in C#");
    }

}