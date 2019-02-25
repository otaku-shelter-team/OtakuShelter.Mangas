using Phema.Routing;

namespace OtakuShelter.Manga
{
	public static class AuthorsControllerRoutes
	{
		public static IRoutingBuilder AddAuthorsController(this IRoutingBuilder builder, MangaRoleConfiguration roles)
		{
			builder.AddController<AuthorsController>(controller =>
			{
				controller.AddRoute("authors", c => c.Read(From.Query<FilterResponse>()))
					.HttpGet();
				
				controller.AddRoute("{mangaId}/authors",
						c => c.ReadById(From.Route<int>(), From.Query<FilterResponse>()))
					.HttpGet();
				
				controller.AddRoute("admin/authors", c => c.AdminCreate(From.Body<AdminCreateAuthorRequest>()))
					.HttpPost()
					.Authorize(roles.Admin);

				controller.AddRoute("admin/authors/{authorId}", c => c.AdminUpdate(From.Route<int>(), From.Body<AdminUpdateAuthorRequest>()))
					.HttpPut()
					.Authorize(roles.Admin);

				controller.AddRoute("admin/authors/{authorId}", c => c.AdminDelete(From.Route<AdminDeleteAuthorRequest>()))
					.HttpDelete()
					.Authorize(roles.Admin);
			});
			
			return builder;
		}
	}
}