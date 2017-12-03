Imports Nancy

Public Class Routes : Inherits NancyModule

    Public Sub New()

        [Get]("/hello") = Function() "Hello"
        [Get]("/") = Function() View("main.html")

    End Sub

End Class
