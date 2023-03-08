// See https://aka.ms/new-console-template for more information

using CodeTesterConsoleApp;
using CodeTesterConsoleApp.ImplementingReflection;
using CodeTesterConsoleApp.StringAndStringBuilder;
using CodeTesterConsoleApp.UnitTesting;
using CodeTesterConsoleApp.UsingEventsDelegates;

int a;
var b = 20;

#region OutAndRef

Console.WriteLine("=========================Out and ref================================");

Console.WriteLine(new RefAndOut().Update(out a, ref b));

Console.WriteLine("=========================================================");

//the value of a can be extracted as follows
Console.WriteLine("the value of a is " + a);

Console.WriteLine("=========================End of out and ref================================");

#endregion

#region StaticClass

Console.WriteLine("====================Static Class=====================================");

StaticClass.test();
ClassOne cs = new();
cs.Tester();

#endregion

#region Array

Console.WriteLine("============================Array=============================");

new JaggedArray().Tester();
Console.WriteLine("Hello, World!");

#endregion


Console.WriteLine("========================Try Catch=================================");

new TryCatchClass().GettingError(4);

#region PropertyVsField

Console.WriteLine("========================PropertyVsField=================================");

//new PropertyVsField().a.Equals(5);
new PropertyVsField().Field = 34;
new PropertyVsField().Property = 34;
new PropertyVsField() { Field = 34, Property = 34 };

PropertyVsField pf = new PropertyVsField();
pf.Field = 323;
pf.Property = 323;
new PropertyVsField().Printer();

#endregion

Console.WriteLine("========================DelegatesAndEvents=================================");
new CreatingSubscriberPublisher();
//new TestClassForEvent().TestMethod();

Console.WriteLine("========================ImplementingReflections=================================");
new ImpReflections();

Console.WriteLine("========================StringAndStringBuilder=================================");
StringAndStringBuilder.WorkingWithStringBuilder() ;

Console.WriteLine("========================PerformingUnitTesting=================================");
new PerformUnitTesting().TestAddition();