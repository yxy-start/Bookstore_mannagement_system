Public Class User_System_Index

    Private user As User
    Public Sub New(u As User)
        InitializeComponent()
        user = u
    End Sub

    Private Sub 系统管理员界面_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TreeView1.BeginUpdate()
        TreeView1.Nodes.Add("江江书店图书类别导航")
        TreeView1.Nodes(0).Nodes.Add("哲学/宗教")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("中国哲学")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("宗教理论")
        TreeView1.Nodes(0).Nodes(0).Nodes.Add("科学技术哲学")
        TreeView1.Nodes(0).Nodes.Add("政治/军事")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("中国政治")
        TreeView1.Nodes(0).Nodes(1).Nodes.Add("中国军事")
        TreeView1.Nodes(0).Nodes.Add("社会/科学")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("社会科学总论")
        TreeView1.Nodes(0).Nodes(2).Nodes.Add("语言文字")
        TreeView1.Nodes(0).Nodes.Add("自我实现/励志")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("成功")
        TreeView1.Nodes(0).Nodes(3).Nodes.Add("人际沟通")
        TreeView1.Nodes(0).Nodes.Add("法律")
        TreeView1.Nodes(0).Nodes(4).Nodes.Add("法学理论")
        TreeView1.Nodes(0).Nodes.Add("小说传记")
        TreeView1.Nodes(0).Nodes(5).Nodes.Add("中国现代小说")
        TreeView1.Nodes(0).Nodes(5).Nodes.Add("武侠小说")
        TreeView1.Nodes(0).Nodes.Add("中国文学")
        TreeView1.Nodes(0).Nodes(6).Nodes.Add("诗歌")
        TreeView1.Nodes(0).Nodes(6).Nodes.Add("散文")
        TreeView1.Nodes(0).Nodes(6).Nodes.Add("小说")
        TreeView1.Nodes(0).Nodes.Add("退出系统")
        TreeView1.EndUpdate()
        '展开节点
        Dim node As TreeNode
        For Each node In TreeView1.Nodes
            node.ExpandAll()
        Next

        Label6.Text = user.Get_用户名()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim book As New Book()
        If TreeView1.SelectedNode.Text = "中国哲学" Then
            book.Set_bookGenres("中国哲学")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "宗教理论" Then
            book.Set_bookGenres("宗教理论")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "科学技术哲学" Then
            book.Set_bookGenres("科学技术哲学")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "中国政治" Then
            book.Set_bookGenres("中国政治")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "中国军事" Then
            book.Set_bookGenres("中国军事")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "社会科学总论" Then
            book.Set_bookGenres("社会科学总论")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "语言文字" Then
            book.Set_bookGenres("语言文字")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "成功" Then
            book.Set_bookGenres("成功")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "人际沟通" Then
            book.Set_bookGenres("人际沟通")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "法学理论" Then
            book.Set_bookGenres("法学理论")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "中国现代小说" Then
            book.Set_bookGenres("中国现代小说")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "武侠小说" Then
            book.Set_bookGenres("武侠小说")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "诗歌" Then
            book.Set_bookGenres("诗歌")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "散文" Then
            book.Set_bookGenres("散文")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        If TreeView1.SelectedNode.Text = "小说" Then
            book.Set_bookGenres("小说")
            Dim bookTable As New BookTable(book)
            bookTable.ShowDialog()
        End If
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "隐藏引导区" Then
            Button1.Left = 0
            Button1.Text = "显示引导区"
            TreeView1.Visible = False
        ElseIf Button1.Text = "显示引导区" Then
            Button1.Text = "隐藏引导区"
            TreeView1.Visible = True
            Button1.Left = TreeView1.Width + 10
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim yhcx As New Manage_Consumer
        yhcx.ShowDialog()

    End Sub

    Private Sub 用户添加ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 用户添加ToolStripMenuItem.Click
        Dim yhcx As New Manage_Consumer
        yhcx.ShowDialog()
    End Sub

    Private Sub 用户查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 用户查询ToolStripMenuItem.Click
        Dim yhcx As New Manage_Consumer
        yhcx.ShowDialog()
    End Sub

    Private Sub 图书类别添加ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图书类别添加ToolStripMenuItem.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub

    Private Sub 图书类别查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图书类别查询ToolStripMenuItem.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub

    Public Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub

    Private Sub 图书信息添加ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 图书信息添加ToolStripMenuItem1.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub

    Private Sub 图书信息查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图书信息查询ToolStripMenuItem.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub

    Private Sub 图书信息删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 图书信息删除ToolStripMenuItem.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub


    Private Sub 管理员添加ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理员添加ToolStripMenuItem.Click
        Dim manage As New Manage_User
        manage.ShowDialog()
    End Sub
    Private Sub 管理员管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理员管理ToolStripMenuItem.Click
        Dim manage As New Manage_User
        manage.ShowDialog()
    End Sub
    Private Sub 管理员删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理员删除ToolStripMenuItem.Click
        Dim manage As New Manage_User
        manage.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim yhcx As New Manage_Consumer
        yhcx.ShowDialog()
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim tscx As New Manage_Book
        tscx.ShowDialog()
    End Sub
    Private Sub 退出系统ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出系统ToolStripMenuItem.Click
        Dim Cancel As Integer
        Dim iAnswer As Integer
        iAnswer = MsgBox("真的要退出吗?", vbYesNo)
        If iAnswer = vbNo Then
            Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim Cancel As Integer
        Dim iAnswer As Integer
        iAnswer = MsgBox("真的要退出吗?", vbYesNo)
        If iAnswer = vbNo Then
            Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim Cancel As Integer
        Dim iAnswer As Integer
        iAnswer = MsgBox("真的要退出吗?", vbYesNo)
        If iAnswer = vbNo Then
            Cancel = True
        Else
            End
        End If
    End Sub

  
    Private Sub 统计用户ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 统计打印用户ToolStripMenuItem.Click
        Dim tjUser As New StatisticsUser()
        tjUser.ShowDialog()
    End Sub

    Private Sub 统计书籍ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 统计打印书籍ToolStripMenuItem.Click
        Dim tjBook As New StatisticsBook()
        tjBook.ShowDialog()
    End Sub
End Class