import cmath
import math
from qubit import Qubit


def apply_gate(qubit, gate):
    """Applying the gate to the qubit by matrix multiplication."""
    alpha, beta = qubit.get_state()
    new_alpha = gate[0][0] * alpha + gate[0][1] * beta
    new_beta = gate[1][0] * alpha + gate[1][1] * beta
    qubit.set_state(new_alpha, new_beta)


# Define some common gates
X_GATE = [[0, 1], [1, 0]]  # Pauli-X gate (NOT gate)
Y_GATE = [[0, -1j], [1j, 0]]  # Pauli-Y gate
Z_GATE = [[1, 0], [0, -1]]  # Pauli-Z gate
H_GATE = [[1 / math.sqrt(2), 1 / math.sqrt(2)], [1 / math.sqrt(2), -1 / math.sqrt(2)]]  # Hadamard gate


# Example usage:
if __name__ == "__main__":
    qubit = Qubit()

    # Apply the X gate (NOT gate)
    apply_gate(qubit, X_GATE)
    print("State after applying X gate:", qubit.get_state())

    # Apply the Hadamard gate
    apply_gate(qubit, H_GATE)
    print("State after applying Hadamard gate:", qubit.get_state())
