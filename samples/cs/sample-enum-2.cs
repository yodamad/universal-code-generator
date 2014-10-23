using System; // Required for the Flags attribute ([Flags] --> System.FlagAttribute)

namespace Sample.CSharp
{
    public enum ColorComponent
    {
        A = 1, 
		R, // is 2
		G, // is 3
		B = 25 // is... 25
    }
	
	[Flags]
    public enum Direction : byte
    {
		Unknown = 0,
		North = 1,
		South = 2,
		East = 4,
		West = 8,
    }
	
	internal class SampleUsage
	{
		private void Foo()
		{
			var direction = Direction.South | Direction.East; // the value for direction is 6.
		}
	}
}
