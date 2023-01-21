
Imports Newtonsoft.Json

Public Class Settings

    Public Shared Function GetMain() As MainSettingsInfo

        If Not My.Computer.FileSystem.FileExists(Constants.SettingFile) Then
            Return Nothing
        End If

        Dim file As String =
            My.Computer.FileSystem.ReadAllText(Constants.SettingFile)

        Dim serializerSettings As New JsonSerializerSettings
        With serializerSettings
            .NullValueHandling = NullValueHandling.Ignore
            .MissingMemberHandling = MissingMemberHandling.Error
        End With

        Dim mainSettingsInfo As MainSettingsInfo =
            JsonConvert.DeserializeObject(Of MainSettingsInfo)(file, serializerSettings)

        Return mainSettingsInfo

    End Function

    Public Shared Sub SaveMain(serverName As String, database As String, sproc As String)

        Dim mainSettingsInfo As New MainSettingsInfo

        With mainSettingsInfo
            .Server = serverName
        End With

        ' Serialize to JSON-object
        Dim serializerSettings As New JsonSerializerSettings
        serializerSettings.NullValueHandling = NullValueHandling.Ignore

        Dim jsonData = JsonConvert.SerializeObject(mainSettingsInfo, serializerSettings)

        My.Computer.FileSystem.WriteAllText(Constants.SettingFile, jsonData, False)

    End Sub

End Class

Public Class MainSettingsInfo
    Public Property [Server] As String
End Class
