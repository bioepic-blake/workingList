using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;

namespace visibleTheList
{
	public partial class ViewController : UIViewController
	{
		private UILabel _lblRetutn;
		private UILabel _lblRetutn2;
		private UILabel _lbl1;///	• 1 Create a method that does something but doesn't return anything 
		public string str3;///	• 1 Create a method that does something but doesn't return anything 

		private UILabel _lbl2; ///2 Create a method that returns a string

		private UILabel _lbl3;///• 3 Create method that returns a float

		private UILabel _lbl4;///• 7 Create a method that takes an argument

		private UILabel _lbl5;///• 8 Create a method that takes an argument* and* at least one optional argument

		private UILabel _lbl6;///• 9  Create, subscribe and react to an event



		public event Action FireEvent;

		public string str1 = "blake ";
		public string str2 = "hello ";

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			View.BackgroundColor = UIColor.White;

			labelM();///	• 1 Create a method that does something but doesn't return anything 
			stringM();///	• 1 Create a method that does something but doesn't return anything 

			lbl2();///• 2 Create a method that returns a string
			stringReturn();
			stringConnect();///• 2 Create a method that returns a string


			lblFloat();///• 3 Create method that returns a float
			floatRetern();///• 3 Create method that returns a float
			connectFloat();///• 3 Create method that returns a float

			lblMA(); ///• 7 Create a method that takes an argument
			MethodArgument(10, 20, 0);

			lblMAO();///• 8 Create a method that takes an optinal argument
			methodOptinalArgument(10, 20);///• 8 Create a method that takes an optinal argument

			lblEvent();///• 9  Create, subscribe and react to an event

			FireEvent += ShowString;///• 9  Create, subscribe and react to an event
			fEvent(); ///• 9  Create, subscribe and react to an event

			_lblRetutnM();
			listMethods();
			listLoop();
            _lblRetutn2M();
			returnM();

			addstring();
		}



		///	• 1 Create a method that does something but doesn't return anything 
		public void labelM()
		{
			var rect = new CoreGraphics.CGRect(25, 200, 150, 50);
			_lbl1 = new UILabel(rect);
			_lbl1.Text = "lbl1";
			View.Add(_lbl1);
		}
		private void stringM()
		{
			string str1 = "hello";
			string str2 = "blake";

			_lbl1.Text = $"lbl1 {str1} {str2}";
		}
		//=========================================================================
		///• 2 Create a method that returns a string
		public void lbl2()
		{
			var rect = new CoreGraphics.CGRect(25, 250, 300, 50);
			_lbl2 = new UILabel(rect);
			_lbl2.Text = "lbl2";
			View.Add(_lbl2);
		}
		public void stringConnect()
		{
			string s1 = stringReturn();
			_lbl2.Text = s1;
		}

		private string stringReturn()
		{
			string string1 = " lbl2 this is a returned string";
			return string1;
		}
		//=======================================================================
		///• 3 Create method that returns a float
		private void lblFloat()
		{
			var rect = new CGRect(25, 300, 250, 50);
			_lbl3 = new UILabel(rect);
			_lbl3.Text = "float";
			View.Add(_lbl3);

		}
		public void connectFloat()
		{
			float float1 = floatRetern();
			_lbl3.Text = $" lintfloat returned {float1}";
		}
		public float floatRetern()
		{
			float f1 = 15f;
			float f2 = 13f;
			float f3;
			f3 = f1 + f2;
			return f3;
		}
		//===========================================
		////• 4 Write a new class 
		public class class2
		{


		}
		//================================================
		///• 5 Create a method that returns a type of the class you've just created( using returnClass.cs)
		/// public class returnClass
		//	{

		//			public string color { get; set; }
		//public string smell { get; set; }


		//public returnClass(string Smell)
		//{
		//smell = Smell;
		//color = color;

		//}
		//public string smellRM()
		//{
		//	string smell1 = smell;
		//	return smell1;
		//		}
		//	}
		//}
		/// see returnClasss for the code 
		/// 
		//========================================================
		///• 6 Create a new object from your custom class and use the method described in the previous step
		public void returnM()
		{
			returnClass rc = new returnClass("good");

			string str22 = rc.smell;
			_lblRetutn.Text = str22;

			string str11 = rc.smellRM();
			_lblRetutn2.Text = str11;
		}


