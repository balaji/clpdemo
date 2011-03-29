module clp.operators

open System.Windows
open System.Windows.Controls

let appname = "clp"

let window name =
    System.Windows.Application.LoadComponent(System.Uri(sprintf "/%s;component/%s" appname name, System.UriKind.Relative)) :?> Window

let (?) (window : Window) name =
    window.FindName name
    |> unbox

let inline (+=) (event : IEvent<_, _>) handler =
    (event :> Microsoft.FSharp.Control.IDelegateEvent<_>).AddHandler(RoutedEventHandler(handler))