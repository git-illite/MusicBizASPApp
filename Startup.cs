using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(F2022A6AA.Startup))]

namespace F2022A6AA
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
