
namespace Library.OOP
{
    public class CV {

        private long intId;
        private long nivCode;
        private int cuvPourcentFormation;

        public CV() {
        }


        public void setIntId(long intId) {
            this.intId = intId;
        }

        public void setNivCode(long nivCode) {
            this.nivCode = nivCode;
        }

        public void setCuvPourcentFormation(int @decimal) {
            cuvPourcentFormation = @decimal;
        }
    }
}