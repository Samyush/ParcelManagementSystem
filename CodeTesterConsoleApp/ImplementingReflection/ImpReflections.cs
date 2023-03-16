using System.Reflection;

namespace CodeTesterConsoleApp.ImplementingReflection;

public class ImpReflections
{
    public ImpReflections()
    {
        Type? T = Type.GetType("CodeTesterConsoleApp.ImplementingReflection.MethodForImpReflection");
        Console.WriteLine("Full name = {0}", T?.FullName);
        Console.WriteLine("Name = {0}", T?.Name);
        Console.WriteLine("Namespace = {0}", T?.Namespace);

        Console.WriteLine("Properties in MethodForImpReflection");
        PropertyInfo[]? properties = T?.GetProperties();
        if (properties != null)
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

        MethodInfo[]? methods = T?.GetMethods();
        if (methods != null)
            foreach (MethodInfo methodInfo in methods)
            {
                Console.WriteLine(methodInfo.ReturnType.Name + " " + methodInfo.Name);
            }
    }
}

public class MethodForImpReflection
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string Method1()
    {
        return "hello";
    }

    public int Method2()
    {
        return 5 + 5;
    }
}