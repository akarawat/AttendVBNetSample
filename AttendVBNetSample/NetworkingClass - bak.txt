Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Public Class NetworkingClass
    Private WinsockClient As TcpClient
    Private gReceivedBytes As Integer
    Private gServerIP As String
    Private gServerPort As Integer

    Public Function ConnectToServer(ByVal serverIP As String, ByVal serverPort As Integer, ByVal timeOut As Integer) As Integer
        Try
            gServerIP = serverIP
            gServerPort = serverPort

            WinsockClient = New TcpClient()
            WinsockClient.Connect(serverIP, serverPort)
            Return If(WinsockClient.Connected, 0, -1)
        Catch ex As Exception
            Console.WriteLine("Error: {0}", ex.Message)
            Return -1
        Finally

        End Try
        Return -1
    End Function

    Public Sub CloseConnect()
        If WinsockClient IsNot Nothing Then
            WinsockClient.Close() ' Close any existing connection
        End If
    End Sub

    Public Sub ReConnect()
        CloseConnect()
        ConnectToServer(gServerIP, gServerPort, 3000)
    End Sub

    Public Function SendCommand(ByVal cmdData As String) As Integer
        ' This function is used to send data
        Dim customStruct As CustomStructure
        customStruct.field1 = Len(cmdData)
        customStruct.field2 = DEVICE_ID
        customStruct.field3 = 0

        ' Ensure Field4 is exactly 20 bytes long or pad with zeros
        customStruct.field4 = New Byte(20) {}

        Dim structBytes() As Byte = StructureToByteArray(customStruct)

        If WinsockClient.Connected Then
            Dim networkStream As NetworkStream = WinsockClient.GetStream()
            networkStream.Write(structBytes, 0, structBytes.Length)
            Dim cmdBytes() As Byte = Encoding.ASCII.GetBytes(cmdData)
            networkStream.Write(cmdBytes, 0, cmdBytes.Length)
            Return 0
        Else
            Return -1
        End If
    End Function

    Public Function ReceiveData() As String
        Dim nRecvLen As Integer

        If WinsockClient.Connected Then
            Dim receivedData(32) As Byte
            WinsockClient.GetStream().Read(receivedData, 0, receivedData.Length)
            nRecvLen = ProcessReceivedData(receivedData)
        Else
            nRecvLen = -1
        End If

        Dim nTimeOut As Integer = 0

        If nRecvLen > 0 AndAlso WinsockClient.Connected Then
            Dim receivedJSonData(nRecvLen - 1) As Byte
            WinsockClient.GetStream().Read(receivedJSonData, 0, CInt(nRecvLen))

            Dim strReceivedData As String
            strReceivedData = Encoding.UTF8.GetString(receivedJSonData)

            If (strReceivedData.Length <> nRecvLen) Then
                Return ""
            End If

            Return strReceivedData
        Else
            Return ""
        End If
    End Function

    Private Function ProcessReceivedData(data() As Byte) As Integer
        ' Assuming the structure is 4 bytes, 4 bytes, 4 bytes, and 20 bytes
        Dim field1 As Int32
        Dim field2 As Int32

        'Dim field4(19) As Byte
        field1 = BitConverter.ToInt32(data, 0)
        field2 = BitConverter.ToInt32(data, 4)

        If field2 <> DEVICE_ID Then
            Return -1
        Else
            Return field1
        End If
    End Function

    Private Function StructureToByteArray(customStruct As CustomStructure) As Byte()
        Dim size As Integer = Marshal.SizeOf(customStruct)
        Dim buffer(size - 1) As Byte
        Dim handle As IntPtr = Marshal.AllocHGlobal(size)
        Marshal.StructureToPtr(customStruct, handle, True)
        Marshal.Copy(handle, buffer, 0, size)
        Marshal.FreeHGlobal(handle)
        Return buffer
    End Function

    Private Structure CustomStructure
        Public field1 As Int32
        Public field2 As Int32
        Public field3 As Int32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)>
        Public field4() As Byte
    End Structure
End Class
