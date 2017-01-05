namespace Exercise
{
    public class Customer : LibObject, IRegistarable
    {
        public string Address { get; set; }

        public Customer(string name, string addr)
        {
            NameOrTitle = name;
            Address = addr;
            ObjType = ObjectType.Person;
        }


        public RegisteredObject GetRegistrationInfo()
        {
            return new RegisteredObject
            {
                Info = "Name: " + NameOrTitle + ", Address: " + Address
            };
        }

        public void SetId(int id)
        {
            ObjectId = id;
        }
    }
}
