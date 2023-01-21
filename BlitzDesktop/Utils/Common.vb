
Public Class Common

    Public Shared TimeOut As String = String.Empty

    Public Shared Function GetDateTimeStringForFilename() As String

        Dim timeNow As String = String.Format("{0}-{1}-{2}_{3}-{4}-{5}",
                                               Date.Now.Year.ToString(),
                                               Date.Now.Month.ToString().PadLeft(2, "0"),
                                               Date.Now.Day.ToString().PadLeft(2, "0"),
                                               Date.Now.Hour.ToString().PadLeft(2, "0"),
                                               Date.Now.Minute.ToString().PadLeft(2, "0"),
                                               Date.Now.Second.ToString().PadLeft(2, "0"))

        Return timeNow

    End Function

End Class
