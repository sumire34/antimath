using System;

public static class GlobalMembersMain4
{

	public static void Seidel()
	{
	Console.Write("");
	}
	public static void bracket1()
	{
	Console.Write("");
	}
	public static void bracket2()
	{
	Console.Write("");
	}
	public static void bracket3()
	{
	Console.Write("");
	}
	public static void clr()
	{
	Console.Write("");
	}
	public static void clrs()
	{
	Console.Write("");
	}



	static int Main()
	{
	float x1 = 0F;
	float x2 = 0F;
	float x3 = 0F;
	float a = 0F;
	float b = 0F;
	float c = 0F;
	float i = 1F;
	float userlimit;
	float blankcontainer;

	GlobalMembersMain.Seidel();
	GlobalMembersMain.clrs();
		Console.Write("Welcome to Gauss Seidel Method\n");
		int[,] eq = new int[3, 4];
			Console.Write("Please enter the coefficients, values are separated with a space.\n\n");
			Console.Write("Example                   Your Input\n");
			Console.Write("1x + 2y + 3z = 4          1 2 3 4  ->hit enter\n");
			Console.Write("5x + 6y + 7z = 8    >>    5 6 7 8  ->hit enter     or      1 2 3 4 5 6 7 8 9 1 2 3    ->hit enter\n");
			Console.Write("9x + 1y + 2z = 3          9 1 2 3  ->hit enter");
			Console.Write("\n\nYour input:\n");
				for (int x = 0; x < 3; x++)
				{
					for (int y = 0; y < 4; y++)
					{
						cin >> eq[x, y];
					}
				}
						Console.Write("How many iterations do you want?  ->");
							cin >> userlimit;
						GlobalMembersMain.clr();
						GlobalMembersMain.Seidel();
							Console.Write("\n\n\n\n Equations:\n ");
							Console.Write(eq[0, 0]);
							Console.Write("x1 + ");
							Console.Write(eq[0, 1]);
							Console.Write("y1 + ");
							Console.Write(eq[0, 2]);
							Console.Write("z1 = ");
							Console.Write(eq[0, 3]);
							Console.Write("\n");
							Console.Write(" ");
							Console.Write(eq[1, 0]);
							Console.Write("x2 + ");
							Console.Write(eq[1, 1]);
							Console.Write("y2 + ");
							Console.Write(eq[1, 2]);
							Console.Write("z2 = ");
							Console.Write(eq[1, 3]);
							Console.Write("\n");
							Console.Write(" ");
							Console.Write(eq[2, 0]);
							Console.Write("x3 + ");
							Console.Write(eq[2, 1]);
							Console.Write("y3 + ");
							Console.Write(eq[2, 2]);
							Console.Write("z3 = ");
							Console.Write(eq[2, 3]);
							Console.Write("\n\n");
						GlobalMembersMain.bracket1();
							Console.Write("\n |  Iteration  |     ");
							Console.Write("x1         ");
							Console.Write("x2        ");
							Console.Write("x3      |\n");
						GlobalMembersMain.bracket2();
							Console.Write(" |      ");
							Console.Write(i);
							Console.Write(@fixed);
							Console.Write("{0:4}", "      |   ");
							Console.Write("{0:4}", x1);
							Console.Write("{0:4}", "     ");
							Console.Write("{0:4}", x2);
							Console.Write("{0:4}", "    ");
							Console.Write("{0:4}", x3);
							Console.Write("{0:4}", "    |\n");
								for (int i = 2; i < userlimit + 1; i++)
								{
									x1 = (eq[0, 3] + (eq[0, 1] * b * -1) + (eq[0, 2] * c * -1)) / eq[0, 0];
										a = x1;
									x2 = (eq[1, 3] + (eq[1, 0] * a * -1) + (eq[1, 2] * c * -1)) / eq[1, 1];
										b = x2;
									x3 = (eq[2, 3] + (eq[2, 0] * a * -1) + (eq[2, 1] * b * -1)) / eq[2, 2];
										c = x3;
									Console.Write("{0:4}", " |      ");
									Console.Write("{0:4}", i);
									Console.Write("{0:4}", "      |   ");
									Console.Write("{0:4}", x1);
									Console.Write("{0:4}", "    ");
									Console.Write("{0:4}", x2);
									Console.Write("{0:4}", "    ");
									Console.Write("{0:4}", x3);
									Console.Write("{0:4}", "    |\n");
								}
						GlobalMembersMain.bracket3();
							Console.Write("{0:4}", @fixed);
						GlobalMembersMain.bracket1();
							Console.Write("{0}", "\n |             Sequences converges at:            |\n");
							Console.Write("{0}", " |         x1 = ");
							Console.Write("{0}", x1);
							Console.Write("{0}", "  |  x2 = ");
							Console.Write("{0}", x2);
							Console.Write("{0}", "  |  x3 = ");
							Console.Write("{0}", x3);
							Console.Write("{0}", "          |                      Press enter to continue...\n");
						GlobalMembersMain.bracket3();
							cin.ignore();
							Console.Read();

	return 0;
	}
}

