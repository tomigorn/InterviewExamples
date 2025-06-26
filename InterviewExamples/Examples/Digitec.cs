using System; 
using System.Collections.Generic; 
 
static class ExerciseCustomDict 
{ 
    public static void Run() 
    { 
        //throw new Exception("Hey, don't mind me. I'm only here to stop the code from running."); 
       
        var dvd1 = new DefaultValueDictionary<string, string>(); 
        var val1 = dvd1["item1"]; 
       
        Console.WriteLine($"{val1}"); 
       
        string defaultFunction() => "FileForYou"; 
       
        var dvd2 = new DefaultValueDictionary<string, string>(defaultFunction); 
        var val2 = dvd2["item1"]; 
         
      Console.WriteLine($"{val2}"); 
       
        string keyValueFunction(string key) => $"FileForYou: {key}"; 
       
        var dvd3 = new DefaultValueDictionary<string, string>(defaultFunction, keyValueFunction); 
        var val3 = dvd3["item1"]; 
       
        Console.WriteLine($"{val3}"); 
    } 
} 
// Default Value Dictionary 
public class DefaultValueDictionary<TKey, TValue> : Dictionary<TKey, TValue> 
{ 
    public DefaultValueDictionary( 
        Func<TValue> defaultValueFunction = null, 
        Func<TKey, TValue> keyValueFunction = null) 
    { 
        DefaultValueFunction = defaultValueFunction; 
        KeyValueFunction = keyValueFunction; 
    } 
     
    public Func<TValue> DefaultValueFunction { get; set; } 
    public Func<TKey, TValue> KeyValueFunction { get; set; } 
     
    public new TValue this[TKey key] 
    { 
        get 
        { 
            if (!TryGetValue(key, out var ret)) 
            { 
                if (KeyValueFunction != null) 
                { 
                    ret = (this[key] = KeyValueFunction.Invoke(key)); 
                } 
                else if (DefaultValueFunction != null) 
                { 
                    ret = (this[key] = DefaultValueFunction.Invoke()); 
                } 
            } 
            return ret; 
        } 
        set => base[key] = value; 
    } 
} 