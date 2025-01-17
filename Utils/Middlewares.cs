using waifu_simulator.Middlewares;

namespace waifu_simulator.Utils;

public static class Middlewares {
    public static void CustomMiddleware(this IApplicationBuilder app){
        app.UseMiddleware<Example>();
    }
}