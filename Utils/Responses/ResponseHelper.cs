namespace waifu_simulator.Utils.Responses;

public static class ResponsesHelper {
    public static ApiResponses<T> success<T>(T data , string message = "success"){
        return new ApiResponses<T>{
            success = true,
            message = message,
            data = data
        };
    }

    public static ApiResponses<T> error<T>(string message , Dictionary<string , string> errors = null){
        return new ApiResponses<T>{
            success = false,
            message = message,
            errors = errors ?? new Dictionary<string, string>()
        };
    }
}