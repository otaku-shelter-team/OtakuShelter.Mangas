using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Phema.Routing;

namespace OtakuShelter.Manga
{
	public static class TranslatorsControllerRoutes
	{
		public static IRoutingBuilder AddTranslatorsController(this IRoutingBuilder builder)
		{
			builder.AddController<TranslatorsController>("translators", controller =>
			{
				controller.AddRoute(c => c.Create(From.Body<CreateTranslatorViewModel>()))
					.HttpPost()
					.Authorize();

				controller.AddRoute(c => c.Read(From.Query<FilterViewModel>()))
					.HttpGet();

				controller.AddRoute("{translatorId}", c => c.Update(From.Route<int>(), From.Body<UpdateTranslatorViewModel>()))
					.HttpPut()
					.Authorize();

				controller.AddRoute("{translatorId}", c => c.Delete(From.Route<DeleteTranslatorViewModel>()))
					.HttpDelete()
					.Authorize();
			});
			
			return builder;
		}
	}
}