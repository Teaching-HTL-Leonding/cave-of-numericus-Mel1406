# The Mysterious Cave of Numericus

![Cave of Numericus (generated with DALL-E)](./title.png)

## Introduction

Long ago in the land of Algozia, there was a mysterious cave named the Cave of Numericus. This cave was believed to hold the secrets of the ancient Algozian civilization. Over the centuries, many adventurers attempted to navigate the cave, but none were successful. Legend has it that the cave was filled with magical number stones that would reveal the path to the secret chamber only if the chosen one could solve the riddles embedded within them.

As an aspiring adventurer, you wish to be the first to uncover the secrets hidden within the Cave of Numericus. To do so, you must unlock the ancient Algozian code using your coding skills. The number stones in the cave are scattered throughout its chambers, and you must find a way to decipher their message.

## Basic Requirements

To begin your quest, follow these steps:

1. Generate 20 random number stones: Write a C# program that generates 20 random numbers (>= 1 and <= 100) and stores them in an array or a list.

2. Sort the number stones: To reveal the secret path, the number stones must be placed in **ascending order**. Write code to sort the numbers you generated in step 1. Can you remember the [folk dance group](https://youtu.be/Iv3vgjM8Pv4) dancing *Bubble Sort*?

3. Calculate the average distance between each value pair: As you navigate the cave, you realize that the ancient Algozians left a clue to the secret chamber's location in the average distance between each consecutive value pair of number stones (first to second, second to third, etc.). Calculate the average distance between each value pair in your sorted list.

Upon successfully completing these tasks, you will have deciphered the numeric code and unlocked the secrets of the Cave of Numericus. May your quest for knowledge be filled with adventure and excitement as you journey deeper into the world of computer science!

⚠️ You are allowed to use an existing sorting function built into .NET if you can find out how it is called and how you use it. Use a search engine or an AI to find out. However, you **must** also implement a sorting algorithm yourself, too (e.g. bubble sort or any other sorting algorithm that you can figure out).

## Test Data

If you want to test the correctness of your program, generate a *seeded* random number generator at the beginning of your program:

```cs
var rand = new Random(4711);
```

Generate the random values with `var randomValue = rand.Next(1, 101);`. If you do that, the result of your program (i.e. the average distance of the value pairs) should be approx. 4.47368.

## Level 2

Is your algorithm fast enough? Try to generate 75000 values between 1 and 1 billon (10^9). The correct result for this is approx. 13333.4243.

## Level 3 (⚠️ Hard)

You have to rethink your entire solution because now you have to generate 1 million values between 1 and 1 billon (10^9). The correct result for this is approx. 999.99969.
