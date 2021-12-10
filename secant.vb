Imports Microsoft.VisualBasic
Imports System

Public Class GlobalMembersSecant

	Public Shared Sub Secant()
	Console.Write("")
	End Sub
	Public Shared Sub smbracket1()
	Console.Write("")
	End Sub
	Public Shared Sub smbracket2()
	Console.Write("")
	End Sub
	Public Shared Sub smbracket3()
	Console.Write("")
	End Sub
	Public Shared Sub clr()
	Console.Write("")
	End Sub
	Public Shared Sub clrs()
	Console.Write("")
	End Sub

	Shared Function Main() As Integer
		Dim sma As Single
		Dim smb As Single
		Dim fa As Single
		Dim fb As Single
		Dim base1 As Single = 1
		Dim base2 As Single = 1
		Dim base11 As Single = 1
		Dim base22 As Single = 1
		Dim smx As Single
			Console.Write("Welcome to Secant Method" & ControlChars.Lf)
		Dim sm(3) As Integer
			Console.Write("Please enter the coefficients, values are separated with a space." & ControlChars.Lf & ControlChars.Lf)
			Console.Write("Example                  Your input" & ControlChars.Lf)
			Console.Write("2x^3 + 4x^5 + 6    >>    2 3 4 5 6" & ControlChars.Lf)
			Console.Write(ControlChars.Lf & ControlChars.Lf & "Your input: ")
				For i As Integer = 0 To 4
					cin>>sm(i)
				Next i
			Console.Write("When a = ")
			cin>>sma
			Console.Write("and  b = ")
			cin>>smb
				For i As Integer = 0 To sm(1) - 1
					base1 = base1 *sma
				Next i
					For i As Integer = 0 To sm(3) - 1
						base2 = base2 *sma
					Next i
				fa = (sm(0)*base1+sm(2)*base2)+sm(4)
						For i As Integer = 0 To sm(1) - 1
							base11 = base11 *smb
						Next i
							For i As Integer = 0 To sm(3) - 1
								base22 = base22 *smb
							Next i
				fb = (sm(0)*base11+sm(2)*base22)+sm(4)
				smx = sma-((fa*(smb-sma))/(fb-fa))
			Dim sml As Integer
				Console.Write("How many iterations do you want?  ->")
					cin>>sml
				GlobalMembersMain.clr()
				GlobalMembersMain.Secant()
				Console.Write(ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & " Equations:" & ControlChars.Lf & " ")
				Console.Write(sm(0))
				Console.Write("x^")
				Console.Write(sm(1))
				Console.Write(" + ")
				Console.Write(sm(2))
				Console.Write("x^")
				Console.Write(sm(3))
				Console.Write(" + ")
				Console.Write(sm(4))
				Console.Write(ControlChars.Lf & ControlChars.Lf & ControlChars.Lf)
				GlobalMembersMain.smbracket1()
				Console.Write(ControlChars.Lf & " |  Iteration  |    ")
				Console.Write("a        ")
				Console.Write("b      ")
				Console.Write("f(a)     ")
				Console.Write("f(b)      ")
				Console.Write("x")
				Console.Write("   |" & ControlChars.Lf)
				GlobalMembersMain.smbracket2()
				Console.Write("{0:F4}", " |      1      | ")
				Console.Write("{0:F4}", sma)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F4}", smb)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F4}", fa)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F4}", fb)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F2}", smx)
				Console.Write("{0:F2}", "  |" & ControlChars.Lf)
					For x As Integer = 2 To (sml+2) - 1
					smb, smb = smx
					1, sma = smb, smb
					1, base22 = 1, sma
					1, base11 = 1, base22
					1,base2 = 1, base11
					base1 = 1,base2
						For i As Integer = 0 To sm(1) - 1
							base1 = base1 *sma
						Next i
							For i As Integer = 0 To sm(3) - 1
								base2 = base2 *sma
							Next i
				fa = (sm(0)*base1+sm(2)*base2)+sm(4)
								For i As Integer = 0 To sm(1) - 1
									base11 = base11 *smb
								Next i
									For i As Integer = 0 To sm(3) - 1
										base22 = base22 *smb
									Next i
				fb = (sm(0)*base11+sm(2)*base22)+sm(4)
				smx = sma-((fa*(smb-sma))/(fb-fa))
				Console.Write("{0:F2}", " |      ")
				Console.Write("{0:F2}", x)
				Console.Write("{0:F2}", "      | ")
				Console.Write("{0:F4}", sma)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F4}", smb)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F4}", fa)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F4}", fb)
				Console.Write("{0:F4}", "   ")
				Console.Write("{0:F2}", smx)
				Console.Write("{0:F2}", "  |" & ControlChars.Lf)

					Next x
				GlobalMembersMain.smbracket3()
				Console.Write("{0:F2}", ControlChars.Lf & ControlChars.Lf)
				GlobalMembersMain.smbracket1()
				Console.Write("{0:F2}", ControlChars.Lf & " |           After ")
				Console.Write("{0:F2}", sml)
				Console.Write("{0:F2}", " iterations, the root is ")
				Console.Write("{0:F2}", smx)
				Console.Write("{0:F2}", ".         |                    Press enter to continue..." & ControlChars.Lf)
				GlobalMembersMain.smbracket3()
				cin.ignore()
				Console.Read()
		Return 0
	End Function
End Class

