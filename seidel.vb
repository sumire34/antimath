Imports Microsoft.VisualBasic
Imports System

Public Class GlobalMembersSeidel

	Public Shared Sub Seidel()
	Console.Write("")
	End Sub
	Public Shared Sub bracket1()
	Console.Write("")
	End Sub
	Public Shared Sub bracket2()
	Console.Write("")
	End Sub
	Public Shared Sub bracket3()
	Console.Write("")
	End Sub
	Public Shared Sub clr()
	Console.Write("")
	End Sub
	Public Shared Sub clrs()
	Console.Write("")
	End Sub



	Shared Function Main() As Integer
	Dim x1 As Single = 0
	Dim x2 As Single = 0
	Dim x3 As Single = 0
	Dim a As Single = 0
	Dim b As Single = 0
	Dim c As Single = 0
	Dim i As Single = 1
	Dim userlimit As Single
	Dim blankcontainer As Single

	GlobalMembersMain.Seidel()
	GlobalMembersMain.clrs()
		Console.Write("Welcome to Gauss Seidel Method" & ControlChars.Lf)
		Dim eq(2, 3) As Integer
			Console.Write("Please enter the coefficients, values are separated with a space." & ControlChars.Lf & ControlChars.Lf)
			Console.Write("Example                   Your Input" & ControlChars.Lf)
			Console.Write("1x + 2y + 3z = 4          1 2 3 4  ->hit enter" & ControlChars.Lf)
			Console.Write("5x + 6y + 7z = 8    >>    5 6 7 8  ->hit enter     or      1 2 3 4 5 6 7 8 9 1 2 3    ->hit enter" & ControlChars.Lf)
			Console.Write("9x + 1y + 2z = 3          9 1 2 3  ->hit enter")
			Console.Write(ControlChars.Lf & ControlChars.Lf & "Your input:" & ControlChars.Lf)
				For x As Integer = 0 To 2
					For y As Integer = 0 To 3
						cin >> eq(x, y)
					Next y
				Next x
						Console.Write("How many iterations do you want?  ->")
							cin>>userlimit
						GlobalMembersMain.clr()
						GlobalMembersMain.Seidel()
							Console.Write(ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & " Equations:" & ControlChars.Lf & " ")
							Console.Write(eq(0, 0))
							Console.Write("x1 + ")
							Console.Write(eq(0, 1))
							Console.Write("y1 + ")
							Console.Write(eq(0, 2))
							Console.Write("z1 = ")
							Console.Write(eq(0, 3))
							Console.Write(ControlChars.Lf)
							Console.Write(" ")
							Console.Write(eq(1, 0))
							Console.Write("x2 + ")
							Console.Write(eq(1, 1))
							Console.Write("y2 + ")
							Console.Write(eq(1, 2))
							Console.Write("z2 = ")
							Console.Write(eq(1, 3))
							Console.Write(ControlChars.Lf)
							Console.Write(" ")
							Console.Write(eq(2, 0))
							Console.Write("x3 + ")
							Console.Write(eq(2, 1))
							Console.Write("y3 + ")
							Console.Write(eq(2, 2))
							Console.Write("z3 = ")
							Console.Write(eq(2, 3))
							Console.Write(ControlChars.Lf & ControlChars.Lf)
						GlobalMembersMain.bracket1()
							Console.Write(ControlChars.Lf & " |  Iteration  |     ")
							Console.Write("x1         ")
							Console.Write("x2        ")
							Console.Write("x3      |" & ControlChars.Lf)
						GlobalMembersMain.bracket2()
							Console.Write(" |      ")
							Console.Write(i)
							Console.Write("{0:F4}", "      |   ")
							Console.Write("{0:F4}", x1)
							Console.Write("{0:F4}", "     ")
							Console.Write("{0:F4}", x2)
							Console.Write("{0:F4}", "    ")
							Console.Write("{0:F4}", x3)
							Console.Write("{0:F4}", "    |" & ControlChars.Lf)
								For i As Integer = 2 To userlimit
									x1 = (eq(0, 3)+(eq(0, 1)*b*-1)+(eq(0, 2)*c*-1))/eq(0, 0)
										a = x1
									x2 = (eq(1, 3)+(eq(1, 0)*a*-1)+(eq(1, 2)*c*-1))/eq(1, 1)
										b = x2
									x3 = (eq(2, 3)+(eq(2, 0)*a*-1)+(eq(2, 1)*b*-1))/eq(2, 2)
										c = x3
									Console.Write("{0:F4}", " |      ")
									Console.Write("{0:F4}", i)
									Console.Write("{0:F4}", "      |   ")
									Console.Write("{0:F4}", x1)
									Console.Write("{0:F4}", "    ")
									Console.Write("{0:F4}", x2)
									Console.Write("{0:F4}", "    ")
									Console.Write("{0:F4}", x3)
									Console.Write("{0:F4}", "    |" & ControlChars.Lf)
								Next i
						GlobalMembersMain.bracket3()
						GlobalMembersMain.bracket1()
							Console.Write("{0:F}", ControlChars.Lf & " |             Sequences converges at:            |" & ControlChars.Lf)
							Console.Write("{0:F}", " |         x1 = ")
							Console.Write("{0:F}", x1)
							Console.Write("{0:F}", "  |  x2 = ")
							Console.Write("{0:F}", x2)
							Console.Write("{0:F}", "  |  x3 = ")
							Console.Write("{0:F}", x3)
							Console.Write("{0:F}", "          |                      Press enter to continue..." & ControlChars.Lf)
						GlobalMembersMain.bracket3()
							cin.ignore()
							Console.Read()

	Return 0
	End Function
End Class

