Module NetworkingModule
    Private NetClassInstance As NetworkingClass

    Public Function GetNetworkingClassInstance() As NetworkingClass
        If NetClassInstance Is Nothing Then
            NetClassInstance = New NetworkingClass
        End If
        GetNetworkingClassInstance = NetClassInstance
    End Function
End Module
