using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
		private int id;
		private int speed;
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        //If you didn't create colnstructor
        //CLR : will Create Parameterless Constructor
        //This Constructor Do Nothing
        public Car()
        {

        }

        // Constructor Chaining
        public Car(int id, int speed, string model)
            :this(id, speed)
        {
            //this.id = id;
			//this.speed = speed;
			this.model = model;
        }
        public Car(int id, int speed)
            :this(id)
        {
            //this.id = id;
            this.speed = speed;
        }
        public Car(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return $"Id: {id} :: Speed: {speed} :: Model: {model}";
        }

    }
}
