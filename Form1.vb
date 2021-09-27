

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Reflection
Imports System.Threading

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim Qty As String = ConfigurationManager.AppSettings("Qty")
		Dim Server As String = ConfigurationManager.AppSettings("Server")
		Dim procInfo As New ProcessStartInfo()



		Try


			Lbl_PathlineA.Text = Server
			If My.Computer.FileSystem.DirectoryExists(Server) = True Then
				Lbl_StatusLineA.Text = "OK"
				WriteLog(ModApi.Path_Common_Log, "Line A : " & "" & Server & "Status : " & Lbl_StatusLineA.Text)


			Else
				Lbl_StatusLineA.Text = "NG"
				WriteLog(ModApi.Path_Common_Log, "Line A : " & "" & Server & "Status : " & Lbl_StatusLineA.Text)
				procInfo.UseShellExecute = True
				procInfo.FileName = "Net.bat"
				procInfo.WorkingDirectory = Application.StartupPath
				procInfo.Verb = "runas"
				Process.Start(procInfo)
			End If


		Catch ex As Exception
			WriteErrLog(ModApi.Path_Common_Log, ex.Message)
		End Try

	End Sub

End Class
