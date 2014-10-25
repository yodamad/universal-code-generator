using fr.jah.commons;
using fr.jah.utils;

namespace fr.jah.codegen;
{
    /// <summary>
    /// This a generated class.
    /// </summary>
    public interface IToto : Serializable, InitializingBean {

        /// <summary>
        /// This a method.
        /// </summary>
        /// <param name="param1">A parameter</param>
        /// <param name="param2">Another parameter</param>
        /// <returns>Something special</returns>
        int doSomething (String param1, Long param2);
	
        /// <summary>
        /// This another method.
        /// </summary>
        /// <returns>Something special</returns>
        void doAnotherSomething ();
	
    }
}
 