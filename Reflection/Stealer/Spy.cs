using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class Spy
{
    public string StealFieldInfo(string nameOfClass, params string[] namesOfFields)
    {
        var classType = Type.GetType(nameOfClass);
        var classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        var sb = new StringBuilder();

        var classinstanse = Activator.CreateInstance(classType, new object[] { });
        sb.AppendLine($"Class under investigation: {nameOfClass}");

        foreach (var field in classFields)
        {
            if (namesOfFields.Contains(field.Name))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classinstanse)}");
            }

        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);

        var getfields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
        var getPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        var getNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var field in getfields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var method in getNonPublicMethods)
        {
            if (method.Name.StartsWith("get"))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
        }

        foreach (var method in getPublicMethods)
        {
            if (method.Name.StartsWith("set"))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        var sb = new StringBuilder();
        var classType = Type.GetType(className);
        var classMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classMethods)
        {
            sb.AppendLine($"{method.Name}");
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        var sb = new StringBuilder();

        var classType = Type.GetType(className);
        var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var method in methods)
        {
            if (method.Name.StartsWith("get"))
            {
                sb.AppendLine($"{method.Name} will return {method.ReturnType}");
            }       
        }

        foreach (var method in methods)
        {
            if (method.Name.StartsWith("set"))
            {
                sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
        }

        return sb.ToString().Trim();
    }
}
