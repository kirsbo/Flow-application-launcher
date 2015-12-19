
'GT. 21.02.2010 -- revision of class code is completed.

' Class is used to play sounds of different events
Public Class clsSound


    Public Shared Sub playSound(ByVal soundToPlay As Integer)
        Dim soundStream As System.IO.UnmanagedMemoryStream = getSoundFromIndex(soundToPlay)
        If My.Settings.SoundEnabled = False Or soundStream Is Nothing Then
            'Play nothing
        Else
            My.Computer.Audio.Play(soundStream, AudioPlayMode.Background)
        End If

    End Sub

    Enum sounds
        Alert = 1
        ExecuteCommand = 2
        ChangeLayout = 3
        DisplayFlow = 4
    End Enum


    Private Shared Function getSoundFromIndex(ByVal soundIndex As Integer) As System.IO.UnmanagedMemoryStream
        Select Case soundIndex
            Case sounds.Alert
                Return My.Resources.SoundAlert
            Case sounds.ExecuteCommand
                Return My.Resources.SoundClick
            Case sounds.ChangeLayout, sounds.DisplayFlow
                Return My.Resources.SoundChangeLayout
            Case Else
                Return Nothing
        End Select
    End Function

End Class
