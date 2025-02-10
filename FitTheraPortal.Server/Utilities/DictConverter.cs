using System.Collections;

namespace FitTheraPortal.Server.Utilities;

public static class DictConverter
{
    public static IEnumerable<Dictionary<string, string?>> ConvertListToDicts<T>(IEnumerable<T> models) where T : class 
    {
        return models.Select(model => ConvertModelToDict<T>(model));
    }
    
    public static Dictionary<string, string?> ConvertModelToDict<T>(T model) where T : class
    {
        var dictionary = new Dictionary<string, string?>();

        foreach (var property in typeof(T).GetProperties())
        {
            var value = property.GetValue(model)?.ToString();
            dictionary.Add(property.Name, value);
        }

        return dictionary;
    } 
}