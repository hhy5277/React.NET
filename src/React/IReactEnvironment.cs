﻿namespace React
{
	/// <summary>
	/// Request-specific React.NET environment. This is unique to the individual request and is 
	/// not shared.
	/// </summary>
	public interface IReactEnvironment
	{
		/// <summary>
		/// Executes the provided JavaScript code.
		/// </summary>
		/// <param name="code">JavaScript to execute</param>
		void Execute(string code);

		/// <summary>
		/// Executes the provided JavaScript code, returning a result of the specified type.
		/// </summary>
		/// <typeparam name="T">Type to return</typeparam>
		/// <param name="code">Code to execute</param>
		/// <returns>Result of the JavaScript code</returns>
		T Execute<T>(string code);

		/// <summary>
		/// Creates an instance of the specified React JavaScript component.
		/// </summary>
		/// <typeparam name="T">Type of the props</typeparam>
		/// <param name="componentName">Name of the component</param>
		/// <param name="props">Props to use</param>
		/// <returns>The component</returns>
		IReactComponent CreateComponent<T>(string componentName, T props);

		/// <summary>
		/// Renders the JavaScript required to initialise all components client-side. This will 
		/// attach event handlers to the server-rendered HTML.
		/// </summary>
		/// <returns>JavaScript for all components</returns>
		string GetInitJavaScript();

		/// <summary>
		/// Transform the specified JSX into regular JavaScript
		/// </summary>
		/// <param name="input">JSX</param>
		/// <returns>JavaScript</returns>
		string TransformJsx(string input);
	}
}