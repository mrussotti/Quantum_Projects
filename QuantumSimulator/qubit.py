import cmath


class Qubit:
    def __init__(self, state="0"):
        # Initialize the qubit
        # |0⟩ is represented as [1, 0]
        # |1⟩ is represented as [0, 1]
        if state == "0":
            self.state = [1, 0]
        elif state == "1":
            self.state = [0, 1]
        else:
            raise ValueError("Initial state must be '0' or '1'")

    def set_state(self, alpha, beta):
        # Set the state of the qubit to an arbitrary state
        # |ψ⟩ = α|0⟩ + β|1⟩
        # We need to ensure that |α|^2 + |β|^2 = 1
        if not cmath.isclose(abs(alpha) ** 2 + abs(beta) ** 2, 1, rel_tol=1e-9):
            raise ValueError("The squared magnitudes of the state vector must add up to 1")
        self.state = [alpha, beta]

    def get_state(self):
        # Get the state of the qubit
        return self.state


# Example usage:
qubit = Qubit()
print("Initial state:", qubit.get_state())

qubit.set_state(alpha=1 / cmath.sqrt(2), beta=1 / cmath.sqrt(2))
print("State after setting to equal superposition:", qubit.get_state())
