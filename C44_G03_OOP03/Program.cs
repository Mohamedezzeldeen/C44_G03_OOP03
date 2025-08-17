namespace C44_G03_OOP03
{
    #region V01
    internal class Car
    {
        #region Attributes

        private int id = default; // 4 Byte
        private string? model = default; // 4 Byte
        private double speed = default; // 8 Byte

        #endregion

        #region Constrain
        //Empty Parmterless Constructor [Default Constructor]
        // Auto-Genereated By Compiler

        public Car()
        {
            // Empty
        }

        public Car(int id, string? model, double _speed)
        {
            this.id = id;
            this.model = model;
            speed = _speed;
            Console.WriteLine("1st CTOR");
        }

        #region V02
        #region Overloading
        public Car(int id, string? model) : this(id, model, 250)
        {
            //this.id = id;
            //this.model = model;
            //speed = 250;
            Console.WriteLine("2st CTOR");
        }

        public Car(int id) : this(id, "Audio", 190)
        {
            this.id = id;
            this.model = "Audi";
            speed = 190;
            Console.WriteLine("3st CTOR");
        }
        #endregion
        #endregion

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get => speed;
            set => speed = value;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $" Id = {id}\n Model = {model}\n Speed = {speed}";
        }

        #endregion

    }
    #endregion

    #region V04
    internal class Parent
    {

        #region Properties

        public int X { get; set; }
        public int Y { get; set; }

        #endregion

        #region Constractor

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Method
        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }

        public virtual void MyFun()
        {
            Console.WriteLine("I'm Parent");
        }
        #endregion


    }

    //By Defult Constructor Of Child Make Constructor Chaning Parent Empty ParamterLess Constructor 
    internal class Child : Parent
    {
        #region Property
        public int Z { get; set; }
        #endregion

        #region Constractor
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}, Z = {Z}";
        }

        public override int Product()
        {
            //return X * Y * Z;
            // Or Better
            return base.Product() * Z;
        }

        //public override void MyFun()
        //{
        //    Console.WriteLine("I'm Child");
        //}

        // Or

        public new void MyFun()
        {
            Console.WriteLine("I'm Child");
        }

        #endregion


    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V01
            //Create Object | Intance from Car
            //Car C01;
            //1. Allocate 4 Bytes in stack [Null] 
            //C01 = new Car(10,"Audio",500);

            #region V02

            //C01 = new Car(10);
            //C01 = new Car(10,"Fiat-128");

            #endregion

            //Console.WriteLine(C01);
            //Console.WriteLine(C01.ToString()); 
            #endregion

            #region V04
            //Parent parent = new Parent(10,20);
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Product());
            //parent.MyFun();

            //Child child = new Child(10,20,30);

            //Console.WriteLine(child);
            //Console.WriteLine(child.Product());
            //child.MyFun();
            #endregion

            #region V05

            #region Access Modifier 
            //TypeA typeA = new TypeA();

            //typeA.A = 1; // Not valid because it is private
            //typeA.B = 1; // not valid because it is internal in the other projected
            //typeA.C = 1; // public can be shown every where
            //typeA.X = 1; // private protected without inheritence means private
            //typeA.Y = 1; // protected without inheritance means private
            //typeA.Z = 1; // protected internal without inheritence means internal can't be shown in the other project
            #endregion

            #endregion
        }
    }
}
