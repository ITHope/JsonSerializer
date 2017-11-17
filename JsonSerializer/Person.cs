namespace JsonSerializer
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(int Id, string FirstName, string LastName, int Age)
        {
            Init(Id, FirstName, LastName, Age);
        }
        public Person()
        {

        }
        public void Init(int Id, string FirstName, string LastName, int Age)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public string ToJson()
        {
            string json_string = "{";
            json_string += "Id:" + Id + ",";
            json_string += "FirstName:" + FirstName + ",";
            json_string += "LastName:" + LastName + ",";
            json_string += "Age:" + Age + "";
            json_string += "}";
            return json_string;
        }
    }
}