Public Class SFPA2017
    Private Sub Btn_Exit1_Click(sender As Object, e As EventArgs) Handles Btn_Exit1.Click
        Close()
    End Sub

    Private Sub Play1_Click(sender As Object, e As EventArgs) Handles Play1.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 1\SFPA.exe")
    End Sub

    Private Sub Play2_Click(sender As Object, e As EventArgs) Handles Play2.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 2\SFPA.exe")
    End Sub

    Private Sub Play3_Click(sender As Object, e As EventArgs) Handles Play3.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 3\SFPA.exe")
    End Sub

    Private Sub Play4_Click(sender As Object, e As EventArgs) Handles Play4.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 4\SFPA.exe")
    End Sub

    Private Sub Play5_Click(sender As Object, e As EventArgs) Handles Play5.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 5\SFPA.exe")
    End Sub

    Private Sub Play6_Click(sender As Object, e As EventArgs) Handles Play6.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 6\SFPA.exe")
    End Sub

    Private Sub Play7_Click(sender As Object, e As EventArgs) Handles Play7.Click
        System.Diagnostics.Process.Start(".\bin\depot_668212 7\SFPA.exe")
    End Sub

    Private Sub Hyperlink1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Hyperlink1.LinkClicked
        Process.Start("https://steamdb.info/depot/668212/manifests/")
    End Sub

    Private Sub LogoH1_Click(sender As Object, e As EventArgs) Handles LogoH1.Click
        Process.Start("https://github.com/TheGamesss/Super-Fancy-Pants-Adventure-2017-Pack")
    End Sub
End Class