using System;
using System.Runtime.Serialization;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAllReadyLoginException("User already logged in");
            }
            catch (UserAllReadyLoginException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class UserAllReadyLoginException: Exception
    {
        public UserAllReadyLoginException():base()
        {

        }

        public UserAllReadyLoginException(string message): base(message)
        {

        }

        public UserAllReadyLoginException(string message, Exception context): base(message, context)
        {

        }

        public UserAllReadyLoginException(SerializationInfo info, StreamingContext context):base(info, context)
        {

        }


    }
}
