Option Strict On
Option Explicit On

Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace My.Resources
    <GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),
        DebuggerNonUserCode(),
        CompilerGenerated(),
        HideModuleName()>
    Friend Module Resources
        Private resourceMan As ResourceManager

        Private resourceCulture As CultureInfo

        <EditorBrowsable(EditorBrowsableState.Advanced)>
        Friend ReadOnly Property ResourceManager() As ResourceManager
            Get
                If ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As ResourceManager = New ResourceManager("WPFRoundedCornerWindow.Resources",
                                                                      GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        <EditorBrowsable(EditorBrowsableState.Advanced)>
        Friend Property Culture() As CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = Value
            End Set
        End Property
    End Module
End Namespace
