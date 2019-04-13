Public Class Main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("https://sparrdrem.github.io/uptime")
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PCNAME.Text = My.Computer.Name
        ComputeUpTime()
        UserName.Text = Environment.UserName
    End Sub

    Public ReadOnly Property Seconds() As Integer
        Get
            Return CType(TimeCount.Text, Integer)
        End Get
    End Property

    Private Sub ComputeUpTime()
        Dim upticks As Double
        Dim updays As Integer
        Dim uphours As Integer
        Dim upmins As Integer
        Dim upsecs As Integer
        upticks = Environment.TickCount
        upticks = upticks / 1000
        updays = Int(upticks / (3600 * 24))
        upticks = upticks - (Int(upticks / (3600 * 24)) * (3600 * 24))
        uphours = Int(upticks / 3600)
        upticks = upticks - (Int(upticks / 3600) * 3600)
        upmins = Int(upticks / 60)
        upticks = upticks - (Int(upticks / 60) * 60)
        upsecs = upticks
        TimeCount.Text = Str(updays) + ":" + Str(uphours) + ":" + Str(upmins) + ":" + Str(upsecs)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ComputeUpTime()
    End Sub

    Private Sub AboutUPTIMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUPTIMEToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
