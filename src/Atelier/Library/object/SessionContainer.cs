
using Library.@object;

public class SessionContainer {

    private Internaute internaute;

    public SessionContainer() {
        this.internaute = new Internaute();
    }

    public Internaute getInternaute() {
        return internaute;
    }
}
