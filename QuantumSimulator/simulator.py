from circuit import QuantumCircuit
from gates import X_GATE, H_GATE, Y_GATE, Z_GATE


def main():
    print("Welcome to the Quantum Simulator!\n")

    # Ask user for number of qubits
    num_qubits = int(input("Enter the number of qubits: "))

    # Create a quantum circuit
    circuit = QuantumCircuit(num_qubits)

    # Gate selection menu
    gates = {
        'X': X_GATE,
        'H': H_GATE,
        'Y': Y_GATE,
        'Z': Z_GATE
    }
    
    print("\nAvailable gates: X, Y, Z, H")
    
    while True:
        # Ask user for gate and target qubit
        user_input = input("Enter gate and target qubit index (e.g. 'H 0') or 'run' to execute: ")
        
        # Check if user wants to execute the circuit
        if user_input.lower() == 'run':
            break
        
        # Parse user input and add gate to circuit
        try:
            gate_name, target_qubit = user_input.split()
            target_qubit = int(target_qubit)
            if gate_name in gates:
                circuit.add_gate(gates[gate_name], target_qubit)
            else:
                print("Invalid gate name.")
        except ValueError:
            print("Invalid input format. Please enter gate and target qubit index.")

    # Execute the circuit
    circuit.execute()

    # Print the state of each qubit
    for i in range(num_qubits):
        print(f"State of qubit {i}:", circuit.get_state(i))


if __name__ == "__main__":
    main()
