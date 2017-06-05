using System;
namespace visibleTheList
{
	public class returnClass
	{
		
			
			public string smell { get; set; }


		public  returnClass( string Smell)
		{
			smell = Smell;


		}
		public string smellRM()
		{
			string smell1 = smell;
				return smell1;
		}
	}
}
