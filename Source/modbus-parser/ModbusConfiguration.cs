using System.Text.Json;
using System.Text.Json.Serialization;

public class ModbusConfiguration
{
    private List<FunctionParameters> parameters = new List<FunctionParameters>();
    private const string fileName = "function-parameters.json";

    public ModbusConfiguration()
    {
            string jsonString = File.ReadAllText(fileName);
            parameters = JsonSerializer.Deserialize<List<FunctionParameters>>(jsonString)!;
    }

    public FunctionParameters? GetFunctionParameters(string address)
    {
        return parameters.FirstOrDefault(p => p.Address == address);
    }
}
public class FunctionParameters
{
    public String? Name { get; set; }
    public String? Address { get; set; }
    public String? Description { get; set; }
    public String? Unit {get;set;}
    public int? Multiplier {get;set;}

}
