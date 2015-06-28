# 3-22-12Tree
Tree

So I enjoyed this exercise. It was a lot trickier than I expected and took a little longer than I wanted (4.5 hours total).
Description: So I wrote this in C# in Visual Studios 2013. Either compile the project or just find the exe. in the folder
sturcture to run it. I built this on top of a very simple tree program I created 3 years ago (hence the project name). 
The script works as follows: First, the program reads in how many levels of the tree we will have. It then creates the tree
the first go around, simply addind a left and right child to every node until the level limit is reached. Along the way, the
script sets the basic data for certain nodes that don't rely on neighbors that are not at least one level removed. After the
shell of the tree is constructed, I go back and hook up all of the neighbors. This was the tricky part and I finally realized
that I had to loop this process one time for every level past 4. The neighbors are hooked up one level at a time. Finally the
tree is printed out in a left to right manner. I borrowed inspiration on how to print out a tree from Stack Overflow http://stackoverflow.com/questions/1649027/how-do-i-print-out-a-tree-structure.
I was trying for about an hour to print the tree vertically but realized that I would have to store the tree in a special
structure in order to know how to print it correctly. I settled on a simple left to right printing method and modified the 
Stack Overflow on for my needs. 

Code is organized very simply. There is the main program that calls the method to create a tree. Most of the meat of the program
is in the Tree class. It handles creating the entire tree correctly. Node is simply a data holder class except for the print
method is found in it. Main starts up Tree and then the Tree class handles the rest of the flow of the program. 

Interesting optimizations: I wouldn't call this an "optimization" but in order to get the tree to hook up neighbors correctly, I
had to do a weird thing in the SetNeighbors method. I found through trial and error that certain sides of the tree weren't 
getting their values updated in time for the other side to use them. As a result, all of the subsequent data on one side
of the tree was wrong. To fix this, I looped through the entire SeteNeighbors method an extra time for every level we were at
past level 4. This solved the problem and the program now can print out trees with large level numbers. 
