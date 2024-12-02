using System;
using System.Collections.Generic;

/// <summary>
/// The subsystem classes that the Facade will simplify access to.
/// </summary>
public class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubsystemA: OperationA");
    }
}

public class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubsystemB: OperationB");
    }
}

public class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubsystemC: OperationC");
    }
}

/// <summary>
/// The Facade class provides a simplified interface to the complex subsystem.
/// </summary>
public class Facade
{
    private readonly SubsystemA _subsystemA;
    private readonly SubsystemB _subsystemB;
    private readonly SubsystemC _subsystemC;

    /// <summary>
    /// Initializes a new instance of the Facade class.
    /// </summary>
    public Facade()
    {
        _subsystemA = new SubsystemA();
        _subsystemB = new SubsystemB();
        _subsystemC = new SubsystemC();
    }

    /// <summary>
    /// A method that simplifies access to the operations of the subsystems.
    /// </summary>
    public void SimplifiedOperation()
    {
        Console.WriteLine("Facade: Simplified operation started.");
        _subsystemA.OperationA();
        _subsystemB.OperationB();
        _subsystemC.OperationC();
        Console.WriteLine("Facade: Simplified operation completed.");
    }
}

/// <summary>
/// Client code demonstrating the use of the Facade pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// Main entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Create the facade instance.
        Facade facade = new Facade();

        // Client code can call the simplified interface provided by the facade.
        facade.SimplifiedOperation();
    }
}
