namespace waifu_simulator.Utils.Responses;

public class ApiResponses<T> {
    public bool success {get; set;}
    public string message {get; set;}
    public T data {get; set;}
    public Dictionary<string , string> errors {get; set;}
}