//-----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Matt Lacey (http://mrlacey.co.uk/)">
//     Copyright © 2009 Matt Lacey
//     All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("StringToNumberUnitTests")] 
[assembly: AssemblyTitle("StringToNumber")]
[assembly: AssemblyDescription("Library for parsing numbers in their written form into their numeric equivalent.")]
[assembly: AssemblyCompany("Matt Lacey")]
[assembly: AssemblyProduct("StringToNumber")]
[assembly: AssemblyCopyright("Copyright © Matt Lacey (http://mrlacey.co.uk) 2009")]
[assembly: NeutralResourcesLanguage("en-GB")]
[assembly: CLSCompliant(false)] // sbyte, ushort, uint & uint aren't CLS Compliant so this library isn't either
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("0.9.10.71")]
[assembly: AssemblyFileVersion("0.9.10.71")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "StringToNumber")]
