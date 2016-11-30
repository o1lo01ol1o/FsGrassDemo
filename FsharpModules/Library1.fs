namespace FsharpModules
open Grasshopper //<--These methods are accessable so long as you have a reference to grasshopper.dll etc
open Rhino

module Main =
    //val main : string
    let main = "this would be the main function"


module Interpolation =

    type CezanneOnRubens = 
        | A 
        | B 
        | C 
        | D 
        | E 
        | F 
        | G 
        | H 
        | I 

    // This is a tree structure
    type Lineage = 
        | Pater of CezanneOnRubens // it's either the root (above)
        | Patrimony of Lineage * Lineage  // or it's the product of two lineages

    type Individual = Set<CezanneOnRubens> // individual is the sum of parents

    // recursively count generations given a lineage
    let rec getGenerationNo (t:Lineage) (g:int) = // note "rec" in funciton binding
        match t with
        | Pater root -> g
        | Patrimony (maternal, _) -> getGenerationNo maternal (g + 1)

    //Get the ancestors
    let rec givenName (t:Lineage) (l: Set<CezanneOnRubens>) =
        match t with
        | Pater root -> Set.add root Set.empty
        | Patrimony (m, p) -> let mat = givenName m l
                              let pat = givenName p l
                              Set.union mat pat
        

    type Drawing = Rhino.Geometry.Curve list

    type APointInCORSpace = 
        {
        Drawing: Drawing; // You'll have to leave this empty until you make the new drawing
        Identity: Lineage
        }

    let fornicate (a : APointInCORSpace) (b:APointInCORSpace ) = // and yields a new childs
        let newchild = "implent me here"
        newchild // <-- return this value

 

