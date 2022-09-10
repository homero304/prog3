import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;

public class RandomWord {
    public static void main(String[] args) {
        int i = 1;
        String word = "";
        while(!StdIn.isEmpty()) {
            if (StdRandom.bernoulli(1.0/i)) {
                word = StdIn.readString();
            }
            i++;
        }
        StdOut.println(word);
    }       
}

