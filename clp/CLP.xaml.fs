namespace clp

open System.Windows
open clp.operators

type CPLMainWindow private (xaml : Window) = 
    new () = 
        CPLMainWindow(window "CLP.xaml")
    
    member this.Run() =
        (new Application()).Run xaml