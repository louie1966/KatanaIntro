using Owin;

namespace KatanaIntro {
    public class Startup {
        public void Configuration(IAppBuilder app) {
            app.UseWelcomePage();
            //app.Run(ctx => {
            //    return ctx.Response.WriteAsync("Hello world!");
            //});
        }
    }
}
