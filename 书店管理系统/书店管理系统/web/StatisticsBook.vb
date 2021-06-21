Imports System
Imports Microsoft.Reporting.WinForms
Public Class StatisticsBook
    Dim objdataSet As New DataSet
    Dim book As Book
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objdataSet = Statistics_Book(book)
        DataGridView1.DataSource = objdataSet.Tables("book")
        DataGridView1.AllowUserToAddRows = False 'DataGridView不显示最后空白的行
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim NowDateTime1 As Date
        NowDateTime1 = Now()
        ReportViewer1.LocalReport.ReportPath = "F:\Visual Studio2012\书店管理系统\书店管理系统\web\Report2.rdlc"
        '注意：创建或修改都要将 "Report1.rdlc"文件拷贝到bin\debug下即可！
        Dim _qr As ReportParameter '声明报表变量
        _qr = New ReportParameter("NowDateTime", NowDateTime1) '声明报表变量实例，引号里的字符串是在报表里设计的参数名称，逗号后的是要传进去的值
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {_qr})
        ReportViewer1.LocalReport.DataSources.Clear()
        objdataSet = Statistics_Book(book)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("book", objdataSet.Tables(0)))
        ReportViewer1.RefreshReport()

    End Sub


    Private Sub StatisticsBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class