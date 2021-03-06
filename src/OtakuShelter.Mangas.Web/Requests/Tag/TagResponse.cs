using System.Runtime.Serialization;

namespace OtakuShelter.Mangas
{
	[DataContract]
	public class TagResponse
	{
		public TagResponse()
		{
		}

		public TagResponse(Tag tag)
		{
			Id = tag.Id;
		}

		[DataMember(Name = "id")]
		public int Id { get; set; }
	}
}