namespace Models
{
	public class BaseEntity : object
	{
		public BaseEntity()
			: base()
		{
			Id = System.Guid.NewGuid();
		}

		// **********
		public System.Guid Id { get; set; }
		// **********
	}
}
