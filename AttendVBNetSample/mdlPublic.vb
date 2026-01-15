Module mdlPublic
    
    ' ===============================================================================
    ' Win32 API Functions
    ' ===============================================================================

    Public Const RETRY_COUNT = 3
    Public Const DEVICE_ID = &H18181818

    '//=============== Error code ===============//
    Public Const RUN_SUCCESS = 0
    Public Const RUNERR_DEVICE_BUSY = 1
    Public Const RUNERR_DEVICE_WORKING = 2
    Public Const RUNERR_DEVICE_WORKING_COMPLETE = 3
    Public Const RUNERR_ERROR = -1
    Public Const RUNERR_PARAMETER_ERROR = -2
    Public Const RUNERR_TIMEOUT_ERROR = -3
    Public Const RUNERR_COMMUNICATION_ERROR = -4
    Public Const RUNERR_FULL_DEVICE_CAPACITY = -5

    ' ===============================================================================
    ' Error processing
    ' ===============================================================================

    'If colNum = 1 Or colNum = 2 Or colNum = 3 Or colNum = 4 Or colNum = 9 Or colNum = 10 Then

    Public Const USER_NAME_INX = 1
    Public Const USER_PRIVILEGE_INX = 2
    Public Const USER_CARD_INX = 3
    Public Const USER_PWD_INX = 4
    Public Const USER_PHOTO_INX = 8
    Public Const USER_VAILDSTART_INX = 9
    Public Const USER_VAILDEND_INX = 10


    Public Const gstrNoDevice = "No Device"

    Public Const USER_ID = "userId"
    Public Const USER_NAME = "name"
    Public Const USER_PRIVILEGE = "privilege"
    Public Const USER_CARD = "card"
    Public Const USER_PASSWORD = "pwd"
    Public Const USER_FPS = "fps"
    Public Const USER_FP1 = "fp1"
    Public Const USER_FP2 = "fp2"
    Public Const USER_FP3 = "fp3"
    Public Const USER_FP4 = "fp4"
    Public Const USER_FP5 = "fp5"
    Public Const USER_FP6 = "fp6"
    Public Const USER_FP7 = "fp7"
    Public Const USER_FP8 = "fp8"
    Public Const USER_FP9 = "fp9"
    Public Const USER_FP10 = "fp10"
    Public Const USER_FACE = "face"
    Public Const USER_PALM = "palm"
    Public Const USER_PHOTO = "photo"
    Public Const USER_VAILDSTART = "vaildStart"
    Public Const USER_VAILDEND = "vaildEnd"
    Public Const USER_TIMEGROUPS = "timeGroups"

    Public Const USER_UPDATE = "update"
    Public Const PHOTOENROLL = "photoEnroll"


    Public Const SUNDAY = "sun"
    Public Const MONDAY = "mon"
    Public Const TUESDAY = "tue"
    Public Const WEDNESDAY = "wed"
    Public Const THURDAY = "thu"
    Public Const FRIDAY = "fri"
    Public Const SATURDAY = "sat"

    Public Const PERSONAL_VERIFY = 1
    Public Const FC_OR_FP_OR_C_OR_P = 2
    Public Const P_AND_FC_OR_FP = 3
    Public Const C_AND_FC_OR_FP = 4
    Public Const FP_AND_FC = 6


    Public Const LANGUAGE_EN = "en"
    Public Const LANGUAGE_CHS = "CHS"
    Public Const LANGUAGE_CHT = "CHT"
    Public Const LANGUAGE_KR = "KR"
    Public Const LANGUAGE_TH = "th"
    Public Const LANGUAGE_JA = "ja"
    Public Const LANGUAGE_TR = "tr"
    Public Const LANGUAGE_ES = "es"
    Public Const LANGUAGE_ESAR = "es-AR"
    Public Const LANGUAGE_PT = "pt"
    Public Const LANGUAGE_PTBR = "pt-BR"
    Public Const LANGUAGE_ID = "id"
    Public Const LANGUAGE_DE = "de"
    Public Const LANGUAGE_FA = "fa"
    Public Const LANGUAGE_AR = "ar"
    Public Const LANGUAGE_VI = "vi"



    Function ReturnResultString(anResultCode As Integer) As String
        Select Case anResultCode
            Case RUN_SUCCESS
                ReturnResultString = "Success"
            Case RUNERR_DEVICE_BUSY
                ReturnResultString = "Device is busy"
            Case RUNERR_DEVICE_WORKING
                ReturnResultString = "Device is working"
            Case RUNERR_DEVICE_WORKING_COMPLETE
                ReturnResultString = "Device working is completed"
            Case RUNERR_ERROR
                ReturnResultString = "Error"
            Case RUNERR_PARAMETER_ERROR
                ReturnResultString = "Parameter error"
            Case RUNERR_TIMEOUT_ERROR
                ReturnResultString = "Timeout error"
            Case RUNERR_COMMUNICATION_ERROR
                ReturnResultString = "Communication error"
            Case RUNERR_FULL_DEVICE_CAPACITY
                ReturnResultString = "Full device capacity"
            Case Else
                ReturnResultString = "Unknown error"
        End Select
    End Function


    Function GetVerifyModeCmbInxByValue(Value As Integer) As Integer
        Select Case Value
            Case PERSONAL_VERIFY
                GetVerifyModeCmbInxByValue = 0
            Case FC_OR_FP_OR_C_OR_P
                GetVerifyModeCmbInxByValue = 1
            Case P_AND_FC_OR_FP
                GetVerifyModeCmbInxByValue = 2
            Case C_AND_FC_OR_FP
                GetVerifyModeCmbInxByValue = 3
            Case FP_AND_FC
                GetVerifyModeCmbInxByValue = 4
            Case Else
                GetVerifyModeCmbInxByValue = 1
        End Select
    End Function

    Function GetVerifyValueByComboInx(index As Integer) As Integer
        Select Case index
            Case 0
                GetVerifyValueByComboInx = PERSONAL_VERIFY
            Case 1
                GetVerifyValueByComboInx = FC_OR_FP_OR_C_OR_P
            Case 2
                GetVerifyValueByComboInx = P_AND_FC_OR_FP
            Case 3
                GetVerifyValueByComboInx = C_AND_FC_OR_FP
            Case 4
                GetVerifyValueByComboInx = FP_AND_FC
            Case Else
                GetVerifyValueByComboInx = FC_OR_FP_OR_C_OR_P
        End Select
    End Function


    Function GetLanguageCmbInxByValue(Value As String) As Integer
        Select Case Value
            Case LANGUAGE_EN
                GetLanguageCmbInxByValue = 0
            Case LANGUAGE_CHS
                GetLanguageCmbInxByValue = 1
            Case LANGUAGE_CHT
                GetLanguageCmbInxByValue = 2
            Case LANGUAGE_KR
                GetLanguageCmbInxByValue = 3
            Case LANGUAGE_TH
                GetLanguageCmbInxByValue = 4
            Case LANGUAGE_JA
                GetLanguageCmbInxByValue = 5
            Case LANGUAGE_TR
                GetLanguageCmbInxByValue = 6
            Case LANGUAGE_ES
                GetLanguageCmbInxByValue = 7
            Case LANGUAGE_ESAR
                GetLanguageCmbInxByValue = 8
            Case LANGUAGE_PT
                GetLanguageCmbInxByValue = 9
            Case LANGUAGE_PTBR
                GetLanguageCmbInxByValue = 10
            Case LANGUAGE_ID
                GetLanguageCmbInxByValue = 11
            Case LANGUAGE_DE
                GetLanguageCmbInxByValue = 12
            Case LANGUAGE_FA
                GetLanguageCmbInxByValue = 13
            Case LANGUAGE_AR
                GetLanguageCmbInxByValue = 14
            Case LANGUAGE_VI
                GetLanguageCmbInxByValue = 15
            Case Else
                GetLanguageCmbInxByValue = 0
        End Select
    End Function

    Function GetLanguageValueByComboInx(index As Integer) As String
        Select Case index
            Case 0
                GetLanguageValueByComboInx = LANGUAGE_EN
            Case 1
                GetLanguageValueByComboInx = LANGUAGE_CHS
            Case 2
                GetLanguageValueByComboInx = LANGUAGE_CHT
            Case 3
                GetLanguageValueByComboInx = LANGUAGE_KR
            Case 4
                GetLanguageValueByComboInx = LANGUAGE_TH
            Case 5
                GetLanguageValueByComboInx = LANGUAGE_JA
            Case 6
                GetLanguageValueByComboInx = LANGUAGE_TR
            Case 7
                GetLanguageValueByComboInx = LANGUAGE_ES
            Case 8
                GetLanguageValueByComboInx = LANGUAGE_ESAR
            Case 9
                GetLanguageValueByComboInx = LANGUAGE_PT
            Case 10
                GetLanguageValueByComboInx = LANGUAGE_PTBR
            Case 11
                GetLanguageValueByComboInx = LANGUAGE_ID
            Case 12
                GetLanguageValueByComboInx = LANGUAGE_DE
            Case 13
                GetLanguageValueByComboInx = LANGUAGE_FA
            Case 14
                GetLanguageValueByComboInx = LANGUAGE_AR
            Case 15
                GetLanguageValueByComboInx = LANGUAGE_VI
            Case Else
                GetLanguageValueByComboInx = LANGUAGE_EN
        End Select
    End Function

    Public Function IsValidTimeString(inputString As String) As Boolean
        Dim parts() As String
        Dim startTime As String
        Dim endTime As String
        Dim validFormat As Boolean

        ' Split the input string into parts using "-"
        parts = Split(inputString, "-")

        ' Check if there are exactly two parts
        If UBound(parts) = 1 Then
            startTime = Trim(parts(0))
            endTime = Trim(parts(1))

            ' Check if both start and end times have the format "HH:mm"
            validFormat = IsTimeValid(startTime) And IsTimeValid(endTime)

            ' Check if start time is not greater than end time
            If validFormat Then
                IsValidTimeString = TimeValue(startTime) <= TimeValue(endTime)
                Return True
            End If
        End If

        Return False
    End Function

    Public Function IsTimeValid(timeString As String) As Boolean
        ' Check if the time string has the format "HH:mm"
        On Error Resume Next
        IsTimeValid = (Len(timeString) = 5) And (Format$(TimeValue(timeString), "hh:nn") = timeString)
        On Error GoTo 0
    End Function

    Public Function GetUserIDs(ByRef strUserIDs As String) As Object
        Dim splitIDs() As String
        strUserIDs = Replace(strUserIDs, " ", "")
        splitIDs = Split(strUserIDs, ","c)

        For Each userID In splitIDs
            userID = Replace(CStr(userID), " ", "")
        Next userID

        Return splitIDs
    End Function

    Public Function GetUsersCount(ByRef strUserIDs As String) As Integer
        Dim splitIDs() As String
        Dim nUserCount As Integer

        strUserIDs = Replace(strUserIDs, " ", "")
        splitIDs = Split(strUserIDs, ",")

        For Each userID In splitIDs
            userID = Replace(CStr(userID), " ", "")
            If userID <> "" Then
                nUserCount = nUserCount + 1
            End If
        Next userID

        GetUsersCount = nUserCount
    End Function


    Public Sub SaveDebugFile(ByRef strPath As String, ByRef strValue As String)

        'strPath = "C:\File.txt"

        'Dim fileNumber As Integer

        'fileNumber = FreeFile()

        'Open strPath For Output As fileNumber

        'Print #fileNumber, strValue

        'Close(fileNumber)
    End Sub

End Module
