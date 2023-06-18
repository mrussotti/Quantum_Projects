from qubit import Qubit
from gates import apply_gate, X_GATE, H_GATE


class QuantumCircuit:
    def __init__(self, num_qubits):
        self.qubits = [Qubit() for _ in range(num_qubits)]
        self.gates = []

    def add_gate(self, gate, target_qubit):
        if not (0 <= target_qubit < len(self.qubits)):
            raise ValueError("Invalid target qubit index")
        self.gates.append((gate, target_qubit))

    def execute(self):
        for gate, target_qubit in self.gates:
            apply_gate(self.qubits[target_qubit], gate)

    def get_state(self, qubit_index):
        if not (0 <= qubit_index < len(self.qubits)):
            raise ValueError("Invalid qubit index")
        return self.qubits[qubit_index].get_state()


# Example usage:
if __name__ == "__main__":
    # Create a quantum circuit with 2 qubits
    circuit = QuantumCircuit(2)

    # Add an X gate on the first qubit
    circuit.add_gate(X_GATE, 0)

    # Add an H gate on the second qubit
    circuit.add_gate(H_GATE, 1)

    # Execute the circuit
    circuit.execute()

    # Print the state of each qubit
    print("State of qubit 0:", circuit.get_state(0))
    print("State of qubit 1:", circuit.get_state(1))