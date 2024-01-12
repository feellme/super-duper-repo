using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr
{
	class Program{
		static void Main(string[] args){
      Autobot optimus = new Autobot("optimus ", 5.45);
      Console.WriteLine(optimus.name);
      
      Decepticon megatron = new Decepticon("megatron");
      megatron.fly(2000);
      Gun machineGun = new Gun("machine gun");
      megatron.takeGun(machineGun);
		}
	}
	
	class Fabric{
	  static public Transformer prepareTransformer(String name, String gun, String secondGun){
		  Transformer raw = new Transformer(name);
			Gun first = new Gun(gun);
			Gun second = new Gun(secondGun);
			raw.takeGun(first);
			raw.takeSecondGun(second);
			return raw;
		}
	}

	class Transformer{
		public String name;
		private Gun gun;
		private Gun secondGun;
		public int speed = 0;

		public Transformer(String name){
			this.name = name;
		}
		
		public void takeGun(Gun gun){
		  this.gun = gun;
		}
		
		public void takeSecondGun(Gun gun){
		  this.secondGun = gun;
		}
	}
	
	class Decepticon : Transformer{
	  public Decepticon (String name) : base (name){}
	  
	  public void fly(int speed){
	    base.speed = speed;
	  }
	  
	  public void takeGun(Gun gun){
		  base.takeGun(gun);
		  reload();
		}
		
		private void reload(){
		  Console.WriteLine("Weapon was reloaded");
		}
	}
	
	class Autobot : Transformer{
	  Gun thirdGun;
	  double sizeOfCartridges;
	  
	  public Autobot(String name, double sizeOfCartridges) : base(name){
	    this.sizeOfCartridges = sizeOfCartridges;
	  }
	  
	  public void takeThirdGun(Gun gun){
	    this.thirdGun = gun;
	  }
	  
	  public void useNitro(){
	    speed += 300; // km per hour
	  }
	}
	
	class Gun{
	  public String name;
	  
	  public Gun(String name){
	    this.name = name;
	  }
	  
	  public void clean(){
	    Console.WriteLine("Cleaning finised.");
	  }
	}
}

class Wheel{}
