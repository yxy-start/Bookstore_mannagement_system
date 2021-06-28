Public Class Manage_User

    Dim manageUser As New ManageUser()
    Dim objdataSet As New DataSet

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CountManageUser(manageUser)
        Dim manageid As String = "CT" & manageUser.Get_manageCount + 1
        Dim managename As String = TextBox1.Text
        Dim managepassworld As String = TextBox2.Text
        Dim manageiphone As String = TextBox3.Text
        If (managename = "") Then
            MsgBox("管理员名字不能为空！")
        Else
            If (managepassworld = "") Then
                MsgBox("管理员密码不能为空！")
            Else
                If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                    MsgBox("请选择性别！")
                Else
                    If (manageiphone = "") Then
                        MsgBox("电话号码不能为空！")
                    Else
                        If (RadioButton1.Checked = True) Then
                            manageUser.Set_manageSex("男")
                        End If
                        If (RadioButton2.Checked = True) Then
                            manageUser.Set_manageSex("女")
                        End If

                        manageUser.Set_manageId(manageid)
                        manageUser.Set_manageName(managename)
                        manageUser.Set_managePassworld(managepassworld)
                        manageUser.Set_manageIphone(manageiphone)
                        manageUser_Insert(manageUser)
                        Me.Close()
                    End If
                    
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim managename As String = TextBox1.Text
        Dim Cancel, iAnswer As Integer
        iAnswer = MsgBox("真的要删除该管理员吗?", vbYesNo)
        If iAnswer = vbNo Then
            Cancel = True
        Else
            If (managename = "") Then
                MsgBox("管理员名字不能为空！请输入管理员名字进行删除！")
            Else
                manageUser.Set_manageName(managename)
                manageUser_delete(manageUser)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim managename As String = TextBox1.Text
        Try
            If (managename = "") Then
                MsgBox("管理员名字不能为空！请输入管理员名字进行查询！")
            Else
                manageUser.Set_manageName(managename)
                objdataSet = manageUser_Select(manageUser)
                DataGridView1.DataSource = objdataSet.Tables("manage")
                DataGridView1.AllowUserToAddRows = False                        'DataGridView不显示最后空白的行

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Manage_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"
    End Sub

   
   
End Class