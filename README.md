# leetcode-by-sev

Решения задач LeetCode на C# (.NET 8).

## Структура проекта

```
LeetCode/
├── Topics/
│   ├── Arrays/
│   ├── HashMaps/
│   ├── TwoPointers/
│   ├── LinkedLists/
│   ├── SlidingWindow/
│   ├── Sorting/
│   ├── BinarySearch/
│   ├── Greedy/
│   ├── Trees/
│   ├── Stack/
│   ├── Queue/
│   ├── Graphs/
│   ├── Backtracking/
│   ├── Heap/
│   ├── DynamicProgramming/
│   └── Other/
└── Models/              # ListNode, TreeNode, Node, GraphNode, MultilevelNode

LeetCode.Tests/
└── Topics/              # тесты зеркалят структуру решений
```

Каждый файл с решением содержит:
- номер и ссылку на задачу LeetCode
- сложность (Easy / Medium / Hard) и тему
- описание алгоритма
- оценку времени и памяти (Time / Space)

## Запуск тестов

```bash
dotnet test
```

---

## Решённые задачи ✅

### Arrays

| # | Задача | Сложность | Алгоритм |
|---|--------|-----------|----------|
| 179 | [Largest Number](https://leetcode.com/problems/largest-number/) | Medium | Custom Sort |
| 283 | [Move Zeroes](https://leetcode.com/problems/move-zeroes/) | Easy | Two Pointers |
| 442 | [Find All Duplicates in an Array](https://leetcode.com/problems/find-all-duplicates-in-an-array/) | Medium | Index Negation |
| 525 | [Contiguous Array](https://leetcode.com/problems/contiguous-array/) | Medium | Prefix Sum + Hash Map |
| 560 | [Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/) | Medium | Prefix Sum + Hash Map |
| 724 | [Find Pivot Index](https://leetcode.com/problems/find-pivot-index/) | Easy | Prefix Sum |
| 845 | [Longest Mountain in Array](https://leetcode.com/problems/longest-mountain-in-array/) | Medium | Single Pass |

### Linked Lists

| # | Задача | Сложность | Алгоритм |
|---|--------|-----------|----------|
| 2 | [Add Two Numbers](https://leetcode.com/problems/add-two-numbers/) | Medium | Iterative / Recursive |

---

## К решению (скелеты готовы) 🔲

### Hash Maps

| # | Задача | Сложность |
|---|--------|-----------|
| 1 | [Two Sum](https://leetcode.com/problems/two-sum/) | Easy |
| 49 | [Group Anagrams](https://leetcode.com/problems/group-anagrams/) | Medium |
| 128 | [Longest Consecutive Sequence](https://leetcode.com/problems/longest-consecutive-sequence/) | Medium |
| 290 | [Word Pattern](https://leetcode.com/problems/word-pattern/) | Easy |
| 299 | [Bulls and Cows](https://leetcode.com/problems/bulls-and-cows/) | Medium |

### Two Pointers

| # | Задача | Сложность |
|---|--------|-----------|
| 11 | [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | Medium |
| 15 | [3Sum](https://leetcode.com/problems/3sum/) | Medium |
| 42 | [Trapping Rain Water](https://leetcode.com/problems/trapping-rain-water/) ⭐ | Hard |
| 75 | [Sort Colors](https://leetcode.com/problems/sort-colors/) | Medium |
| 125 | [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | Easy |
| 986 | [Interval List Intersections](https://leetcode.com/problems/interval-list-intersections/) | Medium |

### Arrays

| # | Задача | Сложность |
|---|--------|-----------|
| 26 | [Remove Duplicates from Sorted Array](https://leetcode.com/problems/remove-duplicates-from-sorted-array/) | Easy |
| 48 | [Rotate Image](https://leetcode.com/problems/rotate-image/) | Medium |
| 53 | [Maximum Subarray](https://leetcode.com/problems/maximum-subarray/) | Medium |
| 57 | [Insert Interval](https://leetcode.com/problems/insert-interval/) | Medium |
| 119 | [Pascal's Triangle II](https://leetcode.com/problems/pascals-triangle-ii/) | Easy |
| 152 | [Maximum Product Subarray](https://leetcode.com/problems/maximum-product-subarray/) | Medium |
| 400 | [Nth Digit](https://leetcode.com/problems/nth-digit/) | Medium |
| 493 | [Reverse Pairs](https://leetcode.com/problems/reverse-pairs/) ⭐ | Hard |
| 628 | [Maximum Product of Three Numbers](https://leetcode.com/problems/maximum-product-of-three-numbers/) | Easy |

### Скользящее окно

| # | Задача | Сложность |
|---|--------|-----------|
| 76 | [Minimum Window Substring](https://leetcode.com/problems/minimum-window-substring/) ⭐ | Hard |
| 209 | [Minimum Size Subarray Sum](https://leetcode.com/problems/minimum-size-subarray-sum/) | Medium |
| 239 | [Sliding Window Maximum](https://leetcode.com/problems/sliding-window-maximum/) ⭐ | Hard |
| 424 | [Longest Repeating Character Replacement](https://leetcode.com/problems/longest-repeating-character-replacement/) | Medium |
| 438 | [Find All Anagrams in a String](https://leetcode.com/problems/find-all-anagrams-in-a-string/) | Medium |
| 643 | [Maximum Average Subarray I](https://leetcode.com/problems/maximum-average-subarray-i/) | Easy |
| 904 | [Fruit Into Baskets](https://leetcode.com/problems/fruit-into-baskets/) | Medium |
| 1004 | [Maximum Consecutive Ones III](https://leetcode.com/problems/maximum-consecutive-ones-iii/) | Medium |
| 1695 | [Maximum Erasure Value](https://leetcode.com/problems/maximum-erasure-value/) | Medium |

### Сортировки

| # | Задача | Сложность |
|---|--------|-----------|
| 56 | [Merge Intervals](https://leetcode.com/problems/merge-intervals/) | Medium |

### Бинарный поиск

| # | Задача | Сложность |
|---|--------|-----------|
| 4 | [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) ⭐ | Hard |
| 153 | [Find Minimum in Rotated Sorted Array](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/) | Medium |
| 162 | [Find Peak Element](https://leetcode.com/problems/find-peak-element/) | Medium |
| 278 | [First Bad Version](https://leetcode.com/problems/first-bad-version/) | Easy |
| 875 | [Koko Eating Bananas](https://leetcode.com/problems/koko-eating-bananas/) | Medium |
| 1283 | [Find the Smallest Divisor Given a Threshold](https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold/) | Medium |
| 1818 | [Minimum Absolute Sum Difference](https://leetcode.com/problems/minimum-absolute-sum-difference/) | Medium |

### Greedy

| # | Задача | Сложность |
|---|--------|-----------|
| 45 | [Jump Game II](https://leetcode.com/problems/jump-game-ii/) | Medium |
| 55 | [Jump Game](https://leetcode.com/problems/jump-game/) | Medium |
| 121 | [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | Easy |
| 134 | [Gas Station](https://leetcode.com/problems/gas-station/) | Medium |
| 135 | [Candy](https://leetcode.com/problems/candy/) ⭐ | Hard |
| 435 | [Non-overlapping Intervals](https://leetcode.com/problems/non-overlapping-intervals/) | Medium |
| 763 | [Partition Labels](https://leetcode.com/problems/partition-labels/) | Medium |

### Односвязные списки

| # | Задача | Сложность |
|---|--------|-----------|
| 19 | [Remove Nth Node From End of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/) | Medium |
| 21 | [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | Easy |
| 24 | [Swap Nodes in Pairs](https://leetcode.com/problems/swap-nodes-in-pairs/) | Medium |
| 25 | [Reverse Nodes in K-Group](https://leetcode.com/problems/reverse-nodes-in-k-group/) ⭐ | Hard |
| 61 | [Rotate List](https://leetcode.com/problems/rotate-list/) | Medium |
| 82 | [Remove Duplicates from Sorted List II](https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/) | Medium |
| 83 | [Remove Duplicates from Sorted List](https://leetcode.com/problems/remove-duplicates-from-sorted-list/) | Easy |
| 86 | [Partition List](https://leetcode.com/problems/partition-list/) | Medium |
| 92 | [Reverse Linked List II](https://leetcode.com/problems/reverse-linked-list-ii/) | Medium |
| 114 | [Flatten Binary Tree to Linked List](https://leetcode.com/problems/flatten-binary-tree-to-linked-list/) | Medium |
| 141 | [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | Easy |
| 142 | [Linked List Cycle II](https://leetcode.com/problems/linked-list-cycle-ii/) | Medium |
| 206 | [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/) | Easy |
| 430 | [Flatten a Multilevel Doubly Linked List](https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/) | Medium |

### Деревья — ДФС

| # | Задача | Сложность |
|---|--------|-----------|
| 100 | [Same Tree](https://leetcode.com/problems/same-tree/) | Easy |
| 101 | [Symmetric Tree](https://leetcode.com/problems/symmetric-tree/) | Easy |
| 104 | [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/) | Easy |
| 105 | [Construct Binary Tree from Preorder and Inorder Traversal](https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/) | Medium |
| 110 | [Balanced Binary Tree](https://leetcode.com/problems/balanced-binary-tree/) | Easy |
| 111 | [Minimum Depth of Binary Tree](https://leetcode.com/problems/minimum-depth-of-binary-tree/) | Easy |
| 112 | [Path Sum](https://leetcode.com/problems/path-sum/) | Easy |
| 113 | [Path Sum II](https://leetcode.com/problems/path-sum-ii/) | Medium |
| 226 | [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/) | Easy |
| 257 | [Binary Tree Paths](https://leetcode.com/problems/binary-tree-paths/) | Easy |
| 652 | [Find Duplicate Subtrees](https://leetcode.com/problems/find-duplicate-subtrees/) | Medium |
| 863 | [All Nodes Distance K in Binary Tree](https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/) | Medium |
| 865 | [Smallest Subtree with All the Deepest Nodes](https://leetcode.com/problems/smallest-subtree-with-all-the-deepest-nodes/) | Medium |

### Деревья — БФС

| # | Задача | Сложность |
|---|--------|-----------|
| 102 | [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | Medium |
| 103 | [Binary Tree Zigzag Level Order Traversal](https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/) | Medium |
| 107 | [Binary Tree Level Order Traversal II](https://leetcode.com/problems/binary-tree-level-order-traversal-ii/) | Medium |
| 116 | [Populating Next Right Pointers in Each Node](https://leetcode.com/problems/populating-next-right-pointers-in-each-node/) | Medium |
| 199 | [Binary Tree Right Side View](https://leetcode.com/problems/binary-tree-right-side-view/) | Medium |
| 513 | [Find Bottom Left Tree Value](https://leetcode.com/problems/find-bottom-left-tree-value/) | Medium |

### Деревья поиска (BST)

| # | Задача | Сложность |
|---|--------|-----------|
| 95 | [Unique Binary Search Trees II](https://leetcode.com/problems/unique-binary-search-trees-ii/) | Medium |
| 96 | [Unique Binary Search Trees](https://leetcode.com/problems/unique-binary-search-trees/) | Medium |
| 98 | [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | Medium |
| 108 | [Convert Sorted Array to Binary Search Tree](https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/) | Easy |
| 230 | [Kth Smallest Element in a BST](https://leetcode.com/problems/kth-smallest-element-in-a-bst/) | Medium |
| 235 | [Lowest Common Ancestor of a BST](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/) | Medium |
| 297 | [Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree/) ⭐ | Hard |
| 530 | [Minimum Absolute Difference in BST](https://leetcode.com/problems/minimum-absolute-difference-in-bst/) | Easy |

### Стек

| # | Задача | Сложность |
|---|--------|-----------|
| 71 | [Simplify Path](https://leetcode.com/problems/simplify-path/) | Medium |
| 84 | [Largest Rectangle in Histogram](https://leetcode.com/problems/largest-rectangle-in-histogram/) ⭐ | Hard |
| 150 | [Evaluate Reverse Polish Notation](https://leetcode.com/problems/evaluate-reverse-polish-notation/) | Medium |
| 155 | [Min Stack](https://leetcode.com/problems/min-stack/) | Medium |
| 232 | [Implement Queue Using Stacks](https://leetcode.com/problems/implement-queue-using-stacks/) | Easy |
| 388 | [Longest Absolute File Path](https://leetcode.com/problems/longest-absolute-file-path/) | Medium |
| 402 | [Remove K Digits](https://leetcode.com/problems/remove-k-digits/) | Medium |
| 496 | [Next Greater Element I](https://leetcode.com/problems/next-greater-element-i/) | Easy |
| 735 | [Asteroid Collision](https://leetcode.com/problems/asteroid-collision/) | Medium |
| 739 | [Daily Temperatures](https://leetcode.com/problems/daily-temperatures/) | Medium |
| 1209 | [Remove All Adjacent Duplicates in String II](https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/) | Medium |

### Очередь

| # | Задача | Сложность |
|---|--------|-----------|
| 225 | [Implement Stack Using Queues](https://leetcode.com/problems/implement-stack-using-queues/) | Easy |

### Графы

| # | Задача | Сложность |
|---|--------|-----------|
| 133 | [Clone Graph](https://leetcode.com/problems/clone-graph/) | Medium |
| 200 | [Number of Islands](https://leetcode.com/problems/number-of-islands/) | Medium |
| 207 | [Course Schedule](https://leetcode.com/problems/course-schedule/) | Medium |
| 210 | [Course Schedule II](https://leetcode.com/problems/course-schedule-ii/) | Medium |
| 433 | [Minimum Genetic Mutation](https://leetcode.com/problems/minimum-genetic-mutation/) | Medium |
| 547 | [Number of Provinces](https://leetcode.com/problems/number-of-provinces/) | Medium |
| 733 | [Flood Fill](https://leetcode.com/problems/flood-fill/) | Easy |
| 743 | [Network Delay Time](https://leetcode.com/problems/network-delay-time/) | Medium |
| 841 | [Keys and Rooms](https://leetcode.com/problems/keys-and-rooms/) | Medium |
| 994 | [Rotting Oranges](https://leetcode.com/problems/rotting-oranges/) | Medium |

### Backtracking

| # | Задача | Сложность |
|---|--------|-----------|
| 17 | [Letter Combinations of a Phone Number](https://leetcode.com/problems/letter-combinations-of-a-phone-number/) | Medium |
| 22 | [Generate Parentheses](https://leetcode.com/problems/generate-parentheses/) | Medium |
| 37 | [Sudoku Solver](https://leetcode.com/problems/sudoku-solver/) ⭐ | Hard |
| 39 | [Combination Sum](https://leetcode.com/problems/combination-sum/) | Medium |
| 40 | [Combination Sum II](https://leetcode.com/problems/combination-sum-ii/) | Medium |
| 46 | [Permutations](https://leetcode.com/problems/permutations/) | Medium |
| 47 | [Permutations II](https://leetcode.com/problems/permutations-ii/) | Medium |
| 51 | [N-Queens](https://leetcode.com/problems/n-queens/) ⭐ | Hard |
| 78 | [Subsets](https://leetcode.com/problems/subsets/) | Medium |
| 79 | [Word Search](https://leetcode.com/problems/word-search/) | Medium |
| 93 | [Restore IP Addresses](https://leetcode.com/problems/restore-ip-addresses/) | Medium |
| 131 | [Palindrome Partitioning](https://leetcode.com/problems/palindrome-partitioning/) | Medium |
| 216 | [Combination Sum III](https://leetcode.com/problems/combination-sum-iii/) | Medium |
| 526 | [Beautiful Arrangement](https://leetcode.com/problems/beautiful-arrangement/) | Medium |

### Куча (Heap)

| # | Задача | Сложность |
|---|--------|-----------|
| 23 | [Merge K Sorted Lists](https://leetcode.com/problems/merge-k-sorted-lists/) ⭐ | Hard |
| 215 | [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | Medium |
| 347 | [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | Medium |
| 378 | [Kth Smallest Element in a Sorted Matrix](https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/) | Medium |
| 480 | [Sliding Window Median](https://leetcode.com/problems/sliding-window-median/) ⭐ | Hard |
| 621 | [Task Scheduler](https://leetcode.com/problems/task-scheduler/) | Medium |
| 703 | [Kth Largest Element in a Stream](https://leetcode.com/problems/kth-largest-element-in-a-stream/) | Easy |
| 767 | [Reorganize String](https://leetcode.com/problems/reorganize-string/) | Medium |
| 1046 | [Last Stone Weight](https://leetcode.com/problems/last-stone-weight/) | Easy |

### Динамическое программирование

| # | Задача | Сложность |
|---|--------|-----------|
| 5 | [Longest Palindromic Substring](https://leetcode.com/problems/longest-palindromic-substring/) | Medium |
| 10 | [Regular Expression Matching](https://leetcode.com/problems/regular-expression-matching/) ⭐ | Hard |
| 62 | [Unique Paths](https://leetcode.com/problems/unique-paths/) | Medium |
| 63 | [Unique Paths II](https://leetcode.com/problems/unique-paths-ii/) | Medium |
| 64 | [Minimum Path Sum](https://leetcode.com/problems/minimum-path-sum/) | Medium |
| 70 | [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/) | Easy |
| 72 | [Edit Distance](https://leetcode.com/problems/edit-distance/) | Medium |
| 198 | [House Robber](https://leetcode.com/problems/house-robber/) | Medium |
| 213 | [House Robber II](https://leetcode.com/problems/house-robber-ii/) | Medium |
| 279 | [Perfect Squares](https://leetcode.com/problems/perfect-squares/) | Medium |
| 300 | [Longest Increasing Subsequence](https://leetcode.com/problems/longest-increasing-subsequence/) | Medium |
| 322 | [Coin Change](https://leetcode.com/problems/coin-change/) | Medium |
| 329 | [Longest Increasing Path in a Matrix](https://leetcode.com/problems/longest-increasing-path-in-a-matrix/) ⭐ | Hard |
| 416 | [Partition Equal Subset Sum](https://leetcode.com/problems/partition-equal-subset-sum/) | Medium |
| 464 | [Can I Win](https://leetcode.com/problems/can-i-win/) | Medium |
| 516 | [Longest Palindromic Subsequence](https://leetcode.com/problems/longest-palindromic-subsequence/) | Medium |
| 583 | [Delete Operation for Two Strings](https://leetcode.com/problems/delete-operation-for-two-strings/) | Medium |
| 647 | [Palindromic Substrings](https://leetcode.com/problems/palindromic-substrings/) | Medium |
| 877 | [Stone Game](https://leetcode.com/problems/stone-game/) | Medium |
| 1035 | [Uncrossed Lines](https://leetcode.com/problems/uncrossed-lines/) | Medium |
| 1143 | [Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/) | Medium |

### Остальное

| # | Задача | Сложность |
|---|--------|-----------|
| 6 | [Zigzag Conversion](https://leetcode.com/problems/zigzag-conversion/) | Medium |
| 8 | [String to Integer (atoi)](https://leetcode.com/problems/string-to-integer-atoi/) | Medium |
| 88 | [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | Easy |
| 498 | [Diagonal Traverse](https://leetcode.com/problems/diagonal-traverse/) | Medium |

---

⭐ — сложная задача
