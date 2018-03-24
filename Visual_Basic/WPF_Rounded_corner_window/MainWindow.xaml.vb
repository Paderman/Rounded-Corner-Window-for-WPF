Namespace WPFRoundedCornerWindow
    Partial Class MainWindow
        Public Sub New()
            InitializeComponent()
            MainTitle.Content = Title
        End Sub

        Private Sub Minimize_Program(sender As Object, e As RoutedEventArgs)
            WindowState = WindowState.Minimized
        End Sub

        Private Sub Close_Program(sender As Object, e As RoutedEventArgs)
            Close()
        End Sub

        Private Sub WindowNormalMaximize()
            Select Case WindowState
                Case WindowState.Maximized
                    MaximizeProgram.Content = "🗖"
                    WindowState = WindowState.Normal
                    TitleDrawBar.CornerRadius = New CornerRadius(25, 15, 0, 0)
                Case WindowState.Normal
                    MaximizeProgram.Content = "🗗"
                    WindowState = WindowState.Maximized
                    TitleDrawBar.CornerRadius = New CornerRadius(0)
            End Select
        End Sub

        Private Sub Maximize_Program(sender As Object, e As RoutedEventArgs)
            WindowNormalMaximize()
        End Sub

        Private Sub DrawWindow_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
            DragMove()
            Select Case e.ClickCount
                Case 2
                    WindowNormalMaximize()
            End Select
        End Sub
    End Class
End Namespace
