using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public Spy()
    {

    }
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        var classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic
            | BindingFlags.Public);
        Object classInstance = Activator.CreateInstance(classType, new object[] { });

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {investigatedClass}");
        foreach (var field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        var typeOfClass = Type.GetType(investigatedClass);
        var privateFields = typeOfClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        StringBuilder sb = new StringBuilder();

        foreach (var field in privateFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        var methodsGet = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var methodGet in methodsGet.Where(m => m.Name.Contains("get")))//or .StartsWith
        {
            sb.AppendLine($"{methodGet.Name} have to be public!");
        }

        var methodsSet = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        foreach (var methodSet in methodsSet.Where(m => m.Name.Contains("set"))) //or .StartsWith
        {
           sb.AppendLine($"{methodSet.Name} have to be private!");
        }
        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string investigatedClass)
    {
        var typeOfClass = Type.GetType(investigatedClass);
        var allPrivateMethods = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var baseClassName = typeOfClass.BaseType.Name;
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {investigatedClass}");
        sb.AppendLine($"Base Class: {baseClassName}");

        foreach (var privateMethod in allPrivateMethods)
        {
            sb.AppendLine(privateMethod.Name);
        }

        return sb.ToString().Trim();
    }
    public string CollectGettersAndSetters(string investigatedClass)
    {
        var typeOfClass = Type.GetType(investigatedClass);
        var allMethods = typeOfClass.GetMethods(BindingFlags.Instance | BindingFlags.Public
            | BindingFlags.NonPublic);
        StringBuilder sb = new StringBuilder();

        foreach (var method in allMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (var method in allMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return sb.ToString().Trim();
    }
}
