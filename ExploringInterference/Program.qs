namespace ExploringInterference {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Measurement;

    operation TestInterference1() : Unit {
        use q = Qubit();
        Message(" ");
        Message("At the beginning the qubit is in the state |0>.");
        DumpMachine();
        H(q);
        Message(" ");
        Message("After applying H the qubit is in a uniform superposition.");
        DumpMachine();
        H(q);
        Message(" ");
        Message("If we apply H again, interference gives back the state to |0>.");
        DumpMachine();
        Message(" ");
        Message("If we measure we always obtain 'Zero'.");
    }

    operation TestInterference2() : Unit {
        use q = Qubit();
        X(q);
        H(q);
        DumpMachine();
        Reset(q);
    }

    
    operation TestInterference3() : Unit {
        use q = Qubit();
        Y(q);
        H(q);
        DumpMachine();
        Reset(q);
    }

    @EntryPoint()
    operation test() : Unit {
        TestInterference1();
        Message("End of Test 1");

        TestInterference2();
        Message("End of Test 2");

        TestInterference3();
        Message("End of Test 3");

    }
}