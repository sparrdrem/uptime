Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        'Dim ApplicationTitle As String
        'If My.Application.Info.Title <> "" Then
        'ApplicationTitle = My.Application.Info.Title
        'Else
        'ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If
        Me.Text = String.Format("About UPTIME")
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "UPTIME"
        Me.LabelVersion.Text = "Version 1.0.284"
        Me.LabelCopyright.Text = "Copyright © 2018-2019"
        Me.LabelCompanyName.Text = "SparrDrem"
        Me.TextBoxDescription.Text = "This program is licensed under the MIT terms. This program comes AS-IS and absoulutely no warranty is licensed. For more information, please read mit.txt in the program directory."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
