using System;
using Library.OOP;

namespace Library.Comment
{
    public class SessionContainer {

        private Internaute internaute;

        public SessionContainer() {
            this.internaute = new Internaute();
        }

        public Internaute getInternaute() {
            return internaute;
        }

        public void setMessageErreurKey(String messageErreurKey) {
        }
    
    }
}
