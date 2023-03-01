// See https://aka.ms/new-console-template for more information

using CodeTesterConsoleApp;

int a;
int b = 20;
Console.WriteLine(new RefAndOut().Update(out a, ref b));

//the value of a can be extracted as follows
Console.WriteLine("the value of a is " + a);

StaticClass.test();
ClassOne cs = new ();
cs.Tester();
new JaggedArray().Tester();
Console.WriteLine("Hello, World!");