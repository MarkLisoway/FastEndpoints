using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("FastEndpoints")]

namespace FastEndpoints;

/// <summary>
/// marks a method as unimplemented when building an endpoint definition. 
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
public sealed class NotImplementedAttribute : Attribute { }