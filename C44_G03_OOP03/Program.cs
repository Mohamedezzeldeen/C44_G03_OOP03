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
    internal class Program
    {
        static void Main(string[] args)
        {
            #region V01
            //Create Object | Intance from Car
            //Car C01;
            //1. Allocate 4 Bytes in stack [Null] 
            //C01 = new Car(10,"Audio",500);


            //Console.WriteLine(C01);
            //Console.WriteLine(C01.ToString()); 
            #endregion
        }
    }
}
