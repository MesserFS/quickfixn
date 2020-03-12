// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XMLMessage.cs" company="">
//   
// </copyright>
// <summary>
//   XMLMessage.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace QuickFix
{
    namespace FIX44
    {
        public class XMLMessage : Message
        {
            public const string MsgType = "n";

            public XMLMessage()
                : base()
            {
                this.Header.SetField(new Fields.MsgType("n"));
            }
        }
    }
}