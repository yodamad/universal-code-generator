using System;
using Foo.Business;

namespace Sample.CSharp
{
    /// <summary>
    /// Interface for Engines that can drive a Business Process execution.
    /// </summary>
    public interface IBusinessProcessEngine : IDisposable
    {
        /// <summary>
        /// Occurs when the engine current state changes.
        /// </summary>
        event EventHandler StateChanged;
        
        /// <summary>
        /// Gets the type of the business process (ie. its string id).
        /// </summary>
        string BusinessProcessName { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is running.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is running; otherwise, <c>false</c>.
        /// </value>
        bool IsRunning { get; }

        /// <summary>
        /// Gets the current state of the business process.
        /// </summary>
        BusinessProcessState State { get; }
        
        /// <summary>
        /// Gets the input data passed to to the business process.
        /// </summary>
        BusinessProcessEngineInputData Input { get; }

        /// <summary>
        /// Gets the output received from the business process execution.
        /// </summary>
        BusinessProcessEngineOutputData Output { get; }

        /// <summary>
        /// Initializes the engine for the specified business process.
        /// </summary>
        /// <param name="businessProcessType">The business process.</param>
        void Initialize(string businessProcessType);

        /// <summary>
        /// Executes the specified action (with the optional input data).
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="input">The input data.</param>
        /// <returns>Output data that is the result of the action execution.</returns>
        BusinessProcessEngineOutputData ExecuteAction(
            BusinessProcessAction action,
            BusinessProcessEngineInputData input = null);
    }
}
