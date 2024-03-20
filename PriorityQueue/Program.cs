// Crea una cola de prioridad que permita agregar pacientes con su respectiva prioridad y que permita atender al paciente con mayor prioridad.
public class Paciente {
    public string Caso { get; set; }
    public int Prioridad { get; set; }
    public string Nombre { get; set; }

    public Paciente(string nombre, int prioridad, string caso) {
        Nombre = nombre;
        Prioridad = prioridad;
        Caso = caso;

    }
}

public class Program {
    public static void Main(string[] args) {
        PriorityQueue<Paciente, int> pacientes = new PriorityQueue<Paciente, int>();
        pacientes.Enqueue(new Paciente("Carlos", 3, "Fiebre alta"), 3);
        pacientes.Enqueue(new Paciente("Ana", 2, "Fractura expuesta"), 2);
        pacientes.Enqueue(new Paciente("Luis", 2, "Intoxicación"), 2);
        pacientes.Enqueue(new Paciente("Elena", 2, "Dolor de oído"), 2);
        pacientes.Enqueue(new Paciente("María", 1, "Paro cardíaco"), 1);

        
        while (pacientes.Count > 0) {
            Paciente paciente = pacientes.Dequeue();
            Console.WriteLine("Atendiendo a " + paciente.Nombre + " con prioridad " + paciente.Prioridad + " por " + paciente.Caso);
        }
    }
}