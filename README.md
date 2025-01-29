# F# Mutable Variable Behavior in Recursion

This repository demonstrates an uncommon issue related to the behavior of mutable variables within recursive functions in F#.  The example highlights the difference between directly using mutable variables and using references to mutable variables within a recursive context.

## Problem

The `loop1` function directly uses mutable variables `x` and `y`.  Despite modifying them within the recursive call, the changes are not reflected outside the function's scope.

The `loop2` function uses references (`ref`) to mutable variables. The changes made inside the recursion are properly reflected outside the function's scope.

## Solution

The solution is to use references (`ref`) when you need to modify a mutable variable and have those changes persist beyond the scope of the recursive function. The references provide a way to pass and modify the mutable variables by reference.

## How to reproduce the bug

1. Clone this repository.
2. Open the `bug.fs` file in a F# environment.
3. Compile and run the code. Observe the output.