namespace TodoV1
{
    class ToDo
    {
        private int _serial;
        public int Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }
        public string Name { get; set; }
        public enum StatusType
        {
            Open = 0,
            Done = 1
        };
        public StatusType Status { get; set; }

        public override string ToString()
        {
            return Serial + ";" + Name + ";" + (int)Status;
        }

    }
}
