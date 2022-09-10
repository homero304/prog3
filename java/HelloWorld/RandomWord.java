import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;

public class RandomWord {
    public static void main(String[] args) {
        int i = 1;
        String selected = "";
        while(!StdIn.isEmpty()) {
            String nextWord = StdIn.readString();
            if (StdRandom.bernoulli(1.0/i)) {
                selected = nextWord;
            }
            i++;
        }
        StdOut.println(selected);
    }       
}

