Imports Microsoft.VisualBasic
Imports System

Public Class GlobalMembersAntimath

	Public Shared Sub Home()
	Console.Write("")
	End Sub
	Public Shared Sub [Exit]()
	Console.Write("")
	End Sub
	Public Shared Sub Menu()
	Console.Write("")
	End Sub
	Public Shared Sub Invalid()
	Console.Write("")
	End Sub

	Public Shared Sub About()
	Console.Write("")
	End Sub
	Public Shared Sub About2()
	Console.Write("")
	End Sub

	Public Shared Sub Help()
	Console.Write("")
	End Sub
	Public Shared Sub Help2()
	Console.Write("")
	End Sub
	Public Shared Sub Taylor()
	Console.Write("")
	End Sub
	Public Shared Sub Secant()
	Console.Write("")
	End Sub
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
	Dim sma As Single
	Dim smb As Single
	Dim fa As Single
	Dim fb As Single
	Dim base1 As Single = 1
	Dim base2 As Single = 1
	Dim base11 As Single = 1
	Dim base22 As Single = 1
	Dim smx As Single
	Dim x1 As Single = 0
	Dim x2 As Single = 0
	Dim x3 As Single = 0
	Dim a As Single = 0
	Dim b As Single = 0
	Dim c As Single = 0
	Dim i As Single = 1
	Dim userlimit As Single
	Dim blankcontainer As Single

	Dim x As Integer
	Do
	GlobalMembersMain.Home()
	cin>>x
	Select Case x
		Case 1
			Dim submenu As Integer
			Dim sample As Integer
			Do
			GlobalMembersMain.clr()
			GlobalMembersMain.Menu()
			GlobalMembersMain.clrs()
				Console.Write("Which mathematical topic do you want?  ->")
				cin>>submenu
				Select Case submenu
					Case 1
						GlobalMembersMain.clr()
						GlobalMembersMain.Taylor()
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
								Case 2
									GlobalMembersMain.clr()
									GlobalMembersMain.Secant()
									Console.Write("Welcome to Secant Method" & ControlChars.Lf)
									Dim sm(3) As Integer
									Console.Write("Please enter the coefficients, values are separated with a space." & ControlChars.Lf & ControlChars.Lf)
									Console.Write("Given equations:             Ways to input" & ControlChars.Lf)
									Console.Write("                             2   -> Hit enter" & ControlChars.Lf)
									Console.Write("                             3   -> Hit enter" & ControlChars.Lf)
									Console.Write("2x^3 + 4x^5 + 6       >>     4   -> Hit enter         or       2 3 4 5 6  -> Hit enter" & ControlChars.Lf)
									Console.Write("                             5   -> Hit enter" & ControlChars.Lf)
									Console.Write("                             6   -> Hit enter" & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf)
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
									1, base22 = 1
									1, base11 = 1, base22
									1, base2 = 1, base11
									base1 = 1, base2
									cin.ignore()
									Console.Read()
											Case 3
												GlobalMembersMain.clr()
												GlobalMembersMain.Seidel()
												Console.Write("{0:F2}", "Welcome to Gauss Seidel Method" & ControlChars.Lf)
												Dim eq(2, 3) As Integer
												Console.Write("{0:F2}", "Please enter the coefficients, values are separated with a space." & ControlChars.Lf & ControlChars.Lf)
												Console.Write("{0:F2}", "Example               Your Input" & ControlChars.Lf)
												Console.Write("{0:F2}", "1x + 2y + 3z = 4          1 2 3 4  ->hit enter" & ControlChars.Lf)
												Console.Write("{0:F2}", "5x + 6y + 7z = 8    >>    5 6 7 8  ->hit enter     or      1 2 3 4 5 6 7 8 9 1 2 3    ->hit enter" & ControlChars.Lf)
												Console.Write("{0:F2}", "9x + 1y + 2z = 3          9 1 2 3  ->hit enter")
												Console.Write("{0:F2}", ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & "Your input:" & ControlChars.Lf)
													For x As Integer = 0 To 2
														For y As Integer = 0 To 3
															cin >> eq(x, y)
														Next y
													Next x
												Console.Write("{0:F2}", "How many iterations do you want?  ->")
												cin>>userlimit
												GlobalMembersMain.clr()
												GlobalMembersMain.Seidel()
												Console.Write("{0:F2}", ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & " Equations:" & ControlChars.Lf & " ")
												Console.Write("{0:F2}", eq(0, 0))
												Console.Write("{0:F2}", "x1 + ")
												Console.Write("{0:F2}", eq(0, 1))
												Console.Write("{0:F2}", "y1 + ")
												Console.Write("{0:F2}", eq(0, 2))
												Console.Write("{0:F2}", "z1 = ")
												Console.Write("{0:F2}", eq(0, 3))
												Console.Write("{0:F2}", ControlChars.Lf)
												Console.Write("{0:F2}", " ")
												Console.Write("{0:F2}", eq(1, 0))
												Console.Write("{0:F2}", "x2 + ")
												Console.Write("{0:F2}", eq(1, 1))
												Console.Write("{0:F2}", "y2 + ")
												Console.Write("{0:F2}", eq(1, 2))
												Console.Write("{0:F2}", "z2 = ")
												Console.Write("{0:F2}", eq(1, 3))
												Console.Write("{0:F2}", ControlChars.Lf)
												Console.Write("{0:F2}", " ")
												Console.Write("{0:F2}", eq(2, 0))
												Console.Write("{0:F2}", "x3 + ")
												Console.Write("{0:F2}", eq(2, 1))
												Console.Write("{0:F2}", "y3 + ")
												Console.Write("{0:F2}", eq(2, 2))
												Console.Write("{0:F2}", "z3 = ")
												Console.Write("{0:F2}", eq(2, 3))
												Console.Write("{0:F2}", ControlChars.Lf & ControlChars.Lf)
												GlobalMembersMain.bracket1()
												Console.Write("{0:F2}", ControlChars.Lf & " |  Iteration  |     ")
												Console.Write("{0:F2}", "x1         ")
												Console.Write("{0:F2}", "x2        ")
												Console.Write("{0:F2}", "x3      |" & ControlChars.Lf)
												GlobalMembersMain.bracket2()
												Console.Write("{0:F2}", " |      ")
												Console.Write("{0:F}", i)
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
														Case 4
															GlobalMembersMain.clr()
																	Case Else
																		GlobalMembersMain.clr()
																		GlobalMembersMain.Invalid()
																		Console.Write("{0:F}", "                                                    Invalid input, please try again..." & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf)
																		cin.ignore()
																		Console.Read()
																		GlobalMembersMain.Menu()
				End Select
			Loop While submenu<>4
			Case 2
				GlobalMembersMain.clr()
				GlobalMembersMain.Help()
				Console.Write("{0:F}", "Hit enter to continue...")
					cin.ignore()
					Console.Read()
				GlobalMembersMain.clr()
				GlobalMembersMain.Help2()
				Console.Write("{0:F}", "Hit enter to continue...")
					cin.ignore()
					Console.Read()
				Case 3
					GlobalMembersMain.clr()
					GlobalMembersMain.About()
					Console.Write("{0:F}", "Hit enter to continue...")
						cin.ignore()
						Console.Read()
					GlobalMembersMain.clr()
					GlobalMembersMain.About2()
					Console.Write("{0:F}", "Hit enter to continue...")
						cin.ignore()
						Console.Read()
					Case 4
						GlobalMembersMain.clr()
						GlobalMembersMain.Exit()
						Case Else
							GlobalMembersMain.clr()
							GlobalMembersMain.Invalid()
							Console.Write("{0:F}", "                                                    Invalid input, please try again..." & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf)
								cin.ignore()
								Console.Read()
								GlobalMembersMain.Home()
	End Select
	Loop While x<>4

	Return 0
	End Function
End Class

