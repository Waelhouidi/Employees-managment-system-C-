namespace EMmployees
{
    internal class Admin
    {
        private string userName;
        private string password;
       
       

        public Admin( string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool VerifPassword(string password)
        {
            return this.password == password; 
        }
    }

}
