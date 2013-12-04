Public Class Form1

  
    Private Sub cmdOutputClear_Click(sender As Object, e As EventArgs) Handles cmdOutputClear.Click
        Try
            txtOutput.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception")
        End Try
    End Sub

    Private Sub cmdExecute_Click(sender As Object, e As EventArgs) Handles cmdExecute.Click
        Try
            Dim auxFile as String
            Dim files() As String = IO.Directory.GetFiles(txtInput.Text, "*.*")
            txtOutput.Text = txtOutput.Text + vbCrLf + "Updating Files in " + txtInput.Text
            For Each sFile As String In files
                auxFile = IO.Path.GetFileNameWithoutExtension(sFile) & txtExtension.Text
                My.Computer.FileSystem.RenameFile(sFile, auxFile)
                txtOutput.Text = txtOutput.Text + vbCrLf + auxFile
            Next
            txtOutput.Text = txtOutput.Text + vbCrLf + "Update Complete"
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Exception")
        End Try
    End Sub
End Class
