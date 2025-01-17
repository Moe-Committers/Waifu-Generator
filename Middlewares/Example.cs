namespace waifu_simulator.Middlewares;

public class Example{
    private readonly RequestDelegate _next;
    private readonly ILogger<Example> _logger;
    public Example(RequestDelegate next , ILogger<Example> logger){
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context){
        if(context.Request.Path.StartsWithSegments("/api/example")){
            _logger.LogInformation("hellow from this middleware <3");
        }
        await _next(context);
    }
}