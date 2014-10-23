using System.Collections.Generic; // Required for IReadOnlyDictionary<K, V> and Dictionary<K, V>

namespace Sample.CSharp
{
	public static class SimpleConstants
	{
		// Compile-time constant
		public const double PI = 3.141592657;
		
		// Prefer 'static readonly' over 'const' for values that may change
		public static readonly double Vat = 20.0; 
		
		// simple string 'constant'
		public static readonly string DefaultCulture = "fr-FR";
		
		// private static readonly int maxCount = 300;
		private const int maxCount = 300; // private constants are ok
		
		// Exposes the private constant as a read-only property.
		public static int MaxCount
		{
			get { return maxCount; }
		}
		
		// Array 'constant'
		public static readonly string[] WellKnownCultures = new[] { "fr-FR", "en-US" };

        // Anything can be 'static readonly'
        // For complex initializations, use the static constructor.
        public static readonly IReadOnlyDictionary<int, string> NumbersAsString;

        // In C#, we do not have multiple static initialization blocks as exists in Java, but only one static constructor.
        // If static fields reference each other, it is best to initialize all of them in the static constructor:
        // This is because the C# compiler does not guarantee the static initializations order.
        static SimpleConstants()
		{
			var dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "Zero");
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            NumbersAsString = dictionary;
		}	
	}
}