Assembly_test:.ctor():this:
       ret      

Assembly_test:Returntest():System.String:this:
       mov      rax, qword ptr [(reloc)]
       mov      rax, gword ptr [rax]
       ret      