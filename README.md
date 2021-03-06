**Kangaroo**

Problem: https://www.hackerrank.com/challenges/kangaroo/problem

There are two kangaroos on a number line ready to jump in the positive direction (i.e, toward ). Each kangaroo takes the same amount of time to make a jump, regardless of distance. That is, if kangaroo one jumps 3 meters and kangaroo two jumps 5 meters, they each do it in one second, for example.

Given the starting locations and jump distances for each kangaroo, determine if and when they will land at the same location at the same time.

**Input Format**

A single line of four space-separated integers denoting the respective values of x1, v1, x2, and v2.

**Output Format**

Print `YES` if they can land on the same location at the same time; otherwise, print `NO`.

**Note:** The two kangaroos must land at the same location after making the same number of jumps.

**Sample Input 0**

`0 3 4 2`

**Sample Output 0**

`YES`

**Explanation 0**

The two kangaroos jump through the following sequence of locations: 

[![](https://s3.amazonaws.com/hr-assets/0/1516005283-e74e76ff0c-kangaroo.png)](https://s3.amazonaws.com/hr-assets/0/1516005283-e74e76ff0c-kangaroo.png)

The kangaroos meet after 4 jumps.

**Sample Input 1**

`0 2 5 3`

**Sample Output 1**

`NO`

**Explanation 1**

Kangaroo 2 is travelling faster than kangaroo 1, so they will never meet.
