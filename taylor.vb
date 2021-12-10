Imports Microsoft.VisualBasic
Imports System

Public Class GlobalMembersTaylor

	Public Shared Sub Taylor()
	Console.Write("")
	End Sub
	Public Shared Sub tsbracket1()
	Console.Write("")
	End Sub
	Public Shared Sub tsbracket2()
	Console.Write("")
	End Sub
	Public Shared Sub tsbracket3()
	Console.Write("")
	End Sub
	Public Shared Sub clr()
	Console.Write("")
	End Sub
	Public Shared Sub clrs()
	Console.Write("")
	End Sub
	Public Shared Sub clrxs()
	Console.Write("")
	End Sub


	Shared Function Main() As Integer
		Dim tsx As Single
		Dim term As Single
		Dim cf1 As Single
		Dim cf2 As Single
		Dim pw1 As Single
		Dim pw2 As Single
		Dim spw1 As Single = 1
		Dim spw2 As Single = 1
		Dim fspw1 As Single = 1
		Dim fspw2 As Single = 1
		Console.Write("                                                      f''(a)         + f'''(a)" & ControlChars.Lf)
						Console.Write("                           P(x) = f(a) + f'(a)(x-a) + ------ (x-a)^2 + ------- (x-a)^3 + ..." & ControlChars.Lf)
						Console.Write("                                                        2!               3!" & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf)
						Console.Write("Welcome to Taylor Series Expansion" & ControlChars.Lf)
						Dim ts(4) As Integer
						Dim tsclone(4) As Integer
						Dim dstorage(9998) As Single
						Console.Write("Please enter the coefficients, values are separated with a space." & ControlChars.Lf & ControlChars.Lf)
						Console.Write("Given equations:             Ways to input" & ControlChars.Lf)
						Console.Write("                             2   -> Hit enter" & ControlChars.Lf)
						Console.Write("                             3   -> Hit enter" & ControlChars.Lf)
						Console.Write("2x^3 + 4x^5 + 6      >>      4   -> Hit enter         or       2 3 4 5 6  -> Hit enter" & ControlChars.Lf)
						Console.Write("                             5   -> Hit enter" & ControlChars.Lf)
						Console.Write("                             6   -> Hit enter" & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf)
							For i As Integer = 0 To 4
								cin>>ts(i)
							Next i
						ts(3), tsclone(4)=ts(4)
						ts(2), tsclone(3)=ts(3), tsclone(4)
						ts(1), tsclone(2)=ts(2), tsclone(3)
						ts(0), tsclone(1)=ts(1), tsclone(2)
						tsclone(0)=ts(0), tsclone(1)
						Console.Write("Near at x = ")
						cin>>tsx
						Console.Write("How many term do you want?")
						cin>>term
						GlobalMembersMain.clr()
						GlobalMembersMain.Taylor()
						Console.Write(ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & "     Equations:" & ControlChars.Lf & "     ")
						Console.Write(ts(0))
						Console.Write("x^")
						Console.Write(ts(1))
						Console.Write(" + ")
						Console.Write(ts(2))
						Console.Write("x^")
						Console.Write(ts(3))
						Console.Write(" + ")
						Console.Write(ts(4))
						Console.Write(ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & "     Solutions:" & ControlChars.Lf)
						Console.Write("     Finding the derivatives:                Plugging in the value of x:" & ControlChars.Lf & ControlChars.Lf)
							For i As Integer = 0 To ts(1) - 1
							   fspw1 = fspw1 *tsx
							Next i
								For i As Integer = 0 To ts(3) - 1
								   fspw2 = fspw2 *tsx
								Next i
						Console.Write("     f")
						Console.Write("0")
						Console.Write("(x)")
						Console.Write(" = ")
						Console.Write(ts(0))
						Console.Write("x^")
						Console.Write(ts(1))
						Console.Write(" + ")
						Console.Write(ts(2))
						Console.Write("x^")
						Console.Write(ts(3))
						Console.Write(" + ")
						Console.Write(ts(4))
						Console.Write("                 f")
						Console.Write("0")
						Console.Write("(")
						Console.Write(tsx)
						Console.Write(")")
						Console.Write(" = ")
						Console.Write(ts(0))
						Console.Write("x^")
						Console.Write(ts(1))
						Console.Write(" + ")
						Console.Write(ts(2))
						Console.Write("x^")
						Console.Write(ts(3))
						Console.Write(" + ")
						Console.Write(ts(4))
						Console.Write(ControlChars.Lf)
						Console.Write("                                                     = ")
						Console.Write(ts(0))
						Console.Write("(")
						Console.Write(tsx)
						Console.Write(")^")
						Console.Write(ts(1))
						Console.Write(" + ")
						Console.Write(ts(2))
						Console.Write("(")
						Console.Write(tsx)
						Console.Write(")^")
						Console.Write(ts(3))
						Console.Write(" + ")
						Console.Write(ts(4))
						Console.Write(ControlChars.Lf)
						Console.Write("                                                     = ")
						Console.Write(ts(0)*fspw1+ts(2)*fspw2+ts(4))
						Console.Write(ControlChars.Lf & ControlChars.Lf)
						1, fspw2 = 1
						fspw1 = 1, fspw2
							For i As Integer = 1 To term
								cf1 = ts(1)*ts(0)
								pw1 = ts(1)-1
								pw2 = ts(3)-1
								cf2 = ts(3)*ts(2)
								Console.Write("     f")
								Console.Write(i)
								Console.Write("(x)")
								Console.Write(" = ")
								Console.Write(ts(0))
								Console.Write("x^")
								Console.Write(ts(1))
								Console.Write(" + ")
								Console.Write(ts(2))
								Console.Write("x^")
								Console.Write(ts(3))
								Console.Write("                     f")
								Console.Write(i)
								Console.Write("(")
								Console.Write(tsx)
								Console.Write(")")
								Console.Write(" = ")
								Console.Write(cf1)
								Console.Write("x^")
								Console.Write(pw1)
								Console.Write(" + ")
								Console.Write(ts(3)*ts(2))
								Console.Write("x^")
								Console.Write(pw2)
								Console.Write(ControlChars.Lf)
								Console.Write("           = ")
								Console.Write(cf1)
								Console.Write("x^")
								Console.Write(pw1)
								Console.Write(" + ")
								Console.Write(ts(3)*ts(2))
								Console.Write("x^")
								Console.Write(pw2)
								Console.Write("                           = ")
								Console.Write(cf1)
								Console.Write("(")
								Console.Write(tsx)
								Console.Write(")^")
								Console.Write(pw1)
								Console.Write(" + ")
								Console.Write(ts(3)*ts(2))
								Console.Write("(")
								Console.Write(tsx)
								Console.Write(")^")
								Console.Write(pw2)
								Console.Write(ControlChars.Lf)
									For i As Integer = 0 To pw1 - 1
										spw1 = spw1 *tsx
									Next i
										For i As Integer = 0 To pw2 - 1
											spw2 = spw2 *tsx
										Next i
								Console.Write("                                                     = ")
								Console.Write(cf1 *spw1+cf2 *spw2)
								Console.Write(ControlChars.Lf & ControlChars.Lf)
								dstorage(i)=cf1 *spw1+cf2 *spw2
								1, spw2 = 1
								pw2, spw1 = 1, spw2
								cf2, ts(3)=pw2, spw1
								pw1, ts(2)=cf2, ts(3)
								cf1, ts(1)=pw1, ts(2)
								ts(0)=cf1, ts(1)
							Next i
							For i As Integer = 0 To tsclone(1) - 1
							   fspw1 = fspw1 *tsx
							Next i
								For i As Integer = 0 To tsclone(3) - 1
								   fspw2 = fspw2 *tsx
								Next i
						Console.Write(" .------------------------------------------------------------------------------------------." & ControlChars.Lf)
						Console.Write(" |   The taylor series for this equation will be:")
						Console.Write("                                           |" & ControlChars.Lf)
						Console.Write(" |                                                                                          |" & ControlChars.Lf)
						Console.Write(" |                                            f''(a)         + f'''(a)                      |" & ControlChars.Lf)
						Console.Write(" |                 P(x) = f(a) + f'(a)(x-a) + ------ (x-a)^2 + ------- (x-a)^3 + ...        |" & ControlChars.Lf)
						Console.Write(" |                                               2!               3!                        |" & ControlChars.Lf)
						Console.Write(" |                                                                                          |" & ControlChars.Lf)
						Console.Write(" |                                                                                          |" & ControlChars.Lf)
						Console.Write(" |    ")
						Console.Write(tsclone(0))
						Console.Write("x^")
						Console.Write(tsclone(1))
						Console.Write(" + ")
						Console.Write(tsclone(2))
						Console.Write("x^")
						Console.Write(tsclone(3))
						Console.Write(" + ")
						Console.Write(tsclone(4))
						Console.Write(" = f(")
						Console.Write(tsx)
						Console.Write(") + f'(")
						Console.Write(tsx)
						Console.Write(")")
						Console.Write("(x-")
						Console.Write(tsx)
						Console.Write(") + f''(")
						Console.Write(tsx)
						Console.Write(")/2!(x-")
						Console.Write(tsx)
						Console.Write(")^2 + f'''(")
						Console.Write(tsx)
						Console.Write(")/3!(x-")
						Console.Write(tsx)
						Console.Write(")^3 + ...    |" & ControlChars.Lf)
						Console.Write(" |                      = ")
						Console.Write(tsclone(0)*fspw1+tsclone(2)*fspw2+tsclone(4))
						Console.Write(" + ")
						Console.Write(dstorage(1))
						Console.Write("(x-")
						Console.Write(tsx)
						Console.Write(") + ")
						Console.Write(dstorage(2)/2)
						Console.Write("(x-")
						Console.Write(tsx)
						Console.Write(")^2 + ")
						Console.Write(dstorage(3)/6)
						Console.Write("(x-")
						Console.Write(tsx)
						Console.Write(")^3 + ...                       |           ")
						Console.Write(" Press enter to continue..." & ControlChars.Lf)
						Console.Write(" |                      = expand Zzz                                                        |" & ControlChars.Lf)
						Console.Write(" '------------------------------------------------------------------------------------------'" & ControlChars.Lf)
						cin.ignore()
						Console.Read()
		Return 0
	End Function
End Class

