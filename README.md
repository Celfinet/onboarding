# onboarding
Onboarding exercises

__Initial Setup__
- Clone this repository;
- Create a new branch based on `master` named `colleague/\<CELFINET_ID\>`, for example `colleague/diogo.pinho`;
- Solve the following tasks on the created branch based on your buddy indications;


## 1 - Algorithm exercises

__Objectives__

- Familiarize with Visual Studio, C# language and source control tools;
- Soft algorithmic warm up;

__Overview__
- Create a Blank Visual Studio Solution;
- Create a folder on the solution named `HackerRank`;
- For each exercise (see below) a new C# console application project must be added (inside the created folder);
- Each solved exercise is expected to have a least one `commit` associated with it;
- There is no need to solve all the exercises, only to get familiar with the tools and debug capabilities;
- Any question or difficulty don't hesitate to ask your buddy!

__Hacker Rank Exercises__

- [Simple Array Sum](https://www.hackerrank.com/challenges/simple-array-sum)
- [Staircase](https://www.hackerrank.com/challenges/staircase)
- [Utopian Tree](https://www.hackerrank.com/challenges/utopian-tree)
- [Pangrams](https://www.hackerrank.com/challenges/pangrams)
- [Missing Numbers](https://www.hackerrank.com/challenges/missing-numbers)
- [Fibonacci Modified](https://www.hackerrank.com/challenges/fibonacci-modified)
- [Chocolate Feast](https://www.hackerrank.com/challenges/chocolate-feast)
- [Maximizing XOR](https://www.hackerrank.com/challenges/maximizing-xor)
- [Sherlock and the Beast](https://www.hackerrank.com/challenges/sherlock-and-the-beast)
- [New Year Chaos](https://www.hackerrank.com/challenges/new-year-chaos)
- [Kruskal (MST): Really Special Subtree](https://www.hackerrank.com/challenges/kruskalmstrsub)
- [Prim's (MST) : Special Subtree](https://www.hackerrank.com/challenges/primsmstsub)

## 2 - TDD

__Objectives__

- Familiarize with the TDD (Test Driven Development) concepts and why it is important;
- Develop a super simple but tested solution;
- Familiarize with NUnit and Moq (Test Framework and Mock Library);

__Overview__

_Exercise #1_
- Setup the NUnit integration with Visual Studio (ask your buddy for help);
- Using the previous solution create a folder named `TDD`;
- Create a project with the following interface `IMathToolBox` with a method `int Fibonacci(int n)`;
- Create the classes `MathToolBoxA` and `MathToolBoxB` which implement previous interface:
    - Do NOT implement the method yet! use the TDD methodology;
    - `MathToolBoxA` will implement the method with an interactive approach;
    - `MathToolBoxB` will implement the method with a recursive approach;
- Create a UnitTest project under the TDD folder;
- Create the UnitTests using NUnit and refactor the implementations following the TDD cycle;
- And remember to ask your buddy for help when needed!

_Exercise #2_
- Solve the following [KATA](http://osherove.com/tdd-kata-1/) using the learned TDD practices;
- Create a Project similar to the one on _Exercise 1_;

## 3 - Clean Code / Architecture

## 4 - Sample CI/CD Project
