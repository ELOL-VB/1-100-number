Module Module1

    Sub Main()
        Dim m, n, x, i, y As Integer
        m = 100 : n = 1 : x = 0 : i = 0 : y = 0
        Randomize()
        x = Int(Rnd() * 100) + 1
        Console.WriteLine(n & "~" & m & "猜一個數字")
        y = Console.ReadLine
        Do

            i += 1
            If y > x And y < m Then
                m = y
                Console.WriteLine("太大了" & n & "~" & m)
                y = Console.ReadLine
            ElseIf y < x And y > n Then
                n = y
                Console.WriteLine("太小了" & n & "~" & m)
                y = Console.ReadLine
            ElseIf y > m Or y < n Then
                Console.WriteLine("超出範圍")
                y = Console.ReadLine
            Else
                Exit Do



            End If
        Loop 'Until y = x
        Console.WriteLine("答對了答案是" & x & " 共猜了" & i & "次")
        Console.Read()
    End Sub

End Module
