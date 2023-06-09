//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ExploringSuperposition\",\"Name\":\"GenerateUniformState\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":8,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\matth\\\\ExploringSuperposition\\\\ExploringSuperposition\\\\Program.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"ExploringSuperposition\",\"Name\":\"GenerateUniformState\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\matth\\\\ExploringSuperposition\\\\ExploringSuperposition\\\\Program.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
#line hidden
namespace ExploringSuperposition
{
    [SourceLocation("C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs", OperationFunctor.Body, 10, -1)]
    public partial class GenerateUniformState : Operation<QVoid, Int64>, ICallable
    {
        public GenerateUniformState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateUniformState";
        String ICallable.FullName => "ExploringSuperposition.GenerateUniformState";
        public static EntryPointInfo<QVoid, Int64> Info => new EntryPointInfo<QVoid, Int64>(typeof(GenerateUniformState));
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Canon__ApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Diagnostics__DumpMachine
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<IQArray<Boolean>, Int64> Microsoft__Quantum__Convert__BoolArrayAsInt
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, IQArray<Boolean>> Microsoft__Quantum__Convert__ResultArrayAsBoolArray
        {
            get;
            set;
        }

        public override Func<QVoid, Int64> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 11 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                var qubits = Allocate__.Apply(3L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 12 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, qubits));
#line 13 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    Message__.Apply("The qubit register in a uniform superposition: ");
#line 14 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
#line 15 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    var results = new QArray<Result>();
#line 16 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    foreach (var q in qubits)
#line hidden
                    {
#line 17 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                        Message__.Apply(" ");
#line 18 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                        results = QArray<Result>.Add(results, new QArray<Result>(Microsoft__Quantum__Intrinsic__M.Apply(q)));
#line 19 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                        Microsoft__Quantum__Diagnostics__DumpMachine.Apply(QVoid.Instance);
                    }

#line 21 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    Message__.Apply(" ");
#line 22 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    Message__.Apply("Your random number is: ");
#line 23 "C:\\Users\\matth\\ExploringSuperposition\\ExploringSuperposition\\Program.qs"
                    return Microsoft__Quantum__Convert__BoolArrayAsInt.Apply(Microsoft__Quantum__Convert__ResultArrayAsBoolArray.Apply(results?.Copy()));
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(qubits);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Canon__ApplyToEach = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Microsoft__Quantum__Diagnostics__DumpMachine = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Diagnostics.DumpMachine<>));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Microsoft__Quantum__Convert__BoolArrayAsInt = this.__Factory__.Get<ICallable<IQArray<Boolean>, Int64>>(typeof(global::Microsoft.Quantum.Convert.BoolArrayAsInt));
            this.Microsoft__Quantum__Convert__ResultArrayAsBoolArray = this.__Factory__.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(global::Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<GenerateUniformState, QVoid, Int64>(QVoid.Instance);
        }
    }
}