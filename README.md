# WPF_Test_Puzzle
WPF simple ui application containing some puzzle to solve. Perfect for testing windows ui automation modules and for testing simple decision making proccess. This application contains two ui tests applications and one blocker window called Notifier. One being simple the second being complex.

## Simple puzzle
Contains three stages:
1. stage 1 : Switch the username with password and get the flag
2. stage 2 : Check the checkboxes as it is marked in the solution column and get the flag
3. stage 3 : Give the both flags

Congratulation the puzzle is succesfully solved.

## Complex puzzle
Contains 4 by 4 table filled with 3 state checkboxes. The 3 states are : **unchecked** state, checked with **tick** and checked with **rectangle**.
To Solve this puzzle: at least one row or one column of checkboxes is needed to be checked by rectangles or one of both diagonal lines are checked by tickes.

## Notifier
Notifier application is an empty windows window which is intended to use to cover and block other elements on windows desktop.
