using Sample.CSharp.Logging;

namespace Sample.CSharp
{
    /// <summary>
    /// Defines the various kinds of sites
    /// </summary>
    public enum SiteKind
    {
        Undefined,
        Central,
        Mobile,
        SemiConnected
    }

    public static class SiteKindHelper
    {
        private static readonly ILogService log = LogManager.GetLogger(typeof(SiteKindHelper));
		
        /// <summary>
        /// Parses the specified string into a <see cref="SiteKind"/> value.
        /// </summary>
        /// <param name="kind">The string to parse.</param>
        /// <returns>
        /// The <see cref="SiteKind"/> value matching the input string or <see cref="SiteKind.Undefined"/>
        /// if the string could not be recognized.
        /// </returns>
        public static SiteKind Parse(string kind)
        {
            if (string.IsNullOrEmpty(kind))
            {
                log.Error("No Site Type defined. Returning 'Undefined' Site Kind.");
                return SiteKind.Undefined;
            }

            // Here, we recognize different string values.
            var normalized = kind.ToLowerInvariant().Trim();
            switch (normalized)
            {
                case "undefined":
                    return SiteKind.Undefined;

                case "central": 
                    return SiteKind.Central;

                case "mobile": 
                    return SiteKind.Mobile;

                case "distant":
                case "semiconnected":
                    return SiteKind.SemiConnected;
            }

            // otherwise, log an error and return undefined.
            log.Error(string.Format("Unknown Site Kind '{0}'. Returning 'Undefined' Site Kind.", kind));
            return SiteKind.Undefined;
        }
    }
}