		private void _lblRetutnM()
		{
			var rect = new CGRect(25, 100, 250, 50);
			_lblRetutn = new UILabel(rect);
			_lblRetutn.Text = "defalt";
			View.Add(_lblRetutn);
		}
		private void _lblRetutn2M()
		{
			var rect = new CGRect(25, 50, 250, 50);
			_lblRetutn2 = new UILabel(rect);
			_lblRetutn2.Text = "defalt";
			View.Add(_lblRetutn2);
		}





		//=======================================================
		///• 7 Create a method that takes an argument
		public void lblMA()
		{
			var rect = new CGRect(25, 350, 250, 50);
			_lbl4 = new UILabel(rect);
			_lbl4.Text = $"method argument";
			View.Add(_lbl4);
		}



		public void MethodArgument(int x, int y, int z)
		{

			z = x + y;
			_lbl4.Text = $"method argument {z}";
		}
		//==================================================
		///• 8 Create a method that takes an argument* and* at least one optional argument
		public void lblMAO()
		{
			var rect = new CGRect(25, 400, 250, 250);
			_lbl5 = new UILabel(rect);
			_lbl5.Text = $"method argument";
			View.Add(_lbl5);
		}

		public void methodOptinalArgument(int y, int z, int x = 15)
		{

			z = x + y;
			_lbl5.Text = $"lbl5 method argument {z}";

		}
		//======================================================
		///• 9  Create, subscribe and react to an event
		public void fEvent()
		{
			FireEvent();

		}


		public void ShowString()
		{
			_lbl6.Text = "event used ";
		}
		public void lblEvent()
		{
			var rect = new CGRect(25, 450, 250, 250);
			_lbl6 = new UILabel(rect);
			_lbl6.Text = $"event";
			View.Add(_lbl6);
		}
		//==================================
		///• 10 Create a list of types e.g. string, int, a custom class(in next section) etc.
		public void listMethods()
		{
			List<int> List1 = new List<int>();
			List1.Add(1);
			List1.Add(2);
			List1.Add(3);

			List<string> list2 = new List<string>();
			list2.Add("hello");
			list2.Add("world");
			list2.Add("one");

			class2 c2 = new class2();

			List<class2> list3 = new List<class2>()
			{
				c2
			};

		}
		//=========================================================	
		///• 11 Create a loop that iterates through a list and add certain elements (based on a criteria you decide)
		///to a second list.
		public int _intLoop;

		public void listLoop()
		{

			List<int> list4 = new List<int>();
			list4.Add(1);
			list4.Add(2);
			list4.Add(3);

			List<int> list5 = new List<int>();
			list5.Add(1);
			list5.Add(3);
			list5.Add(4);

			foreach (int int1 in list4)
			{
				_intLoop = int1;

				if (_intLoop == 2)
				{

					list5.Add(2);
				}
			}
		}
		//======================================================
		///	• Create a string and add extra content to it every 10 seconds.
		public async Task addstring()
		{



			for (int i = 0; i < 20; i++)
			{
				str1 += str2;
				await Task.Delay(10000);
			}
		}

	}
}
////			• What does private mean?
//Private means that only the class its defined in or a class that dirves from that class can asses the variable

////• What does public mean?
//Public means that the veriabl/method is open and can be called upon/worked with from an outside class

////• What does static mean?
//Static = fixed, it can only contain static members, cannot be instantiated

////• The difference between a property and a field.
//A field is a variable declared directly in the class normally private.
//A property is a way to access the field, the get set property will alaw access to the variable/field without directly working with it providing a level of abstraction 


////• The purpose of a public get and a private set in a property.
//Private set’ers law you to create read-only / protected propertys.


////• The purpose of interfaces.
// an interface can be seen as a contract btween classes, with the Ispeek or Istore ect defined in the interface class
// the classes that then dirive from that class e.g. class somthing : Ispeek, Istore. must then forfill the objects/propertys from the I classes



////• Polymorphism
//??? is the ability to take an object and changing it into sevral difrent ways. this is closly linked with inheritance. 
//Polymorphism is when you can treat an object as a generic version of something, 
//but when you access it, the code determines which exact type it is and calls the associated code.




////• Overloading
//Overriding is where there may be methods of the same name but they must take in different arguments, e.g.
//method1(int x, int y)
//method1(int x, string y)
//method1(int x, int y, string z)
//Each method is called the same but take different arguments

