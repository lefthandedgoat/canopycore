﻿open prunner

let executingDir () = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
canopy.configuration.chromeDir <- executingDir()

functionsTests.add()
instancedTests.add()

prunner.run 3 |> ignore

System.Console.ReadKey() |> ignore