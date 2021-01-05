using System;

delegate void StringProcessor(string input);     //❶声明委托类型

class Person

{

   string name;

   public Person(string name) { this.name = name; }

   public void Say(string message)       //❷声明兼容的实例方法

   {

      Console.WriteLine("{0} says: {1}", name, message);

   }

}

class Background

{

   public static void Note(string note)     //❸声明兼容的静态方法

   {

      Console.WriteLine("({0})", note);

   }

}

class SimpleDelegateUse

{

   static void Main()

   {

      Person jon = new Person("Jon");

      Person tom = new Person("Tom");

      StringProcessor jonsVoice, tomsVoice, background;      /*❹（以下4行）创建3个委托实例*/

      jonsVoice = new StringProcessor(jon.Say);

      tomsVoice = new StringProcessor(tom.Say);

      background = new StringProcessor(Background.Note);

　

      jonsVoice("Hello, son.");      /*❺（以下3行）调用委托实例*/

      tomsVoice.Invoke("Hello, Daddy!");

      background("An airplane flies past.");

   }

}